﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuntoVenta.Logica
{
    public class Conexion
    {
          public static string CN = ConfigurationManager.ConnectionStrings["conexion"].ToString();
       // public static string CN = "Data Source=localhost\\sqlexpress;Initial Catalog=DBPUNTO_VENTA;Integrated Security=True";
    }
}
