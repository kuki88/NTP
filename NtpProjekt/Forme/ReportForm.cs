using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpProjekt.Forme
{
    public partial class ReportForm : Form
    {

        public ReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestClient klijent = new RestClient();
            klijent.krajnjaTocka = txtLink.Text;

            string odgovor = string.Empty;

            odgovor = klijent.napraviZahtjev();
            txtOdgovor.Text = odgovor;
        }
    }
}
