using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PruebaConexionOracle {    
    class Program {
        //static string ConStr = "Data Source=glcweb.ddns.net;User Id=stjacks;Password=glcpass123456;";
        static string ConStr = "Data Source=186.190.248.108;User Id=stjacks;Password=glcpass123456;";
        static void Main(string[] args) {
            OracleConnection OraCon = new OracleConnection(ConStr);
            try {
                OraCon.Open();
                Console.WriteLine("Conexión realizada con exito a Oracle XE de GLC.");
                OraCon.Close();
            } catch (Exception e1) {
                Console.WriteLine(e1.ToString());
            }
            Console.ReadLine();
        }
    }
}
