using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using FastReport;
using FastReport.Export.Image;
using FastReport.Utils;
using FastReport.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace NtpProjekt
{
    public partial class PosudbaForm : Form
    {
        
        //
        //void funkcije
        //

        private void zakljucajClana()
        {
            dvoClanskiTxt.Enabled = false;
            dClanskiTxt.Enabled = false;
            cImeTxt.Enabled = false;
            cPrezimeTxt.Enabled = false;
            cTelTxt.Enabled = false;
        }
        private void zakljucajKnjigu()
        {
            dClanskiTxt.Enabled = false;
            isbnTxt.Enabled = false;
            pnazivTxt.Enabled = false;
            pAutorTxt.Enabled = false;
            kolicinaTxt.Enabled = false;
            bkategorijaCombo.Enabled = false;
        }
        private void otkljucajOcistiClana()
        {
            dvoClanskiTxt.Enabled = true;
            dClanskiTxt.Enabled = true;
            cImeTxt.Enabled = true;
            cPrezimeTxt.Enabled = true;
            cTelTxt.Enabled = true;
            dvoClanskiTxt.Text = null;
            cImeTxt.Text = null;
            cPrezimeTxt.Text = null;
            cTelTxt.Text = null;
            dClanskiTxt.Text = null;
        }
        private void otkljucajKnjigu()
        {
            dClanskiTxt.Enabled = true;
            isbnTxt.Enabled = true;
            pnazivTxt.Enabled = true;
            pAutorTxt.Enabled = true;
            kolicinaTxt.Enabled = true;
            bkategorijaCombo.Enabled = true;
        }
        private void ocistiKnjiguForm()
        {
            dClanskiTxt.Text = null;
            isbnTxt.Text = null;
            pnazivTxt.Text = null;
            pAutorTxt.Text = null;
            kolicinaTxt.Text = null;
            bkategorijaCombo.Text = null;
        }

        //Definicija atributa

        bool prviUvjet = false;
        bool drugiUvjet = false;

        Posudbe posudba;
        KnjiznicaEntities obj = new KnjiznicaEntities();
        Clanovi trazeniClan;
        //XmlSerializer xmlSer;





        //Inicijalizacija

        public PosudbaForm()
        {
            InitializeComponent();
            kkategorijaCombo.DataSource = obj.Kategorije.ToList();
            kkategorijaCombo.DisplayMember = "Kategorija";
            posudbeReportBtn.Enabled = false;
            posudbaBtn.Enabled = false;
            zakljucajKnjigu();
            //FastReport.Utils.RegisteredObjects.AddConnection(typeof(MySqlDataConnection));
        }


        //
        //Click akcije
        //

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var isbn = knjigeGrid.Rows[e.RowIndex].Cells[0].Value;
            var naziv = knjigeGrid.Rows[e.RowIndex].Cells[1].Value;
            var autor = knjigeGrid.Rows[e.RowIndex].Cells[2].Value;
            var kategorija = knjigeGrid.Rows[e.RowIndex].Cells[3].Value;
            var kolicina = knjigeGrid.Rows[e.RowIndex].Cells[4].Value;

            bkategorijaCombo.Text = kategorija.ToString();
            isbnTxt.Text = isbn.ToString();
            pnazivTxt.Text = naziv.ToString();
            pAutorTxt.Text = autor.ToString();
            kolicinaTxt.Text = kolicina.ToString();

            if (int.Parse(kolicinaTxt.Text) == 0 || kolicinaTxt.Text == null)
            {
                kolicinaTxt.BackColor = Color.Red; 
                posudbaBtn.Enabled = false;
            }

        }

        private void pretragaBtn_Click(object sender, EventArgs e)
        {
            knjigeGrid.AutoGenerateColumns = false;
            var knjige = obj.Knjige.Where(x => x.NazivKnjige == knazivTxt.Text || x.Kategorija == kkategorijaCombo.Text).ToList();
            knjigeGrid.DataSource = knjige;
        }

        public void PokreniReportPosudba(Posudbe posudba, Clanovi clan, Knjige knjiga)
        {
            Report rpt = new Report();
        }
        private void posudbaBtn_Click(object sender, EventArgs e)
        {
            var objKnjiga = obj.Knjige.Where(x => x.ISBN == isbnTxt.Text).FirstOrDefault();
            if (objKnjiga != null)
            {
                var objClan = obj.Clanovi.Where(x => x.clanskiBroj == dvoClanskiTxt.Text + "/" + dClanskiTxt.Text).FirstOrDefault();
                if (objClan != null)
                {
                    try
                    {
                        posudba = new Posudbe();
                        posudba.clanskiBroj = objClan.clanskiBroj;
                        posudba.isbnKnjige = objKnjiga.ISBN;
                        posudba.datumPosudbe = DateTime.Now;
                        posudba.datumPovratka = DateTime.Now.AddDays(14);
                        obj.Posudbe.Add(posudba);

                        objKnjiga.Količina -= 1;
                        obj.SaveChanges();

                        MessageBox.Show("Korisnik " + objClan.ime + " " + objClan.prezime + " je posudio njigu ISBN: " + objKnjiga.ISBN);
                        otkljucajOcistiClana();
                        ocistiKnjiguForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška kod posudbe!", ex.Message);
                    }
                }
            }
        }

        private void dvoClanskiTxt_TextChanged(object sender, EventArgs e)
        {
            if (dvoClanskiTxt.Text.Length < 2)
            {
                dClanskiTxt.Enabled = false;
            }
            else if (dvoClanskiTxt.Text.Length == 2)
            {
                dClanskiTxt.Enabled = true;
                dClanskiTxt.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trazeniClan = obj.Clanovi.Where(x => x.clanskiBroj == dvoClanskiTxt.Text + "/" + dClanskiTxt.Text).FirstOrDefault();
            if (trazeniClan != null)
            {
                cImeTxt.Text = trazeniClan.ime;
                cPrezimeTxt.Text = trazeniClan.prezime;
                cTelTxt.Text = trazeniClan.telefonskiBroj;
                zakljucajClana();
                drugiUvjet = true;
                posudbeReportBtn.Enabled = true;
            }
            else
            {
                drugiUvjet = false;
            }

            if (prviUvjet && drugiUvjet)
            {
                posudbaBtn.Enabled = true;
            }

        }

        private void isbnTxt_TextChanged(object sender, EventArgs e)
        {
            if (isbnTxt.Text.Length > 0)
            {
                prviUvjet = true;
            }
            else prviUvjet = false;

            if (prviUvjet && drugiUvjet)
            {
                posudbaBtn.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            otkljucajOcistiClana();
            drugiUvjet = false;
            posudbaBtn.Enabled = false;
        }

        private void posudbeReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //FileStream fs = new FileStream(Application.StartupPath.Remove(Application.StartupPath.Length - 10) + "\\Posudba.xml", FileMode.Create, FileAccess.Write);
                //xmlSer.Serialize(fs, posudba);

                //fs.Close();

                //DataSet data = new DataSet();
                //data.ReadXml($"{Application.StartupPath}/nwind.xml"); //Load XML to it
                //MySqlDataConnection conn = new MySqlDataConnection();
                //conn.ConnectionString = "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=KUKICRO\\SQLEXPRESS;initial catalog=KnjiznicaManagement;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;' providerName = 'System.Data.EntityClient";
                //conn.CreateAllTables();
                //FastReport.Report rpt = new FastReport.Report();
                //Report report = new Report();
                //report.Dictionary.Connections.Add(conn);
                //report.Load($"{Application.StartupPath.Remove(Application.StartupPath.Length - 10)}\\PosudbaReport.frx");
                //report.SetParameterValue("posudbaID", trazeniClan.clanskiBroj);
                //report.Prepare(); //Prepare a report
                //System.Diagnostics.Process.Start(@"c:\myPdf.pdf");

                using (var export = new FastReport.Export.PdfSimple.PDFSimpleExport())
                {
                    //export.Export(report, "Izvjestaj.pdf");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pogreška kod pokazivanja izvještaja. ", ex.Message);
            }
        }
    }
}
