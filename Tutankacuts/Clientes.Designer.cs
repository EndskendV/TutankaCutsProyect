namespace Tutankacuts
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            txt_Tel = new TextBox();
            label2 = new Label();
            txt_Name = new TextBox();
            label1 = new Label();
            txt_Mail = new TextBox();
            label4 = new Label();
            grid_Cliente = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Ap = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            FechaNac = new DataGridViewTextBoxColumn();
            txt_Calendario = new MonthCalendar();
            txt_Apellido = new TextBox();
            label5 = new Label();
            bttn_Seleccionar = new Button();
            bttn_Cancel = new Button();
            bttn_Delete = new Button();
            bttn_Modify = new Button();
            bttn_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_Cliente).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(362, 27);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 31;
            label3.Text = "Fecha nacimiento";
            // 
            // txt_Tel
            // 
            txt_Tel.Location = new Point(163, 136);
            txt_Tel.Name = "txt_Tel";
            txt_Tel.Size = new Size(164, 23);
            txt_Tel.TabIndex = 3;
            txt_Tel.Tag = "";
            txt_Tel.Text = "000-000-0000";
            txt_Tel.TextAlign = HorizontalAlignment.Center;
            txt_Tel.TextChanged += txt_Tel_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(60, 134);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 29;
            label2.Text = "Telefono";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(163, 29);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(164, 23);
            txt_Name.TabIndex = 1;
            txt_Name.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(60, 27);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 27;
            label1.Text = "Nombre";
            // 
            // txt_Mail
            // 
            txt_Mail.Location = new Point(163, 191);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.Size = new Size(164, 23);
            txt_Mail.TabIndex = 4;
            txt_Mail.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(60, 189);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 32;
            label4.Text = "Correo";
            // 
            // grid_Cliente
            // 
            grid_Cliente.BackgroundColor = Color.FromArgb(34, 33, 74);
            grid_Cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_Cliente.Columns.AddRange(new DataGridViewColumn[] { Nombre, Ap, Tel, Correo, FechaNac });
            grid_Cliente.Location = new Point(54, 241);
            grid_Cliente.Name = "grid_Cliente";
            grid_Cliente.RowTemplate.Height = 25;
            grid_Cliente.Size = new Size(714, 179);
            grid_Cliente.TabIndex = 34;
            grid_Cliente.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Ap
            // 
            Ap.HeaderText = "Apellido";
            Ap.Name = "Ap";
            // 
            // Tel
            // 
            Tel.HeaderText = "Telefono";
            Tel.Name = "Tel";
            Tel.Width = 170;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.Width = 200;
            // 
            // FechaNac
            // 
            FechaNac.HeaderText = "Fecha Nacimiento";
            FechaNac.Name = "FechaNac";
            // 
            // txt_Calendario
            // 
            txt_Calendario.Location = new Point(371, 57);
            txt_Calendario.Name = "txt_Calendario";
            txt_Calendario.TabIndex = 5;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(163, 84);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(164, 23);
            txt_Apellido.TabIndex = 2;
            txt_Apellido.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(60, 82);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 40;
            label5.Text = "Apellido";
            // 
            // bttn_Seleccionar
            // 
            bttn_Seleccionar.Location = new Point(693, 191);
            bttn_Seleccionar.Name = "bttn_Seleccionar";
            bttn_Seleccionar.Size = new Size(75, 23);
            bttn_Seleccionar.TabIndex = 10;
            bttn_Seleccionar.Text = "Consultar";
            bttn_Seleccionar.UseVisualStyleBackColor = true;
            bttn_Seleccionar.Click += bttn_Seleccionar_Click;
            // 
            // bttn_Cancel
            // 
            bttn_Cancel.Location = new Point(693, 116);
            bttn_Cancel.Name = "bttn_Cancel";
            bttn_Cancel.Size = new Size(75, 23);
            bttn_Cancel.TabIndex = 9;
            bttn_Cancel.Text = "Cancelar";
            bttn_Cancel.UseVisualStyleBackColor = true;
            bttn_Cancel.Click += bttn_Cancel_Click;
            // 
            // bttn_Delete
            // 
            bttn_Delete.Location = new Point(693, 87);
            bttn_Delete.Name = "bttn_Delete";
            bttn_Delete.Size = new Size(75, 23);
            bttn_Delete.TabIndex = 8;
            bttn_Delete.Text = "Eliminar";
            bttn_Delete.UseVisualStyleBackColor = true;
            bttn_Delete.Click += bttn_Delete_Click;
            // 
            // bttn_Modify
            // 
            bttn_Modify.Location = new Point(693, 58);
            bttn_Modify.Name = "bttn_Modify";
            bttn_Modify.Size = new Size(75, 23);
            bttn_Modify.TabIndex = 7;
            bttn_Modify.Text = "Modificar";
            bttn_Modify.UseVisualStyleBackColor = true;
            bttn_Modify.Click += bttn_Modify_Click;
            // 
            // bttn_Save
            // 
            bttn_Save.Location = new Point(693, 29);
            bttn_Save.Name = "bttn_Save";
            bttn_Save.Size = new Size(75, 23);
            bttn_Save.TabIndex = 6;
            bttn_Save.Text = "Agregar";
            bttn_Save.UseVisualStyleBackColor = true;
            bttn_Save.Click += bttn_Save_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(bttn_Seleccionar);
            Controls.Add(bttn_Cancel);
            Controls.Add(bttn_Delete);
            Controls.Add(bttn_Modify);
            Controls.Add(bttn_Save);
            Controls.Add(txt_Apellido);
            Controls.Add(label5);
            Controls.Add(txt_Calendario);
            Controls.Add(grid_Cliente);
            Controls.Add(txt_Mail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Tel);
            Controls.Add(label2);
            Controls.Add(txt_Name);
            Controls.Add(label1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)grid_Cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txt_Tel;
        private Label label2;
        private TextBox txt_Name;
        private Label label1;
        private TextBox txt_Mail;
        private Label label4;
        private DataGridView grid_Cliente;
        private MonthCalendar txt_Calendario;
        private TextBox txt_Apellido;
        private Label label5;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Ap;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn FechaNac;
        private Button bttn_Seleccionar;
        private Button bttn_Cancel;
        private Button bttn_Delete;
        private Button bttn_Modify;
        private Button bttn_Save;
    }
}