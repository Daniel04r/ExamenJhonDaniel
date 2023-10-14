using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenJhonDaniel

{
    using System.CodeDom;
    using System.Data.SqlClient;
  

    public partial class Form1 : Form
    {

        Sqlconnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();


        public Form1()
        {
            InitializeComponent();
            conexion.ConnectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=examen;Integrated Security=True";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    comando.Connection = conexion;
                    comando.CommandText = "insert into alumno(id,nombre) values(@id,@nombre)";
                    conexion.Open();
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", txtId.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);

                    int NFilas = comando.ExecuteNonQuery();
                    if (NFilas > 0)
                    {
                        MessageBox.Show("Se logro exitosamente.");

                        txtId.Clear();
                        txtNombre.Clear();
                    }
                }

                catch (Exception ex)



                {
                    MessageBox.Show("FALLO LA CONSULTA: " + ex);

                }

                {
                    finally
                    conexion.Close();

                }
            }

            private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}