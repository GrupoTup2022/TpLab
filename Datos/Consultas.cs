using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.datos
{
    public class Consultas
    {

        public static DataTable Tickets_anio_pasado_accion()
        {
            string commando = @"--Mostrar la cantidad de Tikets que se vendieron el año pasado en el genero de
                                Accion
                                SELECT COUNT(nro_ticket) 'Cantidad de Entradas Vendidas'
                                FROM Tickets t join Funciones f on t.id_funcion = f.id_funcion
                                join Peliculas p on f.id_pelicula = p.id_pelicula
                                join Peliculas_Generos pg on pg.id_pelicula = p.id_pelicula
                                join Generos g on g.id_genero = pg.id_genero
                                WHERE nro_ticket in (SELECT nro_ticket
                                FROM Comprobantes c join tickets t1 on
                                c.id_comprobante = t1.id_comprobante
                                WHERE year(fecha) = year(GETDATE()) - 1) and
                                genero like 'Accion%'";
            return HelperDB.ObtenerInstancia().ConsultaSQLComando(commando);

        }

        public static DataTable top_funciones_mes_pasado()
        {
            string commando = @"--- TOP 5 de las funciones mas vendidas del mes pasado
                                SELECT TOP 5 count(nro_ticket)'Funciones Vendidas',f.id_funcion, f.id_pelicula
                                'Pelicula'
                                FROM Tickets t join Funciones f on t.id_funcion = f.id_funcion
                                join Peliculas p on f.id_pelicula = p.id_pelicula
                                WHERE f.id_funcion in (SELECT id_funcion
                                FROM Comprobantes c join Tickets t1 on
                                c.id_comprobante = t1.id_comprobante
                                WHERE datediff(month, fecha, GETDATE())=1)
                                GROUP BY f.id_funcion, f.id_pelicula
                                ORDER BY 1 desc";
            return HelperDB.ObtenerInstancia().ConsultaSQLComando(commando);
        }
        public static DataTable monto_anual()
        {
            string commando = @"--Monto total facturado Anualmente
                                select sum(f.precio* p.porcentaje/100),year(fecha)
                                from tickets t
                                join Comprobantes c on c.id_comprobante=t.id_comprobante
                                join promos p on p.id_promo = t.id_promo
                                join funciones f on f.id_funcion = t.id_funcion
                                group by year(fecha)";
            return HelperDB.ObtenerInstancia().ConsultaSQLComando(commando);
        }
        public static DataTable monto_sala_mes()
        {
            string commando = @"---monto total facturado por sala y por mes
                                select sum(f.precio* p.porcentaje/100) 'Monto total facturado por
                                sala',s.id_sala,month(fecha) 'Mes',year(fecha)'Año'
                                from tickets t
                                join Comprobantes c on c.id_comprobante=t.id_comprobante
                                    join promos p on p.id_promo = t.id_promo
                                join funciones f on f.id_funcion = t.id_funcion
                                join Salas s on s.id_sala = f.id_sala
                                group by s.id_sala, month(fecha), year(fecha)";
           return HelperDB.ObtenerInstancia().ConsultaSQLComando(commando);
        }
        public static int insertar_ticket(string id_funcion, string id_butaca, string id_comprobante, string id_promo)
        {
            /* string commando = @"--PROCEDIMIENTO ALMACENADO para ingresar tickets
                                 CREATE PROC SP_INSERTAR_TICKETS
                                 @id_funcion int,
                                 @id_butaca int,
                                 @id_comprobante int,
                                 @id_promo int,
                                 @nro_ticket int output
                                 AS
                                 BEGIN
                                 INSERT INTO Tickets (id_funcion, id_butaca, id_comprobante, id_promo)
                                 values (@id_funcion, @id_butaca, @id_comprobante, @id_promo)
                                 SET @nro_ticket = SCOPE_IDENTITY();
                                 END";*/
            string commando = "SP_INSERTAR_TICKETS";
            List<Parametro> param = new List<Parametro>();
            param.Add(new Parametro("@id_funcion", id_funcion));
            param.Add(new Parametro("@id_butaca", id_butaca));
            param.Add(new Parametro("@id_comprobante", id_comprobante));
            param.Add(new Parametro("@id_promo", id_promo));
            return HelperDB.ObtenerInstancia().ConsultaEscalarSQLConParams(commando, param, "@nro_ticket");
        }
        //arreglar
        public static DataTable funcion(string id_funcion)
        {
            /*string commando = @"--PROCEDIMIENTO ALMACENADO para consultar la funcion
                                create proc sp_CONSULTAR_FUNCION
                                @id_funcion int
                                AS
                                BEGIN
                                select b.id_butaca,b.nro_butaca, b.id_sala,f.id_funcion,t.nro_ticket,t.id_butaca
                                from Butacas b
                                join Funciones f on f.id_sala=b.id_sala
                                left join tickets t on b.id_butaca=t.id_butaca
                                where f.id_funcion=@id_funcion
                                END";*/
            string commando = "sp_CONSULTAR_FUNCION";
            List<Parametro> param = new List<Parametro>();
            param.Add(new Parametro("@id_funcion", id_funcion));
            return HelperDB.ObtenerInstancia().ConsultaSQL(commando,param);
        }
        /*public static DataTable vista_ticket()
        {
            string commando = @"--vista del ticket y su precio final
                                create view Ticket_Precio as
                                select t.nro_ticket, t.id_funcion, t.id_butaca, t.id_comprobante, t.id_promo,
                                f.precio* p.porcentaje/100 'Precio'
                                from tickets t
                                join Promos p on t.id_promo= p.id_promo
                                join Funciones f on t.id_funcion= f.id_funcion;";
           return HelperDB.ObtenerInstancia().ConsultaSQLComando(commando);

        }
        public static DataTable vista_comprobante()
        {
            string commando = @"--vista del comprobante y su precio final
                                create view Comprobante_Precio as
                                select c.id_comprobante, c.fecha, c.id_forma_venta, sum(f.precio* p.porcentaje/100)
                                'Precio'
                                from tickets t
                                join Comprobantes c on t.id_comprobante=c.id_comprobante
                                join Promos p on t.id_promo= p.id_promo
                                join Funciones f on t.id_funcion= f.id_funcion
                                group by c.id_comprobante, c.fecha, c.id_forma_venta";
            return HelperDB.ObtenerInstancia().ConsultaSQLComando(commando);
        }*/
        public static DataTable consultarTabla(string commando)
        {
            return HelperDB.ObtenerInstancia().ConsultaSQLComando(commando);
        }












    }
}
