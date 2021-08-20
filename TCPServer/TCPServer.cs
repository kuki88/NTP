using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{


    public partial class TCPServerForm : Form
    {
        KnjiznicaManagementEntities entity = new KnjiznicaManagementEntities();

        public TCPServerForm()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;


        private void Form1_Load(object sender, EventArgs e)
        {
            posaljiBtn.Enabled = false;
            server = new SimpleTcpServer(serverIpTxt.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;

        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string str = Encoding.UTF8.GetString(e.Data);
                List<Posudbe> lista = entity.Posudbe.Where(x => x.clanskiBroj == str).ToList();
                double racun = 0;
                foreach (Posudbe posudba in lista)
                {
                    int dani = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(posudba.datumPovratka)).TotalDays);
                    if (dani > 0)
                    {
                        racun += (dani * 0.5);
                    }
                }
                if (server.IsListening)
                {
                    if (spojeniKlijentTxt.Text != null)
                    {
                        server.Send(spojeniKlijentTxt.Text, racun.ToString());
                        infoTxt.Text += $"Server: Poslao {Environment.NewLine}";
                        infoTxt.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Nije odabrana ni jedna IP adresa");
                        server.Send(spojeniKlijentTxt.Text, racun.ToString());
                    }
                }
                infoTxt.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text += $"{e.IpPort}: disconnected.{Environment.NewLine}";
                spojeniKlijentTxt.Text = string.Empty;
            });
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text += $"{e.IpPort}: connected.{Environment.NewLine}";
                spojeniKlijentTxt.Text = e.IpPort;
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void spojiBtn_Click(object sender, EventArgs e)
        {
            server.Start();
            infoTxt.Text += $"Pokretanje... {Environment.NewLine}";
            spojiBtn.Enabled = false;
            posaljiBtn.Enabled = true;
        }

        private void posaljiBtn_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(porukaTxt.Text) && spojeniKlijentTxt.Text != null)
                {
                    server.Send(spojeniKlijentTxt.Text, porukaTxt.Text);
                    infoTxt.Text += $"Server: {infoTxt.Text} {Environment.NewLine}";
                    infoTxt.Text = string.Empty;
                }
            }
        }

        private void iskljuciBtn_Click(object sender, EventArgs e)
        {
            server.Stop();
            infoTxt.Text += $"Server se isključuje... {Environment.NewLine}";
            spojiBtn.Enabled = true;
            posaljiBtn.Enabled = false;
        }
    }
}
