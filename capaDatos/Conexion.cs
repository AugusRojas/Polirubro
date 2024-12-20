﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POLIRUBRO
{
    public static class Conexion
    {
        static string conexion = "Server=AUGUSTO\\SQLEXPRESS; Database=sistema_de_ventas; integrated security=True";


        public static SqlConnection obtenerConexion()
        {
            SqlConnection conector = new SqlConnection(conexion);
            try
            {
                conector.Open();
                MessageBox.Show("Conexion Exitosa");
                return conector;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public static SqlConnection cerrarConexion()
        {
            SqlConnection conexion = Conexion.obtenerConexion();
            conexion.Close();
            return conexion;
        }
    }
}
