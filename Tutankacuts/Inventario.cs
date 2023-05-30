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
                    Grid_Product.Rows.Clear();
                    USR = this.Text.ToString().Substring(4);
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT [NameProducto]\r\n      ,[TipoPrd]\r\n      ,[Contenido]\r\n      ,[Unidades]\r\n      ,[Price]\r\n      ,[Proveedor]\r\n  FROM [dbo].[Productos] {0}", code), conexion);
                    conexion.Close(); code = "";
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Product);
                        row.Cells[0].Value = dr[0].ToString();
                        row.Cells[1].Value = dr[1].ToString();
                        row.Cells[2].Value = dr[2].ToString();
                        row.Cells[3].Value = dr[3].ToString();
                        row.Cells[4].Value = dr[4].ToString();
                        row.Cells[5].Value = dr[5].ToString();
                        Grid_Product.Rows.Add(row);

                    }
                    cmd.Dispose(); dr.Dispose();
                    /*   cmd = new(String.Format("select IDProduct from Productos"), conexion);
                       dr = cmd.ExecuteReader();
                       Combo_Barber.Items.Clear();
                       while (dr.Read())
                       {
                           Combo_Barber.Items.Add(dr.GetString(0));
                       }*/
                    conexion.Close();

                    bttn_Delete.Enabled = false;
                    bttn_Save.Enabled = true;
                    break;
                case 1:
                    ;
                    break;
                case 2:
                    //Codigo Custom 7Param
                    conexion.Close();
                    conexion.Open();
                    SqlCommand cmd1 = new SqlCommand(code, conexion);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Product);
                        row.Cells[0].Value = dr1[0].ToString();
                        row.Cells[1].Value = dr1[1].ToString();
                        row.Cells[2].Value = dr1[2].ToString();
                        row.Cells[3].Value = dr1[3].ToString();
                        row.Cells[4].Value = dr1[4].ToString();
                        row.Cells[5].Value = dr1[5].ToString();
                        row.Cells[6].Value = dr1[6].ToString();
                        row.Cells[7].Value = dr1[7].ToString();

                        Grid_Product.Rows.Add(row);
                    }
                    code = "";
                    cmd1.Dispose(); dr1.Dispose();
                    conexion.Close();
                    break;
                case 3:  //Codigo Custom Lectura 2Param
                    Grid_Product.Rows.Clear();
                    SqlCommand cmd2 = new SqlCommand(code, conexion);
                    conexion.Close(); code = "";
                    conexion.Open();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Product);
                        row.Cells[0].Value = dr2[1].ToString();
                        row.Cells[1].Value = dr2[0].ToString();

                        Grid_Product.Rows.Add(row);
                    }
                    cmd2.Dispose(); dr2.Dispose();
                    conexion.Close();

                    break;
                case 4://Revisar Campos esten llenos


                    break;

                default:
                    break;
            }

        }

        private void Grid_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = Grid_Product.CurrentRow.Cells[6].Value.ToString() ?? string.Empty;
            SqlCommand sqlCommand = new SqlCommand(string.Format(""), conexion);
        }
    }
}
