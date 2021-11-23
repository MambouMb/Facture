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

namespace Facture
{
    public partial class FrmPreview : Form
    {
        List<Facture> _list;

        public FrmPreview(List<Facture> dataSource)
        {
            InitializeComponent();
            _list = dataSource;
        }

        private void FrmPreview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Rpt_Facture.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _list));
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
