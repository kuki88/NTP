using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NtpProjekt.Services;
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
    public partial class KnjigeForm : Form
    {
        Knjige trazeni;
        KnjiznicaEntities obj = new KnjiznicaEntities();
        public KnjigeForm()
        {
            InitializeComponent();
            dKategorijaCombo.DataSource = obj.Kategorije.ToList();
            dKategorijaCombo.DisplayMember = "Kategorija";
            UrediBtn.Enabled = false;
        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            Knjige knjiga = new Knjige();
            if (obj.Knjige.Where(x => x.ISBN == dIsbnTxt.Text).FirstOrDefault() == null)
            {
                if (dIsbnTxt.Text != string.Empty && dKategorijaCombo.Text != string.Empty && dKolicinaNumeric.Text != string.Empty && dNazivTxt.Text != string.Empty && dAutorTxt.Text != string.Empty)
                {
                    knjiga.ISBN = dIsbnTxt.Text;
                    knjiga.Kategorija = dKategorijaCombo.Text;
                    if (dKolicinaNumeric.Value > 0)
                    {
                        knjiga.Količina = Convert.ToInt32(dKolicinaNumeric.Value.ToString());
                    }
                    knjiga.NazivKnjige = dNazivTxt.Text;
                    knjiga.Autor = dAutorTxt.Text;
                    
                    HttpService.DodajKnjigu(JsonConvert.SerializeObject(knjiga));
                }
            }
            else MessageBox.Show("Već postoji knjiga s unešenim ISBN-om!");
        }

        private void ukloniBtn_Click(object sender, EventArgs e)
        {
            trazeni = obj.Knjige.Where(x => x.ISBN == uIsbnTxt.Text).FirstOrDefault();
            if (trazeni != null)
            {
                UrediKnjigeForm forma = new UrediKnjigeForm(trazeni, obj);
                forma.Show();
            }

        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            var trazeni = obj.Knjige.Where(x => x.ISBN == uIsbnTxt.Text).FirstOrDefault();
            if(trazeni != null)
            {
                ukategorijaTxt.Text = trazeni.Kategorija;
                uNazivTxt.Text = trazeni.NazivKnjige;
                uDostupnaTxt.Text = trazeni.Količina.ToString();
                uAutorTxt.Text = trazeni.Autor;
                ukategorijaTxt.ReadOnly = true;
                uNazivTxt.ReadOnly = true;
                uDostupnaTxt.ReadOnly = true;
                uAutorTxt.ReadOnly = true;
                UrediBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ne postoji knjiga s traženim ISBN-om!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KnjigeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
