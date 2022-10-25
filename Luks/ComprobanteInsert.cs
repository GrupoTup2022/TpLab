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
    public partial class ComprobanteInsert : Form
    {
        DateTime fecha;
        Pelicula peli;
        Audio audio;
        Horario horario;
        Sala sala;
        Funcion Funcion;
        int cant;
        List<Ticket> tickets;
        Ticket ticket;
        DataTable butacas;

        public ComprobanteInsert()
        {
            InitializeComponent();
            DeshabilitarTodo();     
            dtp_fecha.Value = DateTime.Now;
        }


        private void CargarComboPeli()
        {
            DataTable dt = new DataTable();
            dt = Consultas.consultarTabla(@"select distinct p.titulo_local,p.id_pelicula
                                                        from Funciones f
                                                        join Peliculas p on f.id_pelicula = p.id_pelicula
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") + "'");
            cbo_peli.DataSource = dt;
            cbo_peli.ValueMember = "id_pelicula";
            cbo_peli.DisplayMember = "titulo_local";
        }
        private void CargarComboIdioma()
        {
          
            cbo_audio.DataSource = Consultas.consultarTabla(@"select distinct f.id_audio,descripcion
                                                        from Funciones f
                                                        join Audios a on f.id_audio=a.id_audio
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") +
                                                        "' and f.id_pelicula = " + cbo_peli.SelectedValue);
            cbo_audio.ValueMember = "id_audio";
            cbo_audio.DisplayMember = "descripcion";
            
        }
        private void CargarComboHorario()
        {

                cbo_horario.DataSource = Consultas.consultarTabla(@"select distinct f.id_horario,horario
                                                        from Funciones f
                                                        join horarios h on f.id_horario=h.id_horario
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") +
                                                        "' and f.id_pelicula = " + cbo_peli.SelectedValue +
                                                        " and f.id_audio = " + cbo_audio.SelectedValue);
                cbo_horario.ValueMember = "id_horario";
                cbo_horario.DisplayMember = "horario";
            
        }
        private void CargarComboSala()
        {

                cbo_sala.DataSource = Consultas.consultarTabla(@"select f.id_sala,descripcion
                                                        from Funciones f
                                                        join Salas s on f.id_sala=s.id_sala
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") +
                                                        "' and f.id_pelicula = " + cbo_peli.SelectedValue +
                                                        " and f.id_audio = " + cbo_audio.SelectedValue +
                                                        " and f.id_horario = " + cbo_horario.SelectedValue);
                cbo_sala.ValueMember = "id_sala";
                cbo_sala.DisplayMember = "descripcion";
            
        }
        private void CargarDgvButacas()
        {
            DataTable tab = Consultas.consultarTabla(@"select id_funcion
                                                        from Funciones
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") +
                                                        "' and id_pelicula = " + cbo_peli.SelectedValue +
                                                        " and id_audio = " + cbo_audio.SelectedValue +
                                                        " and id_horario = " + cbo_horario.SelectedValue +
                                                        " and id_sala = " + cbo_sala.SelectedValue );
            Funcion = new Funcion();
            Funcion.Id = tab.Rows[0].Field<int>(0);
            butacas = Consultas.funcion(Funcion.Id.ToString());
            dgv_Butacas.Rows.Clear();
            int row = 0;

            for (int i = 0; i < dgv_Butacas.ColumnCount; i++)
            {
                dgv_Butacas.Columns[i].CellTemplate = new DataGridViewCheckBoxCell();
            }
            List<bool> ListaOcupada = new List<bool>();
            List <string > ListaNombre = new List<string>();
            for (int i = 0; i < butacas.Rows.Count; i = i + 5)
            {
                ListaOcupada.Clear();
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) < butacas.Rows.Count) {
                        ListaOcupada.Add(butacas.Rows[i + j][4].ToString() != "");
                    }
                }
                if (ListaOcupada.Count > 4)
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[0], ListaOcupada[1], ListaOcupada[2], ListaOcupada[3], ListaOcupada[4]);
                }
                else if (ListaOcupada.Count > 3)
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[0], ListaOcupada[1], ListaOcupada[2], ListaOcupada[3]);
                }
                else if (ListaOcupada.Count > 2)
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[0], ListaOcupada[1], ListaOcupada[2]);
                }
                else if (ListaOcupada.Count > 1)
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[0], ListaOcupada[1]);
                }
                else
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[0]);
                }
                row++;
            }
            Fijar_butacas();
        }
        private void DeshabilitarTodo()
        {
            cbo_peli.Enabled = false;
            cbo_audio.Enabled = false;
            cbo_horario.Enabled = false;
            cbo_sala.Enabled = false;
            n_cant.Enabled = false;
        }

        private int MaxButacas()
        {

            return 1;
        }

        private void Fijar_butacas()
        {
            for(int i=0;i<dgv_Butacas.Rows.Count;i++)
            {
                for (int j=0;j<dgv_Butacas.Rows[i].Cells.Count;j++)
                {
                    dgv_Butacas.Rows[i].Cells[j].ReadOnly = true;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea cancelar la venta?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            CargarComboPeli();
            DeshabilitarTodo();
            cbo_peli.SelectedIndex = -1;
            cbo_peli.Enabled = true;
            cbo_audio.SelectedIndex = -1;
            cbo_horario.SelectedIndex = -1;
            cbo_sala.SelectedIndex = -1;
        }

        private void cbo_peli_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_peli.Enabled)
            {
                CargarComboIdioma();
                DeshabilitarTodo();
                cbo_peli.Enabled = true;
                cbo_audio.SelectedIndex = -1;
                cbo_audio.Enabled = true;
                cbo_horario.SelectedIndex = -1;
                cbo_sala.SelectedIndex = -1;
            }
        }

        private void cbo_horario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_horario.Enabled)
            {
                CargarComboSala();
                cbo_sala.Enabled = true;
                cbo_sala.SelectedIndex = -1;
                n_cant.Enabled = false;

            }
        }

        private void cbo_audio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_audio.Enabled)
            {
                CargarComboHorario();
                DeshabilitarTodo();
                cbo_peli.Enabled = true;
                cbo_audio.Enabled = true;
                cbo_horario.SelectedIndex = -1;
                cbo_horario.Enabled = true;
                cbo_sala.SelectedIndex = -1;
            }
        }

        private void cbo_sala_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_sala.Enabled)
            {
                //n_cant.Maximum = Convert.ToDecimal(MaxButacas());
                n_cant.Enabled = true;
            }
        }

        private void n_cant_ValueChanged(object sender, EventArgs e)
        {
            CargarDgvButacas();
        }

        private void dgv_Butacas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Boolean)dgv_Butacas.SelectedCells[0].Value!=true)
            {
                dgv_Butacas.SelectedCells[0].Value = true;
                ticket.Butaca = new Butaca();
                ticket.Butaca.Id = Convert.ToInt32(butacas.Rows[dgv_Butacas.SelectedCells[0].RowIndex][dgv_Butacas.SelectedCells[0].ColumnIndex].ToString()); 
                
            }
        }
    }
}
