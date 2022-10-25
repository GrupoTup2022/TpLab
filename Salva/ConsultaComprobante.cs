﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLab.datos;

namespace TpLab.Salva
{
    public partial class ConsultaComprobante : Form
    {

        string query; 

        public ConsultaComprobante()
        {
            InitializeComponent();
            query = string.Empty;
        }

        private void ConsultaComprobante_Load(object sender, EventArgs e)
        {
            Inicializar();            
        }

        private void CargarLista()
        {
            
            DataTable dtG = Consultas.consultarTabla(query);
            dgvComprobante.DataSource = dtG;

        }

        #region MetodosPropios

        private void CargarCombo()
        {
            DataTable dt = Consultas.consultarTabla("select * from Formas_venta");
            cbFormaVenta.DataSource = dt;
            cbFormaVenta.DisplayMember = dt.Columns[1].ColumnName;
            cbFormaVenta.ValueMember = dt.Columns[0].ColumnName;

        }

        private void Inicializar()
        {
            SetQuery();
            CargarCombo();
            CargarLista();
            for (int i = 0; i < dgvComprobante.Columns.Count; i++)
            {
                dgvComprobante.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void Filtrar()
        {
                query = "select c.id_comprobante 'Comprobante Num.',c.fecha 'Fecha',c.id_forma_venta 'Forma Venta',sum(f.precio*p.porcentaje/100) 'Precio' " +
                                "from tickets t join Comprobantes c on t.id_comprobante = c.id_comprobante " +
                                "join Promos p on t.id_promo=p.id_promo " +
                                "join Funciones f on t.id_funcion = f.id_funcion " +
                                "WHERE c.fecha between '" + dtpDesde.Value.ToString("yyyy/MM/dd") + "' and '" + dtpHasta.Value.ToString("yyyy/MM/dd") + "' "+
                                "and c.id_forma_venta = " + cbFormaVenta.SelectedValue.ToString()+
                                "group by c.id_comprobante,c.fecha,c.id_forma_venta";

            MessageBox.Show(query.ToString());
            CargarLista();
        }

        private void SetQuery()
        {
            query = "select c.id_comprobante 'Comprobante Num.',c.fecha 'Fecha',c.id_forma_venta 'Forma Venta',sum(f.precio*p.porcentaje/100) 'Precio' " +
                                "from tickets t join Comprobantes c on t.id_comprobante = c.id_comprobante " +
                                "join Promos p on t.id_promo=p.id_promo " +
                                "join Funciones f on t.id_funcion = f.id_funcion group by c.id_comprobante,c.fecha,c.id_forma_venta";
        }

        #endregion




        #region botones

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
            SetQuery();
        }

        #endregion

        private void dgvComprobante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
