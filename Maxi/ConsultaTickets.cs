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
            DataTable dt = Consultas.consultarTabla("select t.nro_ticket 'TICKET', titulo_local 'PELICULA' , p.descripcion 'PROMO', t.[Precio] 'PRECIO'\r\n, nro_butaca 'BUTACA', id_comprobante 'COMPROBANTE', genero 'GENERO', s.descripcion 'SALA'\r\nfrom Ticket_Precio t join Funciones as f on f.id_funcion = t.id_funcion\r\njoin Peliculas as p on f.id_pelicula = p.id_pelicula\r\njoin Butacas as b on b.id_butaca = t.id_butaca\r\njoin Salas s on s.id_sala = b.id_sala\r\njoin Peliculas_Generos pg on p.id_pelicula = pg.id_pelicula\r\njoin Generos g on pg.id_genero = g.id_genero\r\n");
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
