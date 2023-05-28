using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Tutankacuts
{
    public partial class Login : Form
    {

        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=Tutankacuts; integrated security=true");

        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            /*conexión con la base de datos A/*
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = "EQL-TOWER\\MSSQLSERVER01",
                    UserID = "sa",
                    Password = "sqladmin",
                    InitialCatalog = "Tutankacuts"
                };
                SqlConnection conexion = new SqlConnection(builder.ConnectionString);
                {
                    string sql = "select USR from Usuarios where PSWRD=123";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {

                        conexion.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("ConexionB "+reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("o no");
                Console.WriteLine(e.ToString());
            }*/

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        string Title = "";
        private void Continue_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txt_User.Text, psword = txt_Pswrd.Text;
                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(psword)) { throw new Exception(); }

                String sql = String.Format("select PSWRD,IDuser from Usuarios where USR='{0}'", user);
                SqlCommand cmd = new SqlCommand(sql, conexion);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (psword == reader.GetString(0))
                    {
                        MessageBox.Show("Bienvenido: " + user, "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        Home home = new Home();
                        home.Text = reader["IDuser"].ToString() + " - " + user;
                        home.Show();
                    }
                    else throw new Exception();

                }
                else MessageBox.Show("No se ha encontrado Registro del usuario", "Favor revise Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Favor revise Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); conexion.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
