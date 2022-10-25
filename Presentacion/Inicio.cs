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
using TpLab.Genagamer;
using TpLab.Nicolas;

namespace TpLab.Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TpLab.Luks.ComprobanteInsert nuevoComprobante = new TpLab.Luks.ComprobanteInsert();
            nuevoComprobante.Show();
        }

        private void consultaGenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TpLab.Genagamer.consulta_funciones_mas_vendidas ConsultaFuncion = new consulta_funciones_mas_vendidas();
            ConsultaFuncion.Show();
        }

<<<<<<< HEAD
        private void datosEstadisticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEstadistico().ShowDialog();
=======
        private void consultaMaxiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TpLab.Maxi.ConsultaTickets consulta = new Maxi.ConsultaTickets();
            consulta.Show();
>>>>>>> 16f9bb249a12b4e289b48bca6920f5f7070925c8
        }
    }
}
