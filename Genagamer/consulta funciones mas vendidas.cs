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

namespace TpLab.Genagamer
{
    public partial class consulta_funciones_mas_vendidas : Form
    {
        public consulta_funciones_mas_vendidas()
        {
            InitializeComponent();
        }

        private void consulta_funciones_mas_vendidas_Load(object sender, EventArgs e)
        {
            CBgeneros.SelectedIndex = -1;
            CBgeneros.DropDownStyle = ComboBoxStyle.DropDownList;

            DTPmes.Format = DateTimePickerFormat.Custom;
            DTPmes.CustomFormat = "MM/yyyy";
            cargarGeneros();





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool ValidarDatos()
        {
            bool estado = true;
            if (CBgeneros.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un genero");
                estado = false;
            }
            return estado;
                

        }

        private void DTPmes_ValueChanged(object sender, EventArgs e)
        {

        }
        private void cargarGeneros()
        {
            CBgeneros.DataSource = Consultas.consultarTabla("generos");
        }
    }
}
