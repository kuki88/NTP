using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DinamickiLibrary;

namespace NtpProjekt
{
    public partial class PrijavaForm : Form
    {

        //EnkripcijaSHA es = new EnkripcijaSHA();
        DinamickiLibrary.EnkripcijaSHA es = new DinamickiLibrary.EnkripcijaSHA();

        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            //RestClient rs = new RestClient();
            //MessageBox.Show(rs.napraviZahtjev());

            //KnjiznicaEntities obj = new KnjiznicaEntities();
            //if (korisnickoTxt.Text != string.Empty && lozinkaTxt.Text != string.Empty)
            //{

            //    var user = obj.admin.Where(x => x.korisnickoIme.Equals(korisnickoTxt.Text)).FirstOrDefault();

            //    if (user != null)
            //    {
            //        es.dekriptiraniPodatak = lozinkaTxt.Text;
            //        es.Enkriptiraj();
            //        if (user.lozinka.Equals(es.enkriptiraniPodatak))
            //        {
            MainMenu main = new MainMenu(new admin());
            this.Hide();
            main.ShowDialog();

            this.Close();
            //        }
            //        else MessageBox.Show("Neuspješna prijava! (Pogrešna lozinka)");
            //    }
            //    else MessageBox.Show("Pogrešno korisničko ime!");
            //}
        }
    }
}
