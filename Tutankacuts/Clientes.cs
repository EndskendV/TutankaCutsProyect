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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string USR = "",code="";
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=Tutankacuts; integrated security=true");
        private void Clientes_Load(object sender, EventArgs e)
        {
            Activacion(0);
        }

        void Activacion(int id)
        {
            switch (id)
            {
                case 0:

                    grid_Cliente.Rows.Clear();
                    string check = this.Text.ToString().Substring(0, 1),
                    USR = this.Text.ToString().Substring(4);
                    if (check != string.Format("1"))
                    {
                        MessageBox.Show("No puedes eliminar clientes");

                        bttn_Delete.Visible = false;
                    }
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT [NameC],[APC]  ,[Tel]   ,[Mail]  ,[FNAC] FROM [dbo].[Client] {0}",code), conexion);
                    conexion.Close();code = "";
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(grid_Cliente);
                        row.Cells[0].Value = dr[0].ToString();
                        row.Cells[1].Value = dr[1].ToString();
                        row.Cells[2].Value = dr[2].ToString();
                        row.Cells[3].Value = dr[3].ToString();
                        row.Cells[4].Value = dr[4].ToString();
                        grid_Cliente.Rows.Add(row);

                    }
                    cmd.Dispose(); dr.Dispose();
                    conexion.Close();

                    bttn_Delete.Enabled = true;
                    bttn_Save.Enabled = true;
                    break;
                case 1:
                    txt_Apellido.Text = "";
                    txt_Mail.Text = "";
                    txt_Name.Text = "";
                    txt_Tel.Text = "";
                    txt_Calendario.SelectionStart = DateTime.Now;
                    Activacion(0);
                    break;
                case 2:

                default:
                    break;
            }

        }
        private void bttn_Seleccionar_Click(object sender, EventArgs e)
        {
            string fecha = ""; DateTime dateTime=DateTime.Now;
            try
            {
                 fecha= grid_Cliente.CurrentRow.Cells[4].Value.ToString();
                dateTime= Convert.ToDateTime(fecha);
                txt_Name.Text = grid_Cliente.CurrentRow.Cells[0].Value.ToString();
                txt_Apellido.Text = grid_Cliente.CurrentRow.Cells[1].Value.ToString();
                txt_Tel.Text = grid_Cliente.CurrentRow.Cells[2].Value.ToString();
                txt_Mail.Text = grid_Cliente.CurrentRow.Cells[3].Value.ToString();
                txt_Calendario.SelectionStart = dateTime;
                txt_Calendario.SelectionEnd = dateTime;
            }
            catch (Exception)
            {
                
            }
                bttn_Save.Enabled = false;

        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text, AP = txt_Apellido.Text, TEL = txt_Tel.Text, Mail = txt_Mail.Text
                , datetime = txt_Calendario.SelectionStart.Year.ToString() + "-" + txt_Calendario.SelectionStart.Month.ToString() + "-" + txt_Calendario.SelectionStart.Day.ToString();
            SqlCommand cmd = new SqlCommand(String.Format("Insert into Client values ('{0}','{1}','{2}','{3}','{4}')", Name, AP, TEL, Mail, datetime), conexion);
            if (txt_Calendario.SelectionStart>DateTime.Now)
            {
                MessageBox.Show("Fecha de Nacimiento Invalida", "Favor revise Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); conexion.Close();

            }else
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Guardado");

            }
            catch (Exception)
            {

                MessageBox.Show("El telefono Invalido Revise datos", "Favor revise Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); conexion.Close();
            }
            conexion.Close();
            Activacion(1);
        }

        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text, AP = txt_Apellido.Text, TEL = txt_Tel.Text, Mail = txt_Mail.Text
                , datetime = txt_Calendario.SelectionStart.Year.ToString() + "-" + txt_Calendario.SelectionStart.Month.ToString() + "-" + txt_Calendario.SelectionStart.Day.ToString();
            SqlCommand sql = new SqlCommand(String.Format("UPDATE [dbo].[Client] SET [NameC] = '{0}',[APC] = '{1}',[Mail] = '{3}',[FNAC] = '{4}' WHERE [Tel] = '{2}' ", Name, AP, TEL, Mail, datetime), conexion);
            try
            {
                conexion.Open();
                sql.ExecuteNonQuery();
                Activacion(1);
            }
            catch (Exception)
            {

                throw;
            }
            conexion.Close();
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas Seguro de eliminar al numero " + txt_Tel.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    SqlCommand sql = new SqlCommand(String.Format("DELETE FROM [dbo].[Client] WHERE Tel='{0}'", txt_Tel.Text), conexion);
                    conexion.Close();
                    conexion.Open();
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado el Cliente.", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("No es posible eliminar, Error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                conexion.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada");
            }
            conexion.Close();
            Activacion(1);
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Tel_TextChanged(object sender, EventArgs e)
        {
            //Reutilizar para Ventas
            code=String.Format("where Tel like '{0}%'",txt_Tel.Text);
            Activacion(0);
        }
    }
}
