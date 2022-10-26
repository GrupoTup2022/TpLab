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
using System.Data.SqlClient;

namespace TpLab.Nicolas
{
    public partial class FormEstadistico : Form
    {
        public FormEstadistico()
        {
            InitializeComponent();
            loadDGVTotalSalaMes();
            loadDGVVentaSalaThisYear();
        }

        private void loadDGVVentaSalaThisYear()
        {
            DGVVentaSalaThisYear.DataSource = Consultas.monto_sala_mes();
        }

        private void loadDGVTotalSalaMes()
        {
           
            DGVTotalSalaMes.DataSource = Consultas.vendido_sala_thisyear();
        }

        private void DGVTotalSalaMes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEstadistico_Load(object sender, EventArgs e)
        {

        }
    }
}
