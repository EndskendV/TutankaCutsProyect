namespace Tutankacuts
{
    partial class Citas
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
            label1 = new Label();
            bttn_Save = new Button();
            bttn_Modify = new Button();
            bttn_Delete = new Button();
            bttn_Cancel = new Button();
            Grid_Cita = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Barber = new DataGridViewTextBoxColumn();
            Corte = new DataGridViewTextBoxColumn();
            Asist = new DataGridViewTextBoxColumn();
            CitaNum = new DataGridViewTextBoxColumn();
            txt_Name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Combo_Hrs = new ComboBox();
            txt_Calendario = new DateTimePicker();
            Combo_Barber = new ComboBox();
            Combo_Tipo = new ComboBox();
            Combo_asist = new ComboBox();
            label8 = new Label();
            bttn_Consult = new Button();
            bttn_Seleccionar = new Button();
            txt_Tel = new TextBox();
            lbl_ID = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_Cita).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(46, 90);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // bttn_Save
            // 
            bttn_Save.Location = new Point(695, 39);
            bttn_Save.Name = "bttn_Save";
            bttn_Save.Size = new Size(75, 23);
            bttn_Save.TabIndex = 1;
            bttn_Save.Text = "Agregar";
            bttn_Save.UseVisualStyleBackColor = true;
            bttn_Save.Click += bttn_Save_Click;
            // 
            // bttn_Modify
            // 
            bttn_Modify.Location = new Point(695, 91);
            bttn_Modify.Name = "bttn_Modify";
            bttn_Modify.Size = new Size(75, 23);
            bttn_Modify.TabIndex = 2;
            bttn_Modify.Text = "Modificar";
            bttn_Modify.UseVisualStyleBackColor = true;
            bttn_Modify.Click += bttn_Modify_Click;
            // 
            // bttn_Delete
            // 
            bttn_Delete.Location = new Point(695, 141);
            bttn_Delete.Name = "bttn_Delete";
            bttn_Delete.Size = new Size(75, 23);
            bttn_Delete.TabIndex = 3;
            bttn_Delete.Text = "Cancelar";
            bttn_Delete.UseVisualStyleBackColor = true;
            bttn_Delete.Click += bttn_Delete_Click;
            // 
            // bttn_Cancel
            // 
            bttn_Cancel.Location = new Point(695, 195);
            bttn_Cancel.Name = "bttn_Cancel";
            bttn_Cancel.Size = new Size(75, 23);
            bttn_Cancel.TabIndex = 4;
            bttn_Cancel.Text = "Salir";
            bttn_Cancel.UseVisualStyleBackColor = true;
            bttn_Cancel.Click += bttn_Cancel_Click;
            // 
            // Grid_Cita
            // 
            Grid_Cita.BackgroundColor = Color.FromArgb(34, 33, 74);
            Grid_Cita.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Grid_Cita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Cita.Columns.AddRange(new DataGridViewColumn[] { Nombre, Tel, Fecha, Hora, Barber, Corte, Asist, CitaNum });
            Grid_Cita.Location = new Point(46, 275);
            Grid_Cita.Name = "Grid_Cita";
            Grid_Cita.RowTemplate.Height = 25;
            Grid_Cita.Size = new Size(734, 163);
            Grid_Cita.TabIndex = 50;
            Grid_Cita.KeyPress += Grid_Cita_KeyPress;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Tel
            // 
            Tel.HeaderText = "Telefono";
            Tel.Name = "Tel";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.Width = 80;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.Width = 50;
            // 
            // Barber
            // 
            Barber.HeaderText = "Barbero";
            Barber.Name = "Barber";
            // 
            // Corte
            // 
            Corte.HeaderText = "Corte";
            Corte.Name = "Corte";
            // 
            // Asist
            // 
            Asist.HeaderText = "Asistencia";
            Asist.Name = "Asist";
            Asist.Width = 70;
            // 
            // CitaNum
            // 
            CitaNum.HeaderText = "Cita Num";
            CitaNum.Name = "CitaNum";
            CitaNum.ReadOnly = true;
            CitaNum.Width = 40;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(120, 92);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(164, 23);
            txt_Name.TabIndex = 2;
            txt_Name.TextAlign = HorizontalAlignment.Center;
            txt_Name.TextChanged += txt_Name_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(46, 38);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 7;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(46, 143);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 9;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(46, 194);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 11;
            label4.Text = "Hora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(354, 38);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 13;
            label5.Text = "Barbero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(354, 88);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 15;
            label6.Text = "Tipo";
            // 
            // Combo_Hrs
            // 
            Combo_Hrs.FormattingEnabled = true;
            Combo_Hrs.Items.AddRange(new object[] { "11:00 am", "12:00 pm", "01:00 pm", "02:00 pm", "03:00 pm", "04:00 pm", "05:00 pm", "06:00 pm", "07:00 pm" });
            Combo_Hrs.Location = new Point(120, 195);
            Combo_Hrs.Name = "Combo_Hrs";
            Combo_Hrs.Size = new Size(164, 23);
            Combo_Hrs.TabIndex = 4;
            // 
            // txt_Calendario
            // 
            txt_Calendario.Format = DateTimePickerFormat.Short;
            txt_Calendario.Location = new Point(120, 145);
            txt_Calendario.Name = "txt_Calendario";
            txt_Calendario.Size = new Size(164, 23);
            txt_Calendario.TabIndex = 3;
            // 
            // Combo_Barber
            // 
            Combo_Barber.FormattingEnabled = true;
            Combo_Barber.Location = new Point(453, 40);
            Combo_Barber.Name = "Combo_Barber";
            Combo_Barber.Size = new Size(164, 23);
            Combo_Barber.TabIndex = 5;
            // 
            // Combo_Tipo
            // 
            Combo_Tipo.FormattingEnabled = true;
            Combo_Tipo.Items.AddRange(new object[] { "Corte de Pelo", "Corte de Pelo y Rasurado", "Tinte", "Tratamiento" });
            Combo_Tipo.Location = new Point(453, 90);
            Combo_Tipo.Name = "Combo_Tipo";
            Combo_Tipo.Size = new Size(164, 23);
            Combo_Tipo.TabIndex = 6;
            // 
            // Combo_asist
            // 
            Combo_asist.FormattingEnabled = true;
            Combo_asist.Items.AddRange(new object[] { "No", "Si", "Retraso", "Cancelo" });
            Combo_asist.Location = new Point(453, 149);
            Combo_asist.Name = "Combo_asist";
            Combo_asist.Size = new Size(164, 23);
            Combo_asist.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(354, 146);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 25;
            label8.Text = "Asistio";
            // 
            // bttn_Consult
            // 
            bttn_Consult.Location = new Point(363, 214);
            bttn_Consult.Name = "bttn_Consult";
            bttn_Consult.Size = new Size(75, 23);
            bttn_Consult.TabIndex = 26;
            bttn_Consult.Text = "Consultar";
            bttn_Consult.UseVisualStyleBackColor = true;
            bttn_Consult.Click += bttn_Consult_Click;
            // 
            // bttn_Seleccionar
            // 
            bttn_Seleccionar.Location = new Point(453, 214);
            bttn_Seleccionar.Name = "bttn_Seleccionar";
            bttn_Seleccionar.Size = new Size(75, 23);
            bttn_Seleccionar.TabIndex = 27;
            bttn_Seleccionar.Text = "Seleccion";
            bttn_Seleccionar.UseVisualStyleBackColor = true;
            bttn_Seleccionar.Click += bttn_Seleccionar_Click;
            // 
            // txt_Tel
            // 
            txt_Tel.Location = new Point(120, 40);
            txt_Tel.Name = "txt_Tel";
            txt_Tel.Size = new Size(164, 23);
            txt_Tel.TabIndex = 1;
            txt_Tel.Tag = "";
            txt_Tel.Text = "000-000-0000";
            txt_Tel.TextAlign = HorizontalAlignment.Center;
            txt_Tel.TextChanged += txt_Tel_TextChanged;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ID.ForeColor = Color.Gainsboro;
            lbl_ID.Location = new Point(80, 251);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(19, 21);
            lbl_ID.TabIndex = 52;
            lbl_ID.Text = "#";
            lbl_ID.UseMnemonic = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(46, 251);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 51;
            label7.Text = "ID:";
            label7.UseMnemonic = false;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ID);
            Controls.Add(label7);
            Controls.Add(txt_Tel);
            Controls.Add(bttn_Seleccionar);
            Controls.Add(bttn_Consult);
            Controls.Add(label8);
            Controls.Add(Combo_asist);
            Controls.Add(Combo_Tipo);
            Controls.Add(Combo_Barber);
            Controls.Add(txt_Calendario);
            Controls.Add(Combo_Hrs);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Name);
            Controls.Add(Grid_Cita);
            Controls.Add(bttn_Cancel);
            Controls.Add(bttn_Delete);
            Controls.Add(bttn_Modify);
            Controls.Add(bttn_Save);
            Controls.Add(label1);
            Name = "Citas";
            Text = "Citas";
            Load += Citas_Load;
            KeyDown += Citas_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Grid_Cita).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bttn_Save;
        private Button bttn_Modify;
        private Button bttn_Delete;
        private Button bttn_Cancel;
        private DataGridView Grid_Cita;
        private TextBox txt_Name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox Combo_Hrs;
        private DateTimePicker txt_Calendario;
        private ComboBox Combo_Barber;
        private ComboBox Combo_Tipo;
        private ComboBox Combo_asist;
        private Label label8;
        private Button bttn_Consult;
        private Button bttn_Seleccionar;
        private TextBox txt_Tel;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Barber;
        private DataGridViewTextBoxColumn Corte;
        private DataGridViewTextBoxColumn Asist;
        private DataGridViewTextBoxColumn CitaNum;
        private Label lbl_ID;
        private Label label7;
    }
}