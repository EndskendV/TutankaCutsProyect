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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        private void Citas_Load(object sender, EventArgs e)
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

                    Grid_Cita.Rows.Clear();
                    USR = this.Text.ToString().Substring(4);
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT [NameC],[Tel],[FCita],[TimeAtt],[Barbero],[Tipo],[Asist]FROM [dbo].[Citas] {0}", code), conexion);
                    conexion.Close(); code = "";
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Cita);
                        row.Cells[0].Value = dr[0].ToString();
                        row.Cells[1].Value = dr[1].ToString();
                        row.Cells[2].Value = dr[2].ToString();
                        row.Cells[3].Value = dr[3].ToString();
                        row.Cells[4].Value = dr[4].ToString();
                        row.Cells[5].Value = dr[5].ToString();
                        row.Cells[6].Value = dr[6].ToString();
                        Grid_Cita.Rows.Add(row);

                    }
                    cmd.Dispose(); dr.Dispose();
                    cmd = new SqlCommand(String.Format("select * from Barberos"), conexion);
                    dr = cmd.ExecuteReader();
                    Combo_Barber.Items.Clear();
                    while (dr.Read())
                    {
                        Combo_Barber.Items.Add(dr.GetString(0));
                    }
                    conexion.Close();

                    bttn_Delete.Enabled = false;
                    bttn_Save.Enabled = true;
                    break;
                case 1:
                    txt_Name.Text = "";
                    txt_Tel.Text = "";
                    txt_Calendario.Value = DateTime.Now;
                    Activacion(0);
                    break;
                case 2:
                    //Codigo Custom
                    Grid_Cita.Rows.Clear();
                    SqlCommand cmd1 = new SqlCommand(code, conexion);
                    conexion.Close(); code = "";
                    conexion.Open();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Cita);
                        row.Cells[0].Value = dr1[0].ToString();
                        row.Cells[1].Value = dr1[1].ToString();
                        row.Cells[2].Value = dr1[2].ToString();
                        row.Cells[3].Value = dr1[3].ToString();
                        row.Cells[4].Value = dr1[4].ToString();
                        row.Cells[5].Value = dr1[5].ToString();
                        row.Cells[6].Value = dr1[6].ToString();

                        Grid_Cita.Rows.Add(row);
                    }
                    cmd1.Dispose(); dr1.Dispose();
                    conexion.Close();
                    break;
                case 3:  //Codigo Custom
                    Grid_Cita.Rows.Clear();
                    SqlCommand cmd2 = new SqlCommand(code, conexion);
                    conexion.Close(); code = "";
                    conexion.Open();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Cita);
                        row.Cells[0].Value = dr2[0].ToString();
                        row.Cells[1].Value = dr2[1].ToString();

                        Grid_Cita.Rows.Add(row);
                    }
                    cmd2.Dispose(); dr2.Dispose();
                    conexion.Close();

                    break;
                case 4:

                default:
                    break;
            }

        }

        private void bttn_Consult_Click(object sender, EventArgs e)
        {
            //Formato Para Fecha and ( Asist not like 'Cancelo')
            string datetime = txt_Calendario.Value.Date.Year.ToString() + "-" + txt_Calendario.Value.Date.Month.ToString() + "-" + txt_Calendario.Value.Date.Day.ToString();
            code = String.Format("\r\ndeclare @Fecha Date\r\nset @Fecha='{0}'\r\nSELECT [NameC],[Tel],[FCita],[TimeAtt],[Barbero],[Tipo],[Asist]FROM [dbo].[Citas] where (FCita>DATEADD(DAY, -1, @Fecha))  and (FCita<DATEADD(DAY, 1,@Fecha))\r\n", datetime);
            Activacion(2);
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Tel_TextChanged(object sender, EventArgs e)
        {

            code = String.Format("select * from VistaName where Tel like '{0}%'", txt_Tel.Text);
            Activacion(3);
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            code = String.Format("select * from VistaName where NameC like '%{0}%'", txt_Name.Text);
            Activacion(3);
        }

        private void bttn_Seleccionar_Click(object sender, EventArgs e)
        {
            string name=Grid_Cita.CurrentRow.Cells[0].Value.ToString(),tel= Grid_Cita.CurrentRow.Cells[1].Value.ToString();
            txt_Name.Text = name;
            txt_Tel.Text = tel;
            txt_Calendario.Value = DateTime.Now;
            bttn_Delete.Enabled = true;
            code = String.Format("SELECT [NameC],[Tel],[FCita],[TimeAtt],[Barbero],[Tipo],[Asist]FROM [dbo].[Citas] where NameC like '{0}' and Tel like '{1}'", txt_Name.Text, txt_Tel.Text
                );
            Activacion(2);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
