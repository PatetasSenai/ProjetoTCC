using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;


namespace WindowsFormsApplication1
{
    class Conexao
    {
        //private static string connStrings = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Makco\documents\visual studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\TCCFinal.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //C:\Users\Makco\documents\visual studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\TCCFinal.mdf
        //private static string connStrings = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TCCFinal.mdf;Integrated Security=True;Connect Timeout=30";

        private static string connStrings = @"Data Source=.\SQLEXPRESS;Database=TCCFinal;Integrated Security=True;";
        private static SqlConnection conn = null;
        
        public static SqlConnection obterConexao()
        {
            conn = new SqlConnection(connStrings);
            try
            {
                conn.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message);
                conn = null;

            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}