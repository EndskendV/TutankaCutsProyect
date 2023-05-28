namespace Tutankacuts
{
    partial class Empleados
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
            txt_Passwrd = new TextBox();
            label2 = new Label();
            txt_User = new TextBox();
            label1 = new Label();
            Grid_Empleado = new DataGridView();
            label4 = new Label();
            lbl_ID = new Label();
            bttn_Seleccionar = new Button();
            bttn_Cancel = new Button();
            bttn_Delete = new Button();
            bttn_Modify = new Button();
            bttn_Save = new Button();
            Usuario = new DataGridViewTextBoxColumn();
            TipoUsr = new DataGridViewTextBoxColumn();
            IdPuesto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Grid_Empleado).BeginInit();
            SuspendLayout();
            // 
            // txt_Passwrd
            // 
            txt_Passwrd.Location = new Point(136, 122);
            txt_Passwrd.Name = "txt_Passwrd";
            txt_Passwrd.PasswordChar = '*';
            txt_Passwrd.Size = new Size(164, 23);
            txt_Passwrd.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(41, 120);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 15;
            label2.Text = "Contraseña";
            // 
            // txt_User
            // 
            txt_User.Location = new Point(136, 79);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(164, 23);
            txt_User.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(66, 76);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 13;
            label1.Text = "Usuario";
            label1.UseMnemonic = false;
            // 
            // Grid_Empleado
            // 
            Grid_Empleado.BackgroundColor = Color.FromArgb(34, 33, 74);
            Grid_Empleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Empleado.Columns.AddRange(new DataGridViewColumn[] { Usuario, TipoUsr, IdPuesto, Nombre, Apellido, Sueldo, Horario });
            Grid_Empleado.Location = new Point(52, 236);
            Grid_Empleado.Name = "Grid_Empleado";
            Grid_Empleado.RowTemplate.Height = 25;
            Grid_Empleado.Size = new Size(715, 179);
            Grid_Empleado.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(136, 55);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 31;
            label4.Text = "ID:";
            label4.UseMnemonic = false;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ID.ForeColor = Color.Gainsboro;
            lbl_ID.Location = new Point(170, 55);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(19, 21);
            lbl_ID.TabIndex = 32;
            lbl_ID.Text = "#";
            lbl_ID.UseMnemonic = false;
            // 
            // bttn_Seleccionar
            // 
            bttn_Seleccionar.Location = new Point(435, 203);
            bttn_Seleccionar.Name = "bttn_Seleccionar";
            bttn_Seleccionar.Size = new Size(75, 23);
            bttn_Seleccionar.TabIndex = 37;
            bttn_Seleccionar.Text = "Seleccion";
            bttn_Seleccionar.UseVisualStyleBackColor = true;
            bttn_Seleccionar.Click += bttn_Seleccionar_Click;
            // 
            // bttn_Cancel
            // 
            bttn_Cancel.Location = new Point(677, 161);
            bttn_Cancel.Name = "bttn_Cancel";
            bttn_Cancel.Size = new Size(75, 23);
            bttn_Cancel.TabIndex = 36;
            bttn_Cancel.Text = "Cancelar";
            bttn_Cancel.UseVisualStyleBackColor = true;
            bttn_Cancel.Click += bttn_Cancel_Click;
            // 
            // bttn_Delete
            // 
            bttn_Delete.Location = new Point(677, 132);
            bttn_Delete.Name = "bttn_Delete";
            bttn_Delete.Size = new Size(75, 23);
            bttn_Delete.TabIndex = 35;
            bttn_Delete.Text = "Eliminar";
            bttn_Delete.UseVisualStyleBackColor = true;
            bttn_Delete.Click += bttn_Delete_Click;
            // 
            // bttn_Modify
            // 
            bttn_Modify.Location = new Point(677, 103);
            bttn_Modify.Name = "bttn_Modify";
            bttn_Modify.Size = new Size(75, 23);
            bttn_Modify.TabIndex = 34;
            bttn_Modify.Text = "Modificar";
            bttn_Modify.UseVisualStyleBackColor = true;
            bttn_Modify.Click += bttn_Modify_Click;
            // 
            // bttn_Save
            // 
            bttn_Save.Location = new Point(677, 74);
            bttn_Save.Name = "bttn_Save";
            bttn_Save.Size = new Size(75, 23);
            bttn_Save.TabIndex = 33;
            bttn_Save.Text = "Agregar";
            bttn_Save.UseVisualStyleBackColor = true;
            bttn_Save.Click += bttn_Save_Click;
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
            IdPuesto.Width = 70;
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
            // Empleados
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
            Controls.Add(lbl_ID);
            Controls.Add(label4);
            Controls.Add(Grid_Empleado);
            Controls.Add(txt_Passwrd);
            Controls.Add(label2);
            Controls.Add(txt_User);
            Controls.Add(label1);
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Empleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Passwrd;
        private Label label2;
        private TextBox txt_User;
        private Label label1;
        private DataGridView Grid_Empleado;
        private Label label4;
        private Label lbl_ID;
        private Button bttn_Seleccionar;
        private Button bttn_Cancel;
        private Button bttn_Delete;
        private Button bttn_Modify;
        private Button bttn_Save;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn TipoUsr;
        private DataGridViewTextBoxColumn IdPuesto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Horario;
    }
}