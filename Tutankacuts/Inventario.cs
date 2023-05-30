using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutankacuts
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            Activacion(0);
        }

        string USR = "", code = "";
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=Tutankacuts; integrated security=true");

        void Activacion(int id)
        {
            switch (id)
            {
                case 0:
                    //Codigo dfe Inicio
                    USR = this.Text.ToString().Substring(4);
                    Grid_Product.DataSource = Llenado_Grid();


                    bttn_Delete.Enabled = false;
                    bttn_Modify.Enabled = false;
                    bttn_Save.Enabled = true;

                    lbl_ID.Text = "#";
                    txt_Cont.Text = "";
                    txt_Name.Text = "";
                    txt_Price.Text = "";
                    Combo_Proov.Text = "";
                    Combo_Tipo.Text = "";
                    Combo_Units.Text = "";
                    break;
                case 1:

                    break;
                case 2:
                    break;
                case 3:  //Codigo Custom Lectura 2Param
                    Grid_Product.DataSource = Llenado_Grid(code);

                    break;
                case 4://Revisar Campos esten llenos
                    bool Checked = false;
                    Checked = string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_Cont.Text) || string.IsNullOrEmpty(txt_Price.Text) ||
                        string.IsNullOrEmpty(Combo_Proov.Text) || string.IsNullOrEmpty(Combo_Units.Text) || string.IsNullOrEmpty(Combo_Tipo.Text);
                    if (Checked) MessageBox.Show("Favor de rellenar Todos los campos");
                    else try
                        {
                            SqlCommand sqlCommand = new SqlCommand(string.Format("insert into Productos values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                                , txt_Name.Text, Combo_Units.Text, Combo_Tipo.Text, txt_Price.Text, txt_Cont.Text, Combo_Proov.Text), conexion);
                            conexion.Open();
                            sqlCommand.ExecuteNonQuery();
                            conexion.Close();
                            MessageBox.Show("Producto Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Activacion(0);
                        }
                        catch (Exception e)
                        {

                            MessageBox.Show("Error al dar de alta: " + e.Message);
                        }
                    conexion.Close();
                    break;

                default:
                    break;
            }

        }

        private void Grid_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ID.Text = Grid_Product.CurrentRow.Cells[6].Value.ToString(); SqlCommand sqlCommand = new SqlCommand(String.Format("select [NameProducto],[TipoPrd],[Contenido],[Unidades],[Price],[Proveedor] from [Productos] where [IDProduct] like '{0}'", lbl_ID.Text), conexion);
            conexion.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                txt_Name.Text = reader.GetString(0);
                Combo_Tipo.Text = reader.GetString(1);
                txt_Cont.Text = reader.GetString(2);
                Combo_Units.Text = reader.GetSqlInt32(3).ToString();
                txt_Price.Text = reader.GetSqlMoney(4).ToString();
                Combo_Proov.Text = reader.GetString(5);

            }
            conexion.Close();
            bttn_Modify.Enabled = true; bttn_Delete.Enabled = true; bttn_Save.Enabled = false;

        }


        public DataTable Llenado_Grid()
        {
            conexion.Open();
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(String.Format("Select [NameProducto]as Nombre,[TipoPrd] as Tipo,[Contenido],[Unidades],[Price]as Precio,[Proveedor],[IDProduct]as ID   from Productos {0}", code), conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(dt);
            code = ""; conexion.Close();
            return dt;
        }
        public DataTable Llenado_Grid(string Commandosql)
        {
            conexion.Open();
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(Commandosql, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(dt);
            conexion.Close();
            return dt;
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            Activacion(4);
        }

        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            bool Checked = false;
            Checked = string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_Cont.Text) || string.IsNullOrEmpty(txt_Price.Text) ||
                string.IsNullOrEmpty(Combo_Proov.Text) || string.IsNullOrEmpty(Combo_Units.Text) || string.IsNullOrEmpty(Combo_Tipo.Text);
            if (Checked) MessageBox.Show("Favor de rellenar Todos los campos");
            else try
                {
                    SqlCommand sqlCommand = new SqlCommand(string.Format("UPDATE [dbo].[Productos] SET [NameProducto] = '{0}',[Unidades] = '{1}',[TipoPrd] = '{2}',[Price] = '{3}',[Contenido] = '{4}',[Proveedor] = '{5}' WHERE [IDProduct] like '{6}'"
                        , txt_Name.Text, Combo_Units.Text, Combo_Tipo.Text, txt_Price.Text, txt_Cont.Text, Combo_Proov.Text, lbl_ID.Text), conexion);
                    conexion.Open();
                    sqlCommand.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Producto Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Activacion(0);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al Modificar: " + ex.Message);
                }

        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "#")
            {
                DialogResult dialogResult = MessageBox.Show("Estas Seguro de eliminar al Producto " + lbl_ID.Text + "- " + txt_Name.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(string.Format("DELETE FROM [dbo].[Productos] WHERE [IDProduct] like '{0}'", lbl_ID.Text), conexion);
                        conexion.Open();
                        sqlCommand.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Producto Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Activacion(0);
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
                Activacion(0);
            }
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            Activacion(0);
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "#")
            {

            }
        }
    }
}
