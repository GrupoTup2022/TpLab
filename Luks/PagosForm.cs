using LibreriaTp;
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

namespace TpLab.Luks
{
    public partial class PagosForm : Form
    {
        public static List<Pagos> PagosList;
        public PagosForm()
        {
            InitializeComponent();
            CargarFormasVenta();
            cb_fp.SelectedIndex = 0;
        }
        public static List<Pagos> GetPagos()
        {
            return PagosList;
        }
        public static void SetPagos(List<Pagos> list)
        {
            PagosList = list;
        }

        private void CargarFormasVenta()
        {
            cb_fp.DataSource = Consultas.consultarTabla(@"select id_forma_pago,descripcion
                                                from formas_pago");
            cb_fp.ValueMember = "id_forma_pago";
            cb_fp.DisplayMember = "descripcion";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaPago fp = new FormaPago();
            fp.Id = Convert.ToInt32(cb_fp.SelectedValue);
            fp.Nombre = cb_fp.SelectedItem.ToString();
            Pagos pagos = new Pagos();
            pagos.FormaPago = fp;
            pagos.Monto = Convert.ToDecimal(tb_monto.Text);
            dgv_lista.Rows.Add(fp.Nombre, pagos.Monto);
            PagosList.Add(pagos);
        }

        private void btn_terminar_Click(object sender, EventArgs e)
        {
            ((ComprobanteInsert)Owner).PagosList = PagosList;
        }
    }
}
