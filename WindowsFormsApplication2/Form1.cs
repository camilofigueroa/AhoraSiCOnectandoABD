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

        }

        /**
         * Este es el método del botón. This is the button method.
         * Todo el código se ha colocado aquí para que se pueda controlar por el usuario.
         * All code is place hee because it can be controled by user.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            string datosConexion = "Data Source=localhost;Initial Catalog=bd_prueba_sqlserver;Integrated Security=true;";
            SqlConnection con = new SqlConnection(datosConexion);
            //con.ConnectionString = datosConexion;
            //con.Open();

            //En este punto, se convoca a los controles de texto. Ya ingresa datos.
            //In this point, the text boxes is put here. Now we can write data.
            SqlCommand command = new SqlCommand("INSERT INTO tb_usuarios ( documento, nobre ) VALUES( '" + this.textBox1.Text + "', '" + this.textBox2.Text + "' )", con);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
