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
    public partial class PosudbaForm : Form
    {
        KnjiznicaEntities obj = new KnjiznicaEntities();

        public PosudbaForm()
        {
            InitializeComponent();
            kkategorijaCombo.DataSource = obj.Kategorije.ToList();
            kkategorijaCombo.DisplayMember = "Kategorija";
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var isbn = knjigeGrid.Rows[e.RowIndex].Cells[0].Value;
            var naziv = knjigeGrid.Rows[e.RowIndex].Cells[1].Value;
            var autor = knjigeGrid.Rows[e.RowIndex].Cells[2].Value;
            var kategorija = knjigeGrid.Rows[e.RowIndex].Cells[3].Value;
            var kolicina = knjigeGrid.Rows[e.RowIndex].Cells[4].Value;

            bkategorijaCombo.Text = kategorija.ToString();
            isbnTxt.Text = ISBN.ToString();
            pnazivTxt.Text = naziv.ToString();
            pAutorTxt.Text = autor.ToString();
            kolicinaTxt.Text = kolicina.ToString();

        }

        private void pretragaBtn_Click(object sender, EventArgs e)
        {
            knjigeGrid.AutoGenerateColumns = false;
            var knjige = obj.Knjige.Where(x => x.NazivKnjige == knazivTxt.Text || x.Kategorija == kkategorijaCombo.Text).ToList();
            knjigeGrid.DataSource = knjige;
        }

        private void posudbaBtn_Click(object sender, EventArgs e)
        {
            var objKnjiga = obj.Knjige.Where(x => x.ISBN == isbnTxt.Text).FirstOrDefault();
            if (objKnjiga != null)
            {

            }
        }
    }
}
