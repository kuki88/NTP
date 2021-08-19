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
    public partial class ClanoviForm : Form
    {
        KnjiznicaEntities obj = new KnjiznicaEntities();
        Clanovi trazen;

        public ClanoviForm()
        {
            InitializeComponent();
            uClanskiTxt.Enabled = false;
            dClanskiTxt.Enabled = false;
        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            if (uDvoClanskiTxt.Text.Length == 2 && dClanskiTxt.Text.Length == 6)
            {
                string clanskiBr = uDvoClanskiTxt.Text + "/" + dClanskiTxt.Text;
                var ime = dImeTxt.Text;
                var prezime = dPrezimeTxt.Text;
                var telefon = dTelTxt.Text;
                var adresa = dAdresaTxt.Text;

                if (obj.Clanovi.Where(x => x.clanskiBroj == clanskiBr).FirstOrDefault() == null)
                {
                    Clanovi clan = new Clanovi();
                    clan.clanskiBroj = clanskiBr;
                    clan.ime = ime;
                    clan.prezime = prezime;
                    clan.telefonskiBroj = telefon;
                    clan.adresa = adresa;
                    obj.Clanovi.Add(clan);
                    obj.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Član sa tim članskim brojem već postoji!");
                }
            }
            else MessageBox.Show("Neispravan format unešenog članskog broja!");
        }

        private void pretragaBtn_Click(object sender, EventArgs e)
        {
            trazen = obj.Clanovi.Where(x => x.clanskiBroj == (uDvoClanskiTxt.Text + "/" + uClanskiTxt.Text)).FirstOrDefault();
            if (trazen != null)
            {
                uImeTxt.Text = trazen.ime;
                uPrezimeTxt.Text = trazen.prezime;
                uAdresaTxt.Text = trazen.adresa;
                uTelTxt.Text = trazen.telefonskiBroj;
                uImeTxt.ReadOnly = true;
                uPrezimeTxt.ReadOnly = true;
                uAdresaTxt.ReadOnly = true;
                uTelTxt.ReadOnly = true;
                urediBtn.Enabled = true;
            }
            else
            {
                urediBtn.Enabled = false;
                uImeTxt.Text = "";
                uPrezimeTxt.Text = "";
                uAdresaTxt.Text = "";
                uTelTxt.Text = "";
                uImeTxt.ReadOnly = false;
                uPrezimeTxt.ReadOnly = false;
                uAdresaTxt.ReadOnly = false;
                uTelTxt.ReadOnly = false;
                urediBtn.Enabled = false;
            }
            
        }

        private void ukloniBtn_Click(object sender, EventArgs e)
        {
            if(trazen != null)
            {
                UrediClanForm forma = new UrediClanForm(trazen, obj);
                forma.Show();
            }
        }

        private void dvoClanskiTxt_TextChanged(object sender, EventArgs e)
        {
            if(dvoClanskiTxt.Text.Length == 2)
            {
                dClanskiTxt.Enabled = true;
                dClanskiTxt.Focus();
            }
        }

        private void uDvoClanskiTxt_TextChanged(object sender, EventArgs e)
        {
            if (uDvoClanskiTxt.Text.Length == 2)
            {
                uClanskiTxt.Enabled = true;
                uClanskiTxt.Focus();
            }
        }
    }
}
