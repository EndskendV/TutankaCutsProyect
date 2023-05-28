namespace Tutankacuts
{
    partial class Ajustes
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
            txt_Name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_Apellido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_User = new Label();
            label7 = new Label();
            Combo_Horario = new ComboBox();
            Combo_Puesto = new ComboBox();
            txt_Sueldo = new TextBox();
            Grid_Empleado = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            TipoUsr = new DataGridViewTextBoxColumn();
            IdPuesto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            bttn_Seleccionar = new Button();
            bttn_Cancel = new Button();
            bttn_Delete = new Button();
            bttn_Modify = new Button();
            bttn_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid_Empleado).BeginInit();
            SuspendLayout();
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(135, 75);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(122, 23);
            txt_Name.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(48, 75);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(48, 137);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(135, 137);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(122, 23);
            txt_Apellido.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(48, 202);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 9;
            label3.Text = "Puesto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(283, 76);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 11;
            label4.Text = "Sueldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(283, 140);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 13;
            label5.Text = "Horario";
            // 
            // txt_User
            // 
            txt_User.AutoSize = true;
            txt_User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_User.ForeColor = Color.Gainsboro;
            txt_User.Location = new Point(157, 51);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(19, 21);
            txt_User.TabIndex = 34;
            txt_User.Text = "#";
            txt_User.UseMnemonic = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(123, 51);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 33;
            label7.Text = "ID:";
            label7.UseMnemonic = false;
            // 
            // Combo_Horario
            // 
            Combo_Horario.FormattingEnabled = true;
            Combo_Horario.Items.AddRange(new object[] { "11:00 am - 03:00 pm", "12:00 pm - 04:00 pm", "01:00 pm - 05:00 pm", "02:00 pm - 06:00 pm", "03:00 pm - 07:00 pm" });
            Combo_Horario.Location = new Point(359, 140);
            Combo_Horario.Name = "Combo_Horario";
            Combo_Horario.Size = new Size(164, 23);
            Combo_Horario.TabIndex = 37;
            Combo_Horario.SelectedIndexChanged += Combo_Horario_SelectedIndexChanged;
            // 
            // Combo_Puesto
            // 
            Combo_Puesto.FormattingEnabled = true;
            Combo_Puesto.Items.AddRange(new object[] { "Asistente", "Ayudante general", "Barbero", "Limpieza", "Recepcionista", "Admin" });
            Combo_Puesto.Location = new Point(123, 207);
            Combo_Puesto.Name = "Combo_Puesto";
            Combo_Puesto.Size = new Size(164, 23);
            Combo_Puesto.TabIndex = 36;
            // 
            // txt_Sueldo
            // 
            txt_Sueldo.Location = new Point(359, 81);
            txt_Sueldo.Name = "txt_Sueldo";
            txt_Sueldo.Size = new Size(164, 23);
            txt_Sueldo.TabIndex = 35;
            txt_Sueldo.TextChanged += txt_Sueldo_TextChanged;
            // 
            // Grid_Empleado
            // 
            Grid_Empleado.BackgroundColor = Color.FromArgb(34, 33, 74);
            Grid_Empleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Empleado.Columns.AddRange(new DataGridViewColumn[] { Usuario, TipoUsr, IdPuesto, Nombre, Apellido, Sueldo, Horario });
            Grid_Empleado.Location = new Point(12, 259);
            Grid_Empleado.Name = "Grid_Empleado";
            Grid_Empleado.RowTemplate.Height = 25;
            Grid_Empleado.Size = new Size(744, 179);
            Grid_Empleado.TabIndex = 38;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // TipoUsr
            // 
            TipoUsr.HeaderText = "Puesto";
            TipoUsr.Name = "TipoUsr";
            // 
            // IdPuesto
            // 
            IdPuesto.HeaderText = "ID Puesto";
            IdPuesto.Name = "IdPuesto";
            IdPuesto.ReadOnly = true;
            IdPuesto.Resizable = DataGridViewTriState.False;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "Sueldo";
            Sueldo.Name = "Sueldo";
            // 
            // Horario
            // 
            Horario.HeaderText = "Horario";
            Horario.Name = "Horario";
            // 
            // bttn_Seleccionar
            // 
            bttn_Seleccionar.Location = new Point(448, 230);
            bttn_Seleccionar.Name = "bttn_Seleccionar";
            bttn_Seleccionar.Size = new Size(75, 23);
            bttn_Seleccionar.TabIndex = 43;
            bttn_Seleccionar.Text = "Seleccion";
            bttn_Seleccionar.UseVisualStyleBackColor = true;
            bttn_Seleccionar.Click += bttn_Seleccionar_Click;
            // 
            // bttn_Cancel
            // 
            bttn_Cancel.Location = new Point(681, 168);
            bttn_Cancel.Name = "bttn_Cancel";
            bttn_Cancel.Size = new Size(75, 23);
            bttn_Cancel.TabIndex = 42;
            bttn_Cancel.Text = "Cancelar";
            bttn_Cancel.UseVisualStyleBackColor = true;
            bttn_Cancel.Click += bttn_Cancel_Click;
            // 
            // bttn_Delete
            // 
            bttn_Delete.Location = new Point(681, 139);
            bttn_Delete.Name = "bttn_Delete";
            bttn_Delete.Size = new Size(75, 23);
            bttn_Delete.TabIndex = 41;
            bttn_Delete.Text = "Eliminar";
            bttn_Delete.UseVisualStyleBackColor = true;
            bttn_Delete.Click += bttn_Delete_Click;
            // 
            // bttn_Modify
            // 
            bttn_Modify.Location = new Point(681, 110);
            bttn_Modify.Name = "bttn_Modify";
            bttn_Modify.Size = new Size(75, 23);
            bttn_Modify.TabIndex = 40;
            bttn_Modify.Text = "Guardar";
            bttn_Modify.UseVisualStyleBackColor = true;
            bttn_Modify.Click += bttn_Modify_Click;
            // 
            // bttn_Save
            // 
            bttn_Save.Enabled = false;
            bttn_Save.Location = new Point(681, 81);
            bttn_Save.Name = "bttn_Save";
            bttn_Save.Size = new Size(75, 23);
            bttn_Save.TabIndex = 39;
            bttn_Save.Text = "Agregar";
            bttn_Save.UseVisualStyleBackColor = true;
            bttn_Save.Visible = false;
            bttn_Save.Click += bttn_Save_Click;
            // 
            // Ajustes
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
            Controls.Add(Grid_Empleado);
            Controls.Add(Combo_Horario);
            Controls.Add(Combo_Puesto);
            Controls.Add(txt_Sueldo);
            Controls.Add(txt_User);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Apellido);
            Controls.Add(label1);
            Controls.Add(txt_Name);
            Name = "Ajustes";
            Text = "Ajustes";
            Load += Ajustes_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Empleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Name;
        private Label label1;
        private Label label2;
        private TextBox txt_Apellido;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txt_User;
        private Label label7;
        private ComboBox Combo_Horario;
        private ComboBox Combo_Puesto;
        private TextBox txt_Sueldo;
        private DataGridView Grid_Empleado;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn TipoUsr;
        private DataGridViewTextBoxColumn IdPuesto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Horario;
        private Button bttn_Seleccionar;
        private Button bttn_Cancel;
        private Button bttn_Delete;
        private Button bttn_Modify;
        private Button bttn_Save;
    }
}