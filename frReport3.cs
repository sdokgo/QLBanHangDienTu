using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace QLBanHangDienTu
{
    public partial class frReport3 : Form
    {
        public frReport3()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cbbQuy.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn quý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbbNam.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DataSet ds = BLL_getData.Doanhthu(cbbQuy.SelectedItem.ToString(), cbbNam.SelectedItem.ToString());
          //  MessageBox.Show(cbbQuy.SelectedItem.ToString() + " " + cbbNam.SelectedItem.ToString());
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblempty.Visible = false;
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];

                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("Thoigian", "Quý " + cbbQuy.Text + " Năm " + cbbNam.Text));
                reportViewer1.LocalReport.SetParameters(parameters);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                this.reportViewer1.Reset();
                lblempty.Visible = true;
            }
        }

        private void frReport3_Load(object sender, EventArgs e)
        {
            cbbQuy.Items.AddRange(new string[] { "1", "2", "3", "4" });

            int year = int.Parse(DateTime.Now.Year.ToString());

            var seq = string.Join(" ", Enumerable.Range(1952, year - 1952 + 1).ToList()).Split(' ');

            cbbNam.Items.AddRange(seq);
        }
    }
}
