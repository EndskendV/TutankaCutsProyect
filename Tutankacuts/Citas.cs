using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

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
                    //Codigo dfe Inicio
                    Grid_Cita.Rows.Clear();
                    USR = this.Text.ToString().Substring(4);
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT [NameC],[Tel],[FCita],[TimeAtt],[Barbero],[Tipo],[Asist],CitaNum FROM [dbo].[Citas] {0}", code), conexion);
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
                        row.Cells[7].Value = dr[7].ToString();
                        Grid_Cita.Rows.Add(row);

                    }
                    cmd.Dispose(); dr.Dispose();
                    cmd = new(String.Format("select * from Barberos"), conexion);
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
                    //Codigo Custom 7Param
                    Grid_Cita.Rows.Clear();
                    conexion.Close();
                    conexion.Open();
                    SqlCommand cmd1 = new SqlCommand(code, conexion);
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
                        row.Cells[7].Value = dr1[7].ToString();

                        Grid_Cita.Rows.Add(row);
                    }
                    code = "";
                    cmd1.Dispose(); dr1.Dispose();
                    conexion.Close();
                    break;
                case 3:  //Codigo Custom Lectura 2Param
                    Grid_Cita.Rows.Clear();
                    SqlCommand cmd2 = new SqlCommand(code, conexion);
                    conexion.Close(); code = "";
                    conexion.Open();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Cita);
                        row.Cells[0].Value = dr2[1].ToString();
                        row.Cells[1].Value = dr2[0].ToString();

                        Grid_Cita.Rows.Add(row);
                    }
                    cmd2.Dispose(); dr2.Dispose();
                    conexion.Close();

                    break;
                case 4://Revisar Campos esten llenos
                    bool Checked = false;
                    Checked = string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_Tel.Text) || string.IsNullOrEmpty(txt_Calendario.Text) ||
                        string.IsNullOrEmpty(Combo_Hrs.Text) || string.IsNullOrEmpty(Combo_Barber.Text) || string.IsNullOrEmpty(Combo_Tipo.Text);
                    if (Checked == true) MessageBox.Show("Favor de rellenar Todos los campos");
                    else try
                        {
                            if (string.IsNullOrEmpty(Combo_asist.Text)) Combo_asist.SelectedIndex = 0;
                            int RowsCont = 0
                                ;
                            foreach (DataGridViewRow row in Grid_Cita.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    RowsCont++;
                                }
                            }
                            if (RowsCont <= 9)
                            {

                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(Grid_Cita);
                                Grid_Cita.Rows.Add(row);
                                throw new Exception(message: "El Cliente no esta dado de alta. Se utilizara valor actual");
                            }
                            string datetime = Fecha_toString();
                            SqlCommand add = new SqlCommand(String.Format("insert into Citas values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", txt_Tel.Text, txt_Name.Text, datetime
                                , Combo_Hrs.Text, Combo_Barber.Text, Combo_Tipo.Text, Combo_asist.Text), conexion);
                            conexion.Open();
                            add.ExecuteNonQuery();
                            conexion.Close();
                            MessageBox.Show("Cita Agendada");
                            Activacion(10);

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            conexion.Close();
                            SqlCommand ExAdd = new SqlCommand(String.Format("Insert into Client (Tel,NameC) values ('{0}','{1}')", txt_Tel.Text, txt_Name.Text), conexion);
                            try
                            {
                                conexion.Open();
                                ExAdd.ExecuteNonQuery();
                                MessageBox.Show("Actializar los datos del Nuevo Cliente al terminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                ExAdd.Dispose();
                                conexion.Close();


                                Activacion(4);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error al dar de alta nuevo Cliente");
                            }


                        }
                    conexion.Close();

                    break;
                case 10:
                    txt_Calendario.Value = DateTime.Now;
                    txt_Tel.Text = "";
                    txt_Name.Text = "";
                    Combo_asist.Text = "";
                    Combo_Barber.Text = "";
                    Combo_Hrs.Text = "";
                    Combo_Tipo.Text = "";
                    lbl_ID.Text = "#";
                    txt_Tel.Enabled = true;
                    txt_Name.Enabled = true;
                    Activacion(0);
                    break;
                case 11:
                    txt_Calendario.Value = DateTime.Now;
                    txt_Tel.Text = "";
                    txt_Name.Text = "";
                    Combo_asist.Text = "";
                    Combo_Barber.Text = "";
                    Combo_Hrs.Text = "";
                    Combo_Tipo.Text = "";
                    lbl_ID.Text = "#";
                    txt_Tel.Enabled = true;
                    txt_Name.Enabled = true;
                    break;

                default:
                    break;
            }

        }

        private void bttn_Consult_Click(object sender, EventArgs e)
        {
            //Formato Para Fecha and ( Asist not like 'Cancelo')
            string datetime = Fecha_toString();
            code = String.Format("\r\ndeclare @Fecha Date\r\nset @Fecha='{0}'\r\nSELECT [NameC],[Tel],[FCita],[TimeAtt],[Barbero],[Tipo],[Asist], CitaNum FROM [dbo].[Citas] where (FCita>DATEADD(DAY, -1, @Fecha))  and (FCita<DATEADD(DAY, 1,@Fecha))\r\n", datetime);
            Activacion(2);
            Activacion(11);
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

            try
            {
                string name = Grid_Cita.CurrentRow.Cells[0].Value.ToString(), tel = Grid_Cita.CurrentRow.Cells[1].Value.ToString();

                if (string.IsNullOrEmpty(Grid_Cita.CurrentRow.Cells[2].Value.ToString()))
                {

                }
                else
                {
                    string
                        Feccha = Grid_Cita.CurrentRow.Cells[2].Value.ToString() ?? string.Empty, Barber = Grid_Cita.CurrentRow.Cells[4].Value.ToString() ?? string.Empty,
                        Tipo = Grid_Cita.CurrentRow.Cells[5].Value.ToString() ?? string.Empty, Asist = Grid_Cita.CurrentRow.Cells[6].Value.ToString() ?? string.Empty,
                        IDd = Grid_Cita.CurrentRow.Cells[7].Value.ToString() ?? string.Empty, hora = Grid_Cita.CurrentRow.Cells[3].Value.ToString() ?? string.Empty;

                    Combo_Tipo.Text = Tipo;
                    Combo_Hrs.Text = hora;
                    Combo_Barber.Text = Barber;
                    Combo_asist.Text = Asist;
                    lbl_ID.Text = IDd;
                    txt_Calendario.Text = Feccha;

                }
                txt_Name.Text = name; txt_Name.Enabled = false;
                txt_Tel.Text = tel; txt_Tel.Enabled = false; Thread.Sleep(20);
                code = String.Format("SELECT [NameC],[Tel],[FCita],[TimeAtt],[Barbero],[Tipo],[Asist],CitaNum FROM [dbo].[Citas] where NameC like '{0}' and Tel like '{1}'", txt_Name.Text, txt_Tel.Text);

                Activacion(2);
                Thread.Sleep(50);
                int numeroBuscado = int.Parse(lbl_ID.Text); // Número que deseas buscar en el grid

                foreach (DataGridViewRow row in Grid_Cita.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString() == numeroBuscado.ToString())
                        {
                            row.DefaultCellStyle.BackColor = Color.Aqua; // Pintar toda la fila
                            break;
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Grid Vacio");
            }
            bttn_Delete.Enabled = true;

        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            Activacion(11);
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text == "#")
            {
                Activacion(4);
            }
            else
            {
                MessageBox.Show("Favor de no tener seleccionado ninguna Cita");
            }
        }
        string Fecha_toString()
        {
            string datetime = txt_Calendario.Value.Date.Year.ToString() + "-" + txt_Calendario.Value.Date.Month.ToString() + "-" + txt_Calendario.Value.Date.Day.ToString();
            return datetime;
        }
        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "#")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(String.Format("UPDATE [dbo].[Citas] SET [FCita] = '{1}'  ,[TimeAtt] ='{2}' ,[Barbero] = '{3}',[Tipo] = '{4}'\r\n      ,[Asist] = '{5}'\r\n WHERE CitaNum='{0}'", lbl_ID.Text, Fecha_toString(), Combo_Hrs.Text, Combo_Barber.Text, Combo_Tipo.Text, Combo_asist.Text), conexion);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close(); MessageBox.Show("Datos Actualizados");
                    Activacion(10);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else MessageBox.Show("Favor Seleccionar una cita");
        }

        private void Citas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                code = String.Format("SELECT[NameC],[Tel],[FCita],[TimeAtt],[Barbero],[Tipo],[Asist],CitaNum FROM[dbo].[Citas] where(FCita > GETDATE() -1)  and (FCita < GETDATE() )");
                Activacion(2);
                MessageBox.Show("Test");
            }

        }

        private void Grid_Cita_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Grid_Cita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name.Text = Grid_Cita.CurrentRow.Cells[0].Value.ToString();
            txt_Tel.Text = Grid_Cita.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
