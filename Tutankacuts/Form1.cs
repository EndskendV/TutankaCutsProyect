using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Tutankacuts
{

    public partial class Home : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=.\MSSQLSERVER01; Initial Catalog=Tutankacuts; integrated security=true");
        //construccion
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private Form CurrentOtherForm;
        public Home()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftborderBtn);

            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        // Metodo Struct
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(250, 45, 1);
            public static Color color2 = Color.FromArgb(250, 107, 1);
            public static Color color3 = Color.FromArgb(250, 224, 1);
            public static Color color4 = Color.FromArgb(107, 250, 1);
            public static Color color5 = Color.FromArgb(1, 250, 250);
            public static Color color6 = Color.FromArgb(148, 1, 250);
        }
        //Metodo
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Personalizacion de los botones
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Borde del botono izquierdo
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();
                iconCurrentHome.IconChar = currentBtn.IconChar;
                iconCurrentHome.ForeColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Valores del boton por defecto
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void Citas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenAnotherForms(new Citas());

        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            string check = this.Text.ToString().Substring(0, 1);
            if (check != string.Format("1")) { MessageBox.Show("No se permite el acceso al usuario", "Ingresa como administrador", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                ActivateButton(sender, RGBColors.color2);
                OpenAnotherForms(new Inventario());
            }
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenAnotherForms(new Empleados());
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenAnotherForms(new Clientes());
        }

        private void Ajustes_Click(object sender, EventArgs e)
        {
            string check = this.Text.ToString().Substring(0, 1);
            if (check != string.Format("1")) { MessageBox.Show("No se permite el acceso al usuario", "Ingresa como administrador", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                ActivateButton(sender, RGBColors.color5);
                OpenAnotherForms(new Ajustes());
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenAnotherForms(new Salir());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Venta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenAnotherForms(new Ventas());
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            CurrentOtherForm.Close();
            Reset();
        }
       
        private void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
            iconCurrentHome.IconChar = IconChar.Home;
            iconCurrentHome.ForeColor = Color.Gainsboro;
            LaHome.Text = "Inicio";
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void OpenAnotherForms(Form OtherForms)
        {
            // Abrir
            if (CurrentOtherForm != null)
            {
                //Abrir un solo form
                CurrentOtherForm.Close();
            }
            CurrentOtherForm = OtherForms;
            OtherForms.TopLevel = false;
            OtherForms.FormBorderStyle = FormBorderStyle.None;
            OtherForms.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(OtherForms);
            PanelDesktop.Tag = OtherForms;
            OtherForms.BringToFront();
            LaHome.Text = OtherForms.Text;
            OtherForms.Text = this.Text;
            OtherForms.Show();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToShortTimeString();
            lbfecha.Text = DateTime.Now.ToLongDateString();
        }

    }
}