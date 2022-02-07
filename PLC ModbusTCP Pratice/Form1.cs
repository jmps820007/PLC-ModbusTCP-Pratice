using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//參照modbuspc.dll 使用其namespace
using Modbus.Device;        //modbus master
using System.Net;           //for tcp client
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;

namespace PLC_ModbusTCP_Pratice
{
    public partial class Form1 : Form
    {
        [DllImport("WININET", CharSet = CharSet.Auto)]
        static extern bool InternetGetConnectedState(ref InternetConnectionState lpdwFlags, int dwReserved);

        enum InternetConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }
        TcpClient tcpClient;
        ModbusIpMaster master;
        string ipAddress;
        int tcpPort = 502;
        DateTime dtDisconnect = new DateTime();
        DateTime dtNow = new DateTime();
        List<PictureBox> listDI = new List<PictureBox>();
        List<PictureBox> listDO = new List<PictureBox>();
        bool NetworkIsOk = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listDI.Add(DI0);
            listDI.Add(DI1);
            listDI.Add(DI2);
            listDI.Add(DI3);
            listDI.Add(DI4);
            listDI.Add(DI5);

            listDO.Add(DO0);
            listDO.Add(DO1);
            listDO.Add(DO2);
            listDO.Add(DO3);
            listDO.Add(DO4);
            listDO.Add(DO5);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            NetworkIsOk = Connect();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (master != null)
                master.Dispose();
            if (tcpClient != null)
                tcpClient.Close();
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
        }

        private bool Connect()
        {
            ipAddress = tbx_IP.Text;
            if (master != null)
                master.Dispose();
            if (tcpClient != null)
                tcpClient.Close();

            if (CheckInternet())
            {
                try
                {
                    tcpClient = new TcpClient();
                    IAsyncResult asyncResult = tcpClient.BeginConnect(ipAddress, tcpPort, null, null);
                    asyncResult.AsyncWaitHandle.WaitOne(3000, true);
                    if(!asyncResult.IsCompleted)
                    {
                        tcpClient.Close();
                        Console.WriteLine(DateTime.Now.ToString() + " :Cannot connect to server.");
                        return false;
                    }
                    master = ModbusIpMaster.CreateIp(tcpClient);
                    master.Transport.Retries = 0;
                    master.Transport.ReadTimeout = 1500;
                    this.Text = "On line " + DateTime.Now.ToString();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        private bool CheckInternet()
        {
            InternetConnectionState flag = InternetConnectionState.INTERNET_CONNECTION_LAN;
            return InternetGetConnectedState(ref flag, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (NetworkIsOk)
                {
                    #region Master to Slave
                    byte slaveID = 1;
                    bool[] status = master.ReadInputs(slaveID, 0, 6);
                    for (int index = 0; index < 6; index++)
                    {
                        if (status[index] == true)
                            listDI[index].BackColor = Color.Lime;
                        else
                            listDI[index].BackColor = Color.Green;
                    }
                    bool[] coils = master.ReadCoils(slaveID, 0, 6);
                    for (int index = 0; index < 6; index++)
                    {
                        if (coils[index] == true)
                            listDO[index].BackColor = Color.Red;
                        else
                            listDO[index].BackColor = Color.Maroon;
                    }
                    #endregion
                }
                else
                {
                    dtNow = DateTime.Now;
                    if ((dtNow - dtDisconnect) > TimeSpan.FromSeconds(10))
                    {
                        Console.WriteLine(DateTime.Now.ToString() + " :Start connecting");
                        NetworkIsOk = Connect();
                        if (!NetworkIsOk)
                        {
                            Console.WriteLine(DateTime.Now.ToString() + ":Connecting fail. Wait for retry");
                            dtDisconnect = DateTime.Now;
                        }
                    }
                    else
                    {
                        Console.WriteLine(DateTime.Now.ToString() + " :Wait for retry connection");
                    }
                }
            }
            catch
            {

            }
        }
        private void DO_Click(object sender, EventArgs e)
        {
            ushort index = ushort.Parse(((PictureBox)sender).Tag.ToString());
            if (NetworkIsOk)
            {
                if (((PictureBox)sender).BackColor == Color.Maroon)
                    master.WriteSingleCoil(1, index, true);
                else
                    master.WriteSingleCoil(1, index, false);
            }
        }
    }
}
