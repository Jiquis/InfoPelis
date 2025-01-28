using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Topicos
{
    public partial class InfoMarioBros : Form
    {
        SqlConnection conexion = new SqlConnection("server = DESKTOP-0BLF9FN\\SQLEXPRESS; database=InfoPelis; integrated security=true");
        public InfoMarioBros(int ID)
        {
            InitializeComponent();
            LlenarDGV(ID);
            FormatoLabel();
        }
        private void FormatoLabel()
        {
            lblSinopsis.MaximumSize = new Size(groupBox1.Width - lblSinopsis.Left - 5, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Menu = new Form1();
            Menu.Show();
            this.Close();
        }
        public void LlenarDGV(int ID)
        {
            using (conexion)
            {
                string Consulta = "Select * from PeliculasAnimadas where ID = @ID";
                SqlCommand ComandoCMD = new SqlCommand(Consulta, conexion);
                ComandoCMD.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter Adaptador = new SqlDataAdapter(ComandoCMD);
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);

                // Obtener la sinopsis de la tabla
                string sinopsis = tabla.Rows[0]["sinopsis"].ToString();

                // Obtener el título de la tabla
                string titulo = tabla.Rows[0]["titulo"].ToString();

                // Asignar la sinopsis al label
                lblSinopsis.Text = sinopsis;

                // Asignar el título al label
                lblPelicula.Text = titulo;

                // Eliminar la columna de sinopsis de la tabla
                tabla.Columns.Remove("sinopsis");

                // Asignar la tabla modificada al DataGridView
                dgvInfo.DataSource = tabla;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
