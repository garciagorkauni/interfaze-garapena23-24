using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutrinfoForm.Models;

namespace NutrinfoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Read the data form the database using the models
            using (var db = new NutrinfoDBContext())
            {
                List<Elikagaia> elikagaiaList = db.Elikagaia.ToList();

                // Insert the data into the data grid view
                dataGridView.DataSource = elikagaiaList;
            }
        }

        private void buttonInfoBistaratu_Click(object sender, EventArgs e)
        {
            // Validate info
            int numOfSelectedRows = dataGridView.SelectedRows.Count;
            if (numOfSelectedRows > 1)
            {
                // Show the error message box
                MessageBox.Show("Mesedez, elikagai bat aukeratu behar duzu, eta ez gehiago.");
            } else if(numOfSelectedRows == 0)
            {
                // Show the error message box
                MessageBox.Show("Mesedez, elikagai bat aukeratu behar duzu gutxienez.");
            } else
            {
                // Get the data of the chosen elikagaia
                int selectedElikagaiaId = dataGridView.SelectedRows[0].Index+1;

                // Get the required data
                using (var db = new NutrinfoDBContext())
                {
                    var results = db.Informazioa
                        .Include("Osagaia")
                        .Where(p => p.ElikagaiaId == selectedElikagaiaId)
                        .Select(result => new
                        {
                            OsagaiKantitatea = result.Kantitatea,
                            OsagaiIzena = result.osagaia.Izena
                        })
                        .ToList();

                        /*.Join(db.Osagaia,
                        informazioa => informazioa.OsagaiaId,
                        osagaia => osagaia.Id,
                        (informazioa, osagaia) => new { ElikagaiInformazioa = informazioa, ElikagaiOsagaia = osagaia }
                        )
                        .Where(p => p.ElikagaiInformazioa.ElikagaiaId == selectedElikagaiaId)
                        .Select(result => new
                        {
                            OsagaiKantitatea = result.ElikagaiInformazioa.Kantitatea,
                            OsagaiIzena = result.ElikagaiOsagaia.Izena
                        })
                        .ToList();*/


                    // Pass the required data to the dll
                    var kontrolak = nutrinfoDll.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>().FirstOrDefault();

                    if (kontrolak != null)
                    {
                        kontrolak.Series.Clear();
                        kontrolak.Series.Add("ElikagaiarenOsagaiak");
                        kontrolak.Series["ElikagaiarenOsagaiak"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                        foreach (var r in results)
                        {
                            kontrolak.Series["ElikagaiarenOsagaiak"].Points.AddXY(r.OsagaiIzena, r.OsagaiKantitatea);
                            kontrolak.Series["ElikagaiarenOsagaiak"].Points.Last().AxisLabel = r.OsagaiKantitatea.ToString();
                            kontrolak.Series["ElikagaiarenOsagaiak"].Points.Last().LegendText = r.OsagaiIzena;
                        }
                    }
                }
            }
        }
    }
}
