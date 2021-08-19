using NtpProjekt.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpProjekt
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void dodajUkloniBtn_Click(object sender, EventArgs e)
        {
            KnjigeForm obj = new KnjigeForm();
            obj.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

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
    }
}
