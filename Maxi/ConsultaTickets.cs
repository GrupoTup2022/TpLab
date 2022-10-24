using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLab.datos;

namespace TpLab.Maxi
{
    public partial class ConsultaTickets : Form
    {        
        public ConsultaTickets()
        {
            InitializeComponent();
        }

        private void ConsultaTickets_Load(object sender, EventArgs e)
        {
            CargarDGV();   
        }
        public void CargarDGV()
        {
            DataTable dt = Consultas.consultarTabla("select * from Ticket_Precio");
            dataGridView1.DataSource = dt;
        }
    }

}
