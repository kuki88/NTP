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
    public partial class UrediKnjigeForm : Form
    {
        KnjiznicaEntities entity;
        Knjige knjiga;
        public UrediKnjigeForm()
        {
            InitializeComponent();
        }

        public UrediKnjigeForm(Knjige _knjiga, KnjiznicaEntities _entity)
        {
            InitializeComponent();
            knjiga = _knjiga;
            entity = _entity;
            uIsbnTxt.Enabled = false;
            uAutorTxt.Text = knjiga.Autor;
            uNazivTxt.Text = knjiga.NazivKnjige;
            ukategorijaTxt.Text = knjiga.Kategorija;
            kolicinaNum.Value = knjiga.Količina;
        }

        private void UrediBtn_Click(object sender, EventArgs e)
        {
            var _knjiga = entity.Knjige.Where(x => x.ISBN == knjiga.ISBN).FirstOrDefault();
            if(_knjiga != null)
            {
                _knjiga.Kategorija = ukategorijaTxt.Text;
                _knjiga.NazivKnjige = uNazivTxt.Text;
                _knjiga.Količina = Convert.ToInt32(kolicinaNum.Value);
                _knjiga.Autor = uAutorTxt.Text;
                entity.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška!");
            }
        }

        private void ukloniBtn_Click(object sender, EventArgs e)
        {
            var potvrdaUklanjanja = MessageBox.Show("Jeste li sigurni da želite ukloniti knjigu iz knjižnice?", "Potvrda brisanja!", MessageBoxButtons.YesNoCancel);

            if(potvrdaUklanjanja == DialogResult.Yes)
            {
                try
                {
                    entity.Knjige.Remove(entity.Knjige.Where(x=>x.ISBN == knjiga.ISBN).FirstOrDefault());
                }
                catch (Exception)
                {
                    MessageBox.Show("Greška kod uklanjanja knjige!");
                }
                entity.SaveChanges();
                this.Close();
            }
        }
    }
}
