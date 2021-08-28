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
    public partial class RegistracijaForm : Form
    {
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        KnjiznicaEntities ent = new KnjiznicaEntities();
        EnkripcijaSHA sh = new EnkripcijaSHA();
        admin adm;

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (korisnickoTxt.Text != string.Empty && lozinkaPonTxt.Text != string.Empty && lozinkaTxt.Text != string.Empty)
            {
                if (lozinkaTxt.Text == lozinkaPonTxt.Text)
                {
                    adm = new admin();
                    adm.korisnickoIme = korisnickoTxt.Text;
                    adm.lozinka = sh.Enkriptiraj(lozinkaTxt.Text);

                    ent.admin.Add(adm);
                    ent.SaveChanges();
                }
            }
        }
    }
}
