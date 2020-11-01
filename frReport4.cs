using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangDienTu
{
    public partial class frReport4 : Form
    {
        public frReport4()
        {
            InitializeComponent();
        }

        private void frReport4_Load(object sender, EventArgs e)
        {
            cbbThang.Items.AddRange(
                string.Join(" ", Enumerable.Range(1, 12).ToList()).Split(' ')
                );


            int year = int.Parse(DateTime.Now.Year.ToString());


            var seq = string.Join(" ", Enumerable.Range(1952, year - 1952 + 1).ToList()).Split(' ');
            cbbNam.Items.AddRange(seq);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cbbThang.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn quý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbbNam.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DataSet ds = BLL_getData.NCCKhonggiaohang(cbbThang.SelectedItem.ToString(), cbbNam.SelectedItem.ToString());
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report4.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblempty.Visible = false;
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];

                /*parameter*/
                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("Thoigian", cbbThang.Text + " / " + cbbNam.Text));
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
    }
}
