/**
 * Autor: Camilo Figueroa ( Crivera ) 
 * Esta es la clase creada por defecto en C# Vidual Studio 2013.
 * This is the class created by default on C# Vidual Studio 2013.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //15/09/2016, esto se agregó. This is added.


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string datosConexion = "Data Source=localhost;Initial Catalog=bd_prueba_sqlserver;Integrated Security=true;";
            SqlConnection con = new SqlConnection(datosConexion);
            //con.ConnectionString = datosConexion;
            //con.Open();

            SqlCommand command = new SqlCommand( "INSERT INTO tb_usuarios ( documento, nobre ) VALUES( '12', 'Camilo F' )", con);
            command.Connection.Open();
            command.ExecuteNonQuery();
            

        }
    }
}
