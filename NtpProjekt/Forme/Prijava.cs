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
                    if (user.lozinka.Equals(lozinkaTxt.Text))
                    {
                        MainMenu main = new MainMenu();
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
