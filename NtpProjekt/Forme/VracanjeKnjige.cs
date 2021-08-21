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
    public partial class VracanjeKnjige : Form
    {

        KnjiznicaEntities entity = new KnjiznicaEntities();
        Posudbe posudba = new Posudbe();

        public VracanjeKnjige()
        {
            InitializeComponent();
            produziBtn.Enabled = false;
            vratiBtn.Enabled = false;
        }


        private void provjeraBtn_Click(object sender, EventArgs e)
        {
            posudba = entity.Posudbe.Where(x => x.Id.ToString() == idPosudbeTxt.Text).FirstOrDefault();
            if(posudba != null)
            {
                isbnTxt.Text = posudba.isbnKnjige;
                clanskiTxt.Text = posudba.clanskiBroj;
                posudbaPicker.Value = Convert.ToDateTime(posudba.datumPosudbe);
                povratakPicker.Value = Convert.ToDateTime(posudba.datumPovratka);
                int dani = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(posudba.datumPovratka)).TotalDays);
                isbnTxt.Enabled = false;
                clanskiTxt.Enabled = false;
                povratakPicker.Enabled = false;
                posudbaPicker.Enabled = false;
                idPosudbeTxt.Enabled = false;
                produziBtn.Enabled = true;
                vratiBtn.Enabled = true;
                idPosudbeTxt.Enabled = true;

                if (dani > 0)
                {
                    double iznos = dani * 0.50;
                    iznosTxt.Text = iznos.ToString();
                }
            }
            else
            {
                idPosudbeTxt.Text = null;
                isbnTxt.Text = null;
                clanskiTxt.Text = null;
                iznosTxt.Text = null;
                posudbaPicker.Value = DateTime.Now;
                povratakPicker.Value = DateTime.Now;

                isbnTxt.Enabled = true;
                clanskiTxt.Enabled = true;
                povratakPicker.Enabled = true;
                posudbaPicker.Enabled = true;
                vratiBtn.Enabled = false;
                produziBtn.Enabled = false;
            }
        }

        private void ponistiBtn_Click(object sender, EventArgs e)
        {
            idPosudbeTxt.Text = null;
            isbnTxt.Text = null;
            clanskiTxt.Text = null;
            iznosTxt.Text = null;
            posudbaPicker.Value = DateTime.Now;
            povratakPicker.Value = DateTime.Now;

            isbnTxt.Enabled = true;
            clanskiTxt.Enabled = true;
            povratakPicker.Enabled = true;
            posudbaPicker.Enabled = true;
            vratiBtn.Enabled = false;
            produziBtn.Enabled = false;
        }

        private void produziBtn_Click(object sender, EventArgs e)
        {
            var potvrda = MessageBox.Show("Želite li produžiti knjigu u trajanju od 7 dana?", "Produženje", MessageBoxButtons.YesNoCancel);
            if (potvrda == DialogResult.Yes)
            {
                posudba.datumPovratka = Convert.ToDateTime(posudba.datumPovratka).AddDays(7);
                entity.SaveChanges();
            }
        }
        private void vratiBtn_Click(object sender, EventArgs e)
        {
            var potvrda = MessageBox.Show("Želite li vratiti knjigu?", "Posudba", MessageBoxButtons.YesNoCancel);
            if(potvrda == DialogResult.Yes)
            {
                entity.Knjige.Where(x => x.ISBN == posudba.isbnKnjige).FirstOrDefault().Količina += 1;
                entity.Posudbe.Remove(posudba);
                entity.SaveChanges();
            }
        }

    }
}
