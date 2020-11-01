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
    public partial class frReport2 : Form
    {
        public frReport2()
        {
            InitializeComponent();
        }


        DataTable tbncc;

        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void fillComboBox(DataTable table, ComboBox cmb, string ma, string ten)
        {
            string newc = "NameAndCode";
            AddMultipleColumn(table, newc, ma, ten);
            cmb.DataSource = table;
            cmb.ValueMember = ma;
            cmb.DisplayMember = newc;
            cmb.SelectedIndex = 0;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cbbNCC.SelectedIndex == -1)
                return;
            DataSet ds = BLL_getData.HoadonVaTongtien(cbbNCC.SelectedValue.ToString());
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblempty.Visible = false;
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                
                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("MaNCC", cbbNCC.Text));

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

        private void cbbNCC_DropDown(object sender, EventArgs e)
        {
            tbncc = BLL_getData.getTable("pro_getAllNhacungcap");
            fillComboBox(tbncc, cbbNCC, "MaNCC", "TenNCC");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblempty_Click(object sender, EventArgs e)
        {

        }

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
