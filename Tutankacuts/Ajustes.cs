using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }
        string USR = "";
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=Tutankacuts; integrated security=true");
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

                        bttn_Delete.Visible = false;
                        txt_User.Text = USR;
                        bttn_Seleccionar.Visible = false;
                    }
                    bttn_Save.Visible = false;
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
                    txt_Apellido.Text = "";
                    txt_Name.Text = "";
                    txt_Sueldo.Text = "";
                    txt_User.Text = "";
                    Combo_Horario.Text = "";
                    Combo_Puesto.Text = "";
                    Activacion(0);
                    break;
                case 2:
                    txt_Apellido.Text = "";
                    txt_Name.Text = "";
                    txt_Sueldo.Text = "";
                    Combo_Horario.Text = "";
                    Combo_Puesto.Text = "";
                    break;
                case 10:

                    if (txt_User.Text.ToLower() == USR.ToLower())
                    {
                        bttn_Delete.Enabled = false;
                        MessageBox.Show("No es posible eliminar, su propio usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else Activacion(0);
                    conexion.Open();
                    try
                    {
                        Activacion(2);
                        SqlCommand sql = new SqlCommand(String.Format("SELECT [Nombre],[Apellido],[TipoUSR] ,[Sueldo],[Horario]\r\n  FROM [dbo].[Usuarios] where USR='{0}'", txt_User.Text), conexion);
                        SqlDataReader sqlDataReader = sql.ExecuteReader();
                        Thread.Sleep(10);
                        while (sqlDataReader.Read())
                        {
                            txt_Name.Text = sqlDataReader.GetString(0);
                            txt_Apellido.Text = sqlDataReader.GetString(1);
                            Combo_Puesto.Text = sqlDataReader.GetString(2);
                            Combo_Horario.Text = sqlDataReader.GetString(4);
                            txt_Sueldo.Text = sqlDataReader.GetSqlMoney(3).ToString();
                        }

                    }
                    catch (Exception)
                    {

                    }
                    conexion.Close();

                    break;
                case 11:
                default:
                    break;
            }

        }

        private void Ajustes_Load(object sender, EventArgs e)
        {
            Activacion(0);
        }

        private void bttn_Seleccionar_Click(object sender, EventArgs e)
        {
            txt_User.Text = Grid_Empleado.CurrentRow.Cells[0].Value.ToString(); Thread.Sleep(10);
            Activacion(10);

        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Estas Seguro de eliminar a " + txt_User.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                conexion.Open();
                try
                {
                    SqlCommand sql = new SqlCommand(String.Format("DELETE FROM [dbo].[Usuarios] WHERE USR='{0}'", txt_User.Text), conexion);
                    if (txt_User.Text.ToLower() == USR.ToLower())
                    {
                        throw new Exception();
                    };
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
            Activacion(0);
        }

        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            int IDPUESTO = 0;
            string user = txt_User.Text, Name = txt_Name.Text, AP = txt_Apellido.Text, Puesto = Combo_Puesto.Text,
                Sueldo = txt_Sueldo.Text, Horario = Combo_Horario.Text;
            switch (Puesto)
            {
                case "Asistente":
                    IDPUESTO = 2;
                    break;
                case "Ayudante general":
                    IDPUESTO = 3;
                    break;
                case "Barbero":
                    IDPUESTO = 4;
                    break;
                case "Limpieza":
                    IDPUESTO = 5;
                    break;
                case "Recepcionista":
                    IDPUESTO = 6;
                    break;
                case "Admin":
                    IDPUESTO = 1;
                    break;
                default:
                    break;
            }


            conexion.Open();
            SqlCommand sql = new SqlCommand(String.Format("UPDATE [dbo].[Usuarios] " +
                "SET [TipoUSR] = '{3}'\r\n      ,[IDuser] = '{4}'\r\n      ,[Nombre] = '{1}' " +
                ",[Apellido] = '{2}'\r\n      ,[Sueldo] = '{5}'\r\n      ,[Horario] = '{6}'\r\n " +
                "WHERE [USR] = '{0}'", user, Name, AP, Puesto, IDPUESTO, Sueldo, Horario), conexion);

            try
            {
                sql.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            conexion.Close();
            Activacion(1);
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            //Desabilitado--> Hara lo mismo que Modificar
        }

        private void txt_Sueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Combo_Horario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
