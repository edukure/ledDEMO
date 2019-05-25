using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledDEMO
{
    public partial class Form1 : Form
    {
        List<string> comPortsList = new List<string>();
        SerialPort serialPort = new SerialPort();
        const int baudRate = 9600;
        bool IsLedOn = false;
          
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            ledButton.Enabled = false;
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (var port in SerialPort.GetPortNames())
            {
                if (!comPortsCombobox.Items.Contains(port))
                {
                    comPortsCombobox.Items.Add(port);
                }
            }
        }

        private void arduinoConnectButton_Click(object sender, EventArgs e)
        {
            if(!serialPort.IsOpen) //serialport.IsOpen == false
            {
                try
                {
                    string portName = comPortsCombobox.Text;
                    serialPort = new SerialPort(portName, baudRate);
                    serialPort.Open();
                    MessageBox.Show("SUCESSO", "Arduino conectado!");
                    timer.Stop();
                    ledButton.Enabled = true;
                }
                catch(IOException exception)
                {
                    MessageBox.Show("ERRO", exception.Message);
                }
            }
        }

        private void ledButton_Click(object sender, EventArgs e)
        {
            if (!IsLedOn)
            {
                serialPort.Write("1");
                ledButton.Text = "DESLIGA LED";
                IsLedOn = true;
            }
            else if (IsLedOn)
            {
                serialPort.Write("0");
                ledButton.Text = "LIGA LED";
                IsLedOn = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                serialPort.Write("0");
                serialPort.Close();
            }
        }
    }

        
}
