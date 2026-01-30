using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpPractise
{
    public partial class BmsGui : Form
    {
        SerialPort _sp = new SerialPort();

        static int debugCount = 0;
        const int txBufferLen = 8;
        const int rxBufferLen = 1024;
        byte[] rxBuffer = new byte[20];
        public BmsGui()
        {
            InitializeComponent();
            SerialPortDeInit();
            rtbDebugWindow.Text = "Start!";
        }

        #region serial port operation

        private void btnSerialPortOpen_Click(object sender, EventArgs e)
        {
            if (btnSerialPortOpen.Text == "OPEN")
            {
                btnSerialPortOpen.Text = "CLOSE";
                btnSerialPortOpen.BackColor = Color.Green;
                _sp.PortName = cbbPortName.SelectedItem.ToString();
                _sp.BaudRate = int.Parse(cbbBaudRate.SelectedItem.ToString());
                _sp.DataBits = 8;
                _sp.StopBits = StopBits.One;
                _sp.Parity   = Parity.None;
                _sp.Open();
                _sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedhandler);
            }
            else
            {
                btnSerialPortOpen.Text = "OPEN";
                btnSerialPortOpen.BackColor = Color.Red;
                _sp.Close();
            }
            //MessageBox.Show("this is a windows form project!");
        }

        private void SerialPortRefresh(object sender, EventArgs e)
        {
            cbbPortName.Items.Clear();
            string[] portName = new string[10];

            portName = SerialPort.GetPortNames();

            foreach (string str in portName)
            {
                System.Diagnostics.Debug.WriteLine($"{str}");
                cbbPortName.Items.Add(str);
            }
            System.Diagnostics.Debug.WriteLine($"{debugCount ++}");
        }

        private void SerialPortDeInit()
        {
            cbbPortName.Text = "No Comm";
            cbbBaudRate.Items.Add("9600");
            cbbBaudRate.Items.Add("19200");
            cbbBaudRate.Items.Add("38400");
            cbbBaudRate.Items.Add("115200");
            //cbbBaudRate.SelectedItem = "115200";
            cbbBaudRate.SelectedIndex = 3;
            btnSerialPortOpen.BackColor = Color.Red;
        }

        private void SerialPortSendData(object sender, EventArgs e)
        {
            byte[] txBuffer = new byte[txBufferLen];
            txBuffer[0] = 100;
            txBuffer[1] = 11;
            txBuffer[2] = 22;
            txBuffer[3] = 33;
            txBuffer[4] = 44;
            txBuffer[5] = 55;
            txBuffer[6] = 66;
            txBuffer[7] = 101;
            try
            {
                _sp.Write(txBuffer, 0, txBufferLen);
                LogPrint(LogType.DataInfo, "Write data successful!");
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("uart exception!");
                //throw;
            }           
        }

        private void DataReceivedhandler(object sender, SerialDataReceivedEventArgs e)
        {
            //LogPrint(LogType.DataInfo, "Receive data successful!");
            int data;
            string receiveData;
            System.Diagnostics.Debug.WriteLine(sender.ToString());
            //receiveData = _sp.Read();
            //data = _sp.ReadChar();
            _sp.Read(rxBuffer, 0, 8);

            foreach (byte b in rxBuffer)
            {
                System.Diagnostics.Debug.WriteLine(b.ToString());
            }     
        }

        #endregion end of seiral port operation

        #region debug operation

        public enum LogType
        {
            OperationInfo,
            DataInfo,
            Warning
        }
        public void LogPrint(LogType logType, string message)
        {
            //rtbDebugWindow.SelectionStart = rtbDebugWindow.Text.Length;
            switch (logType)
            {
                case LogType.DataInfo:
                    rtbDebugWindow.SelectionColor = Color.Black;
                    break;
                case LogType.OperationInfo:
                    rtbDebugWindow.SelectionColor = Color.Green;
                    break;
                case LogType.Warning:
                    rtbDebugWindow.SelectionColor = Color.Red;
                    break;
                default:
                    break;
            }

            rtbDebugWindow.AppendText(message);
            rtbDebugWindow.ScrollToCaret();
            rtbDebugWindow.AppendText(Environment.NewLine);
        }
        #endregion end of debug operation
    }
}
