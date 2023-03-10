using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Presentacion;
using Sistema_de_Gestión.Modelos;
using CrystalDecisions.Windows.Forms;

namespace Sistema_de_Gestión.Presentacion
{
    
    public partial class frmVistaFactura : Form
    {
        FacturacionModel FM = new FacturacionModel();
        DSReportes ds = new DSReportes();
        public int idFactura { get; set; }
        public frmVistaFactura()
        {
            InitializeComponent();
        }

        private void frmVistaFactura_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            CRVFactura Reporte = new CRVFactura();
            DSReportesTableAdapters.SP_VerFacturaIDTableAdapter taFactura = new
                DSReportesTableAdapters.SP_VerFacturaIDTableAdapter();

            DSReportesTableAdapters.SP_VerDetalleFacturaTableAdapter taDetallesFactura = new
                DSReportesTableAdapters.SP_VerDetalleFacturaTableAdapter();

            DSReportesTableAdapters.SP_VerDetallesConducesTableAdapter taDetallesConduce = new
                DSReportesTableAdapters.SP_VerDetallesConducesTableAdapter();

            taFactura.Fill(ds.SP_VerFacturaID,this.idFactura);
            taDetallesFactura.Fill(ds.SP_VerDetalleFactura, this.idFactura);
            taDetallesConduce.Fill(ds.SP_VerDetallesConduces, this.idFactura);

            
            crvFactura1.SetDataSource(ds);
            crvFactura1.SetParameterValue("Pm-SP_VerDetallesConduces;1.id_Factura", this.idFactura);
            crystalReportViewer1.ReportSource = crvFactura1;

        }
    }
}
