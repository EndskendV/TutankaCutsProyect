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

namespace Tutankacuts
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }
        string USR = "";
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=Tutankacuts; integrated security=true");
        private void Empleados_Load(object sender, EventArgs e)
        {
            Activacion(0);
        }
        void Activacion(int id)
        {
            switch (id)
            {
                case 0:
                    
                    Grid_Empleado.Rows.Clear();
                    string check = this.Text.ToString().Substring(0, 1), code = "";
                    USR = this.Text.ToString().Substring(4);
                    if (check != string.Format("1"))
                    {
                        code = String.Format(" where USR='{0}' ", USR); MessageBox.Show("Solo Se mostrara tu usuario.");
                        bttn_Save.Visible = false;
                        bttn_Delete.Visible = false;
                        txt_User.Text = USR;
                        bttn_Seleccionar.Visible = false;
                    }
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT [USR]\r\n      ,[TipoUSR]\r\n      ,[IDuser]\r\n      ,[Nombre]\r\n      ,[Apellido]\r\n      ,[Sueldo]\r\n      ,[Horario]\r\n  FROM [dbo].[Usuarios] {0}", code), conexion);
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Empleado);
                        row.Cells[0].Value = dr[0].ToString();
                        row.Cells[1].Value = dr[1].ToString();
                        row.Cells[2].Value = dr[2].ToString();
                        row.Cells[3].Value = dr[3].ToString();
                        row.Cells[4].Value = dr[4].ToString();
                        row.Cells[5].Value = dr[5].ToString();
                        row.Cells[6].Value = dr[6].ToString();
                        Grid_Empleado.Rows.Add(row);

                    }
                    cmd.Dispose(); dr.Dispose();
                    conexion.Close();

                    bttn_Delete.Enabled = true;
                    break;
                case 1:
                    txt_Passwrd.Text = "";
                    txt_User.Text = "";
                    Activacion(0);
                    break; case 2:

                default:
                    break;
            }

        }
        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand sql = new SqlCommand(String.Format("UPDATE Usuarios set PSWRD='{0}' where USR='{1}'", txt_Passwrd.Text, txt_User.Text), conexion);
            sql.ExecuteNonQuery();
            MessageBox.Show("Contraseña Actualizada con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            conexion.Close();

        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {

            conexion.Open(); try
            {

                string user = txt_User.Text, psword = txt_Passwrd.Text;
                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(psword)) { throw new Exception(); }

                SqlCommand sql = new SqlCommand(String.Format("insert into Usuarios ([USR],[PSWRD],IDuser) values ('{0}','{1}',0)", txt_User.Text, txt_Passwrd.Text), conexion);
                sql.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Dato invalido", "Favor revise Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); conexion.Close();

            }
                conexion.Close();
            Activacion(1);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Estas Seguro de eliminar a " + txt_User.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    SqlCommand sql = new SqlCommand(String.Format("DELETE FROM [dbo].[Usuarios] WHERE USR='{0}'", txt_User.Text), conexion);
                    if (txt_User.Text.ToLower() == USR.ToLower())
                    {
                        throw new Exception();
                    }
                    conexion.Open();
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado el Trabajador.", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("No es posible eliminar, ya que no se puede eliminar el usuario en uso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                conexion.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada");
            }
            conexion.Close();
            Activacion(0);
        }

        private void bttn_Seleccionar_Click(object sender, EventArgs e)
        {
            txt_User.Text = Grid_Empleado.CurrentRow.Cells[0].Value.ToString();
            if (txt_User.Text == USR)
            {
                bttn_Delete.Enabled = false;
                MessageBox.Show("No es posible eliminar, su propio usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else Activacion(0);
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
