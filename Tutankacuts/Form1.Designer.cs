namespace Tutankacuts
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelMenu = new Panel();
            Salir = new FontAwesome.Sharp.IconButton();
            Venta = new FontAwesome.Sharp.IconButton();
            Ajustes = new FontAwesome.Sharp.IconButton();
            Clientes = new FontAwesome.Sharp.IconButton();
            Empleados = new FontAwesome.Sharp.IconButton();
            Inventario = new FontAwesome.Sharp.IconButton();
            Citas = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            BtnHome = new PictureBox();
            panel1 = new Panel();
            LaHome = new Label();
            iconCurrentHome = new FontAwesome.Sharp.IconPictureBox();
            Shadow = new Panel();
            PanelDesktop = new Panel();
            lbfecha = new Label();
            lbhora = new Label();
            Hora = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentHome).BeginInit();
            PanelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(Salir);
            panelMenu.Controls.Add(Venta);
            panelMenu.Controls.Add(Ajustes);
            panelMenu.Controls.Add(Clientes);
            panelMenu.Controls.Add(Empleados);
            panelMenu.Controls.Add(Inventario);
            panelMenu.Controls.Add(Citas);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(10, 0, 20, 0);
            panelMenu.Size = new Size(240, 569);
            panelMenu.TabIndex = 0;
            // 
            // Salir
            // 
            Salir.Dock = DockStyle.Top;
            Salir.FlatAppearance.BorderSize = 0;
            Salir.FlatStyle = FlatStyle.Flat;
            Salir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Salir.ForeColor = Color.Gainsboro;
            Salir.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            Salir.IconColor = Color.WhiteSmoke;
            Salir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            Salir.IconSize = 30;
            Salir.ImageAlign = ContentAlignment.MiddleLeft;
            Salir.Location = new Point(10, 500);
            Salir.Name = "Salir";
            Salir.Size = new Size(210, 60);
            Salir.TabIndex = 7;
            Salir.Text = "Salir";
            Salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Venta
            // 
            Venta.Dock = DockStyle.Top;
            Venta.FlatAppearance.BorderSize = 0;
            Venta.FlatStyle = FlatStyle.Flat;
            Venta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Venta.ForeColor = Color.Gainsboro;
            Venta.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            Venta.IconColor = Color.WhiteSmoke;
            Venta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            Venta.IconSize = 30;
            Venta.ImageAlign = ContentAlignment.MiddleLeft;
            Venta.Location = new Point(10, 440);
            Venta.Name = "Venta";
            Venta.Size = new Size(210, 60);
            Venta.TabIndex = 6;
            Venta.Text = "Ventas";
            Venta.TextImageRelation = TextImageRelation.ImageBeforeText;
            Venta.UseVisualStyleBackColor = true;
            Venta.Click += Venta_Click;
            // 
            // Ajustes
            // 
            Ajustes.Dock = DockStyle.Top;
            Ajustes.FlatAppearance.BorderSize = 0;
            Ajustes.FlatStyle = FlatStyle.Flat;
            Ajustes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Ajustes.ForeColor = Color.Gainsboro;
            Ajustes.IconChar = FontAwesome.Sharp.IconChar.Gear;
            Ajustes.IconColor = Color.WhiteSmoke;
            Ajustes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            Ajustes.IconSize = 30;
            Ajustes.ImageAlign = ContentAlignment.MiddleLeft;
            Ajustes.Location = new Point(10, 380);
            Ajustes.Name = "Ajustes";
            Ajustes.Size = new Size(210, 60);
            Ajustes.TabIndex = 5;
            Ajustes.Text = "Ajustes";
            Ajustes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ajustes.UseVisualStyleBackColor = true;
            Ajustes.Click += Ajustes_Click;
            // 
            // Clientes
            // 
            Clientes.Dock = DockStyle.Top;
            Clientes.FlatAppearance.BorderSize = 0;
            Clientes.FlatStyle = FlatStyle.Flat;
            Clientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Clientes.ForeColor = Color.Gainsboro;
            Clientes.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            Clientes.IconColor = Color.WhiteSmoke;
            Clientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            Clientes.IconSize = 30;
            Clientes.ImageAlign = ContentAlignment.MiddleLeft;
            Clientes.Location = new Point(10, 320);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(210, 60);
            Clientes.TabIndex = 4;
            Clientes.Text = "Clientes";
            Clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Clientes.UseVisualStyleBackColor = true;
            Clientes.Click += Clientes_Click;
            // 
            // Empleados
            // 
            Empleados.Dock = DockStyle.Top;
            Empleados.FlatAppearance.BorderSize = 0;
            Empleados.FlatStyle = FlatStyle.Flat;
            Empleados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Empleados.ForeColor = Color.Gainsboro;
            Empleados.IconChar = FontAwesome.Sharp.IconChar.User;
            Empleados.IconColor = Color.WhiteSmoke;
            Empleados.IconFont = FontAwesome.Sharp.IconFont.Solid;
            Empleados.IconSize = 30;
            Empleados.ImageAlign = ContentAlignment.MiddleLeft;
            Empleados.Location = new Point(10, 260);
            Empleados.Name = "Empleados";
            Empleados.Size = new Size(210, 60);
            Empleados.TabIndex = 3;
            Empleados.Text = "Empleados";
            Empleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            Empleados.UseVisualStyleBackColor = true;
            Empleados.Click += Empleados_Click;
            // 
            // Inventario
            // 
            Inventario.Dock = DockStyle.Top;
            Inventario.FlatAppearance.BorderSize = 0;
            Inventario.FlatStyle = FlatStyle.Flat;
            Inventario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Inventario.ForeColor = Color.Gainsboro;
            Inventario.IconChar = FontAwesome.Sharp.IconChar.Database;
            Inventario.IconColor = Color.WhiteSmoke;
            Inventario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            Inventario.IconSize = 30;
            Inventario.ImageAlign = ContentAlignment.MiddleLeft;
            Inventario.Location = new Point(10, 200);
            Inventario.Name = "Inventario";
            Inventario.Size = new Size(210, 60);
            Inventario.TabIndex = 2;
            Inventario.Text = "Inventario";
            Inventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            Inventario.UseVisualStyleBackColor = true;
            Inventario.Click += Inventario_Click;
            // 
            // Citas
            // 
            Citas.Dock = DockStyle.Top;
            Citas.FlatAppearance.BorderSize = 0;
            Citas.FlatStyle = FlatStyle.Flat;
            Citas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Citas.ForeColor = Color.Gainsboro;
            Citas.IconChar = FontAwesome.Sharp.IconChar.Book;
            Citas.IconColor = Color.WhiteSmoke;
            Citas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            Citas.IconSize = 30;
            Citas.ImageAlign = ContentAlignment.MiddleLeft;
            Citas.Location = new Point(10, 140);
            Citas.Name = "Citas";
            Citas.Size = new Size(210, 60);
            Citas.TabIndex = 1;
            Citas.Text = "Citas";
            Citas.TextImageRelation = TextImageRelation.ImageBeforeText;
            Citas.UseVisualStyleBackColor = true;
            Citas.Click += Citas_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(BtnHome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 140);
            panel2.TabIndex = 0;
            // 
            // BtnHome
            // 
            BtnHome.BackgroundImage = (Image)resources.GetObject("BtnHome.BackgroundImage");
            BtnHome.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHome.Location = new Point(36, 12);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(128, 128);
            BtnHome.TabIndex = 1;
            BtnHome.TabStop = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(LaHome);
            panel1.Controls.Add(iconCurrentHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(240, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 80);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // LaHome
            // 
            LaHome.AutoSize = true;
            LaHome.BackColor = Color.FromArgb(64, 64, 64);
            LaHome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LaHome.ForeColor = Color.Gainsboro;
            LaHome.Location = new Point(60, 28);
            LaHome.Name = "LaHome";
            LaHome.Size = new Size(59, 28);
            LaHome.TabIndex = 1;
            LaHome.Text = "Inicio";
            // 
            // iconCurrentHome
            // 
            iconCurrentHome.BackColor = Color.FromArgb(64, 64, 64);
            iconCurrentHome.ForeColor = Color.Gainsboro;
            iconCurrentHome.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentHome.IconColor = Color.Gainsboro;
            iconCurrentHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentHome.Location = new Point(22, 27);
            iconCurrentHome.Name = "iconCurrentHome";
            iconCurrentHome.Size = new Size(32, 32);
            iconCurrentHome.TabIndex = 0;
            iconCurrentHome.TabStop = false;
            // 
            // Shadow
            // 
            Shadow.BackColor = Color.Black;
            Shadow.Dock = DockStyle.Top;
            Shadow.Location = new Point(240, 80);
            Shadow.Name = "Shadow";
            Shadow.Size = new Size(882, 10);
            Shadow.TabIndex = 2;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.FromArgb(31, 30, 68);
            PanelDesktop.Controls.Add(lbfecha);
            PanelDesktop.Controls.Add(lbhora);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(240, 90);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(882, 479);
            PanelDesktop.TabIndex = 3;
            // 
            // lbfecha
            // 
            lbfecha.AutoSize = true;
            lbfecha.BackColor = Color.Transparent;
            lbfecha.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            lbfecha.ForeColor = Color.FromArgb(128, 128, 255);
            lbfecha.Location = new Point(35, 149);
            lbfecha.Name = "lbfecha";
            lbfecha.Size = new Size(194, 81);
            lbfecha.TabIndex = 1;
            lbfecha.Text = "label2";
            // 
            // lbhora
            // 
            lbhora.AutoSize = true;
            lbhora.BackColor = Color.Transparent;
            lbhora.Font = new Font("Segoe UI", 70F, FontStyle.Regular, GraphicsUnit.Point);
            lbhora.ForeColor = Color.FromArgb(192, 192, 255);
            lbhora.Location = new Point(22, 22);
            lbhora.Name = "lbhora";
            lbhora.Size = new Size(302, 125);
            lbhora.TabIndex = 0;
            lbhora.Text = "label1";
            // 
            // Hora
            // 
            Hora.Enabled = true;
            Hora.Tick += Hora_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 569);
            Controls.Add(PanelDesktop);
            Controls.Add(Shadow);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentHome).EndInit();
            PanelDesktop.ResumeLayout(false);
            PanelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton Salir;
        private FontAwesome.Sharp.IconButton Ajustes;
        private FontAwesome.Sharp.IconButton Clientes;
        private FontAwesome.Sharp.IconButton Empleados;
        private FontAwesome.Sharp.IconButton Inventario;
        private FontAwesome.Sharp.IconButton Citas;
        private PictureBox BtnHome;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentHome;
        private Label LaHome;
        private Panel Shadow;
        private Panel PanelDesktop;
        private Label lbfecha;
        private Label lbhora;
        private System.Windows.Forms.Timer Hora;
        private FontAwesome.Sharp.IconButton Venta;
    }
}