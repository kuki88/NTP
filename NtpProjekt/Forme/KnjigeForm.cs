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
        KnjiznicaEntities obj = new KnjiznicaEntities();
        public KnjigeForm()
        {
            InitializeComponent();
            dKategorijaCombo.DataSource = obj.Kategorije.ToList();
            dKategorijaCombo.DisplayMember = "Kategorija";
        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            Knjige knjiga = new Knjige();
            if (obj.Knjige.Where(x => x.ISBN == dIsbnTxt.Text).FirstOrDefault() == null)
            {
                knjiga.ISBN = dIsbnTxt.Text;
                knjiga.Kategorija = dKategorijaCombo.Text;
                if (dKolicinaNumeric.Value > 0)
                {
                    knjiga.Količina = Convert.ToInt32(dKolicinaNumeric.Value.ToString());
                }
                knjiga.NazivKnjige = dNazivTxt.Text;
                knjiga.Autor = dAutorTxt.Text;
                obj.Knjige.Add(knjiga);
                obj.SaveChanges();
            }
            else MessageBox.Show("Već postoji knjiga s unešenim ISBN-om!");
        }

        private void ukloniBtn_Click(object sender, EventArgs e)
        {

            var trazeni = obj.Knjige.Where(x => x.ISBN == uIsbnTxt.Text).FirstOrDefault();
            if (trazeni != null)
            {
                try
                {
                    if (trazeni.Količina >= 0)
                    {
                        var kolicinaKnjiga = trazeni.Količina - Convert.ToInt32(uKolicinaNumeric.Value);
                        trazeni.Količina = kolicinaKnjiga;
                    }
                    else
                    {
                        MessageBox.Show("Nedovoljno knjiga za oduzimanje!");
                    }
                    obj.SaveChanges();
                }
                catch(Exception)
                {
                    MessageBox.Show("Ne postoji knjiga s traženim ISBN-om!");
                }
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
