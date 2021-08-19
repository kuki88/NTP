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
    public partial class UrediClanForm : Form
    {
        KnjiznicaEntities obj;
        Clanovi clan;
        public UrediClanForm()
        {
            InitializeComponent();
        }
        
        public UrediClanForm(Clanovi _clan, KnjiznicaEntities _obj)
        {
            InitializeComponent();
            clan = _clan;
            AdresaTxt.Text = clan.adresa;
            ClanskiTxt.Text = clan.clanskiBroj;
            ClanskiTxt.ReadOnly = true;
            ImeTxt.Text = clan.ime;
            PrezimeTxt.Text = clan.prezime;
            TelTxt.Text = clan.telefonskiBroj;
            obj = _obj;
        }

        private void ukloniBtn_Click(object sender, EventArgs e)
        {
            var potvrdaUklanjanja = MessageBox.Show("Jeste li sigurni da želite ukloniti člana iz knjižnice?", "Potvrda brisanja!", MessageBoxButtons.YesNoCancel);
            if (potvrdaUklanjanja == DialogResult.Yes)
            {
                try
                {
                    obj.Clanovi.Remove(obj.Clanovi.Where(x => x.clanskiBroj == clan.clanskiBroj).FirstOrDefault());
                }
                catch (Exception)
                {
                    MessageBox.Show("Pogreška kod uklanjanja člana!");
                }
                obj.SaveChanges();
                this.Close();
            }
        }

        private void urediBtn_Click(object sender, EventArgs e)
        {
            var _clan = obj.Clanovi.Where(x => x.clanskiBroj == clan.clanskiBroj).FirstOrDefault();
            if(_clan != null)
            {
                _clan.ime = ImeTxt.Text;
                _clan.prezime = PrezimeTxt.Text;
                _clan.adresa = AdresaTxt.Text;
                _clan.telefonskiBroj = TelTxt.Text;
                obj.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dogodila se greška prilikom uređivanja!");
            }
        }

    }
}
