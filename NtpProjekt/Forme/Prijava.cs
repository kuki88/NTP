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
    public partial class PrijavaForm : Form
    {

        EnkripcijaSHA es = new EnkripcijaSHA();

        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            KnjiznicaEntities obj = new KnjiznicaEntities();
            if (korisnickoTxt.Text != string.Empty && lozinkaTxt.Text != string.Empty)
            {
                
                var user = obj.admin.Where(x => x.korisnickoIme.Equals(korisnickoTxt.Text)).FirstOrDefault();

                if (user != null)
                {
                    if (user.lozinka.Equals(es.Enkriptiraj(lozinkaTxt.Text)))
                    {
                        MainMenu main = new MainMenu(user);
                        this.Hide();
                        main.ShowDialog();

                        this.Close();
                    }
                    else MessageBox.Show("Neuspješna prijava! (Pogrešna lozinka)");
                }
                else MessageBox.Show("Pogrešno korisničko ime!");
            }
        }
    }
}
