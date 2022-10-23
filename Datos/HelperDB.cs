﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TpLab.datos
{
    class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn;
        private string connection = @"d29ya3N0YXRpb24gaWQ9REJUcExhYi5tc3NxbC5zb21lZS5jb207cGFja2V0IHNpemU9NDA5Njt1c2VyIGlkPUx1Y2FzMjQ4NjVfU1FMTG9naW5fMTtwd2Q9Zzh6eWxkNHBkZDtkYXRhIHNvdXJjZT1EQlRwTGFiLm1zc3FsLnNvbWVlLmNvbTtwZXJzaXN0IHNlY3VyaXR5IGluZm89RmFsc2U7aW5pdGlhbCBjYXRhbG9nPURCVHBMYWI=";
        private HelperDB()
        {            
            cnn = new SqlConnection(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(connection)));
        }

        public static HelperDB ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }
        public DataTable ConsultaSQL(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public DataTable ConsultaSQLComando(string comm)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(comm, cnn);
            cmd.CommandType = CommandType.Text;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public int ConsultaEscalarSQL(string spNombre, string pOutNombre)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = pOutNombre;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)pOut.Value;
        }


        public int ConsultaEscalarSQLConParams(string spNombre, List<Parametro> values, string pOutNombre)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro param in values)
                {
                    cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                }
            }
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = pOutNombre;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)pOut.Value;
        }


        public int EjecutarSQL(string strSql, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }
    }
}