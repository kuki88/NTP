using Microsoft.Win32;
using NtpProjekt.Forme;
using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpProjekt
{
    public partial class MainMenu : Form
    {

        SimpleTcpClient client;
        admin user;

        public MainMenu()
        {
            InitializeComponent();

            clanBtn.Enabled = false;
            dodajUkloniBtn.Enabled = false;
            posaljiBtn.Enabled = false;
            posudbaBtn.Enabled = false;
            spojiBtn.Enabled = false;
            vracanjeBtn.Enabled = false;
        }

        public MainMenu(admin _user)
        {
            InitializeComponent();
            user = _user;

            adminLbl.Text = user.korisnickoIme;
        }

        private void dodajUkloniBtn_Click(object sender, EventArgs e)
        {
            KnjigeForm obj = new KnjigeForm();
            obj.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            RegistryKey registar = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NtpProjektSettings");

            //Postavljanje postavki iz Registra
            if (registar != null)
            {
                int pozicijaX = int.Parse(registar.GetValue("LocationX").ToString());
                int pozicijaY = int.Parse(registar.GetValue("LocationY").ToString());
                int width = int.Parse(registar.GetValue("Width").ToString());
                int height = int.Parse(registar.GetValue("Height").ToString());
                try
                {
                    if (registar.GetValue("FullScreen").ToString() != null)
                    {

                        if (registar.GetValue("FullScreen").ToString().ToUpper() == "TRUE")
                        {
                            this.Size = new Size(width - 500, height - 500);
                            this.WindowState = FormWindowState.Maximized;
                            this.Location = new Point(pozicijaX + 200, pozicijaY + 200);
                        }
                        else
                        {
                            this.Size = new Size(width, height);
                            this.Location = new Point(pozicijaX, pozicijaY);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Greška kod postavljanja veličine prozora!");
                }
                foreach (Control ctr in this.Controls)
                {
                    ctr.Font = new Font(ctr.Font.Name, float.Parse(registar.GetValue("FontSize").ToString()));
                    if (ctr.HasChildren)
                    {
                        foreach (Control childControl in ctr.Controls)
                        {
                            ctr.Font = new Font(ctr.Font.Name, float.Parse(registar.GetValue("FontSize").ToString()));
                        }
                    }
                }
            }

            //TCP Klijent
            client = new SimpleTcpClient(serverIpTxt.Text);
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
            posaljiBtn.Enabled = false;

        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text = $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });

        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text = $"Server disconnected.{Environment.NewLine}";
            });

        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text = $"Server connected.{Environment.NewLine}";
            });
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey registar = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NtpProjektSettings");

            registar.SetValue("LocationY", this.Location.Y);
            registar.SetValue("LocationX", this.Location.X);
            if (this.WindowState == FormWindowState.Maximized) registar.SetValue("FullScreen", true);
            else registar.SetValue("FullScreen", false);
            registar.SetValue("Width", this.Width);
            registar.SetValue("Height", this.Height);
            registar.Close();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClanoviForm forma = new ClanoviForm();
            forma.Show();
        }

        private void posudbaBtn_Click(object sender, EventArgs e)
        {
            PosudbaForm forma = new PosudbaForm();
            forma.Show();
        }

        private void vracanjeBtn_Click(object sender, EventArgs e)
        {
            VracanjeKnjige forma = new VracanjeKnjige();
            forma.Show();
        }


        private void povećajFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                ctr.Font = new Font(ctr.Font.Name, ctr.Font.Size + 2);
                if (ctr.HasChildren)
                {
                    foreach (Control childControl in ctr.Controls)
                    {
                        ctr.Font = new Font(ctr.Font.Name, ctr.Font.Size + 2);
                    }
                }
            }
            //if (this.label1.Font.Size < 72)
            //{
            //    this.label1.Font = new Font(this.Font.Name, this.label1.Font.Size + 2);
            //}
        }

        private void smanjiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                ctr.Font = new Font(ctr.Font.Name, ctr.Font.Size - 2);
                if (ctr.HasChildren)
                {
                    foreach (Control childControl in ctr.Controls)
                    {
                        ctr.Font = new Font(ctr.Font.Name, ctr.Font.Size - 2);
                    }
                }
            }
            //if (this.label1.Font.Size >= 0)
            //{
            //    this.label1.Font = new Font(this.Font.Name, this.label1.Font.Size - 2);
            //}
        }

        private void spojiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                posaljiBtn.Enabled = true;
                spojiBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspješno spajanje na poslužitelja! " + "(" + ex.Message + ")", "Neuspješno spajanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void posaljiBtn_Click(object sender, EventArgs e)
        {
            DinamickiLibrary.EnkripcijaRSA rsa = new DinamickiLibrary.EnkripcijaRSA(); 
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(porukaTxt.Text))
                {
                    client.Send(porukaTxt.Text);
                    using (RSACryptoServiceProvider csp = new RSACryptoServiceProvider())
                    {
                        rsa.podatakZaKriptiranje = porukaTxt.Text;

                        rsa.RSAEnkripcija(csp.ExportParameters(false), false);

                        client.Send(rsa.enkriptiraniPodatak);

                        rsa.RSADekripcija(csp.ExportParameters(true), false);
                        MessageBox.Show(rsa.dekriptiraniPodatak);
                    }

                    porukaTxt.Text += $"Me: {porukaTxt.Text}{Environment.NewLine}";
                    porukaTxt.Text = string.Empty;
                }
            }


        }
    }
}
