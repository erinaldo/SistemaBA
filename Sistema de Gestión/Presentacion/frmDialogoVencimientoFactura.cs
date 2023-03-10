using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Modelos;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmDialogoVencimientoFactura : Form
    {
        FacturacionModel FM = new FacturacionModel();

        public IFormularios NuevaFecha { get; set; }

        public frmDialogoVencimientoFactura()
        {
            InitializeComponent();
            ActualizarFechaProgramada();
        }


        private void frmDialogoVencimientoFactura_Load(object sender, EventArgs e)
        {

        }




        private void ActualizarFechaProgramada()
        {
            string NuevaFechaVencimiento = DateTime.Now.AddDays((double)UPdiasVencimiento.Value).ToShortDateString();
            lblFechaVencimiento.Text = NuevaFechaVencimiento;
        }

        private void UPdiasVencimiento_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFechaProgramada();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            NuevaFecha.NuevaFecha(lblFechaVencimiento.Text);
            this.Close();
        }

    }
}
