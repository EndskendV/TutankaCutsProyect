﻿namespace Tutankacuts
{
    partial class Ventas
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
            txt_Nombre = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            Combo_Cant = new ComboBox();
            lbl_ID = new Label();
            label7 = new Label();
            Combo_Product = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Grid_Cita).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(31, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Tel. Cliente";
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
            // 
            // bttn_Delete
            // 
            bttn_Delete.Location = new Point(695, 149);
            bttn_Delete.Name = "bttn_Delete";
            bttn_Delete.Size = new Size(75, 23);
            bttn_Delete.TabIndex = 3;
            bttn_Delete.Text = "Eliminar";
            bttn_Delete.UseVisualStyleBackColor = true;
            // 
            // bttn_Cancel
            // 
            bttn_Cancel.Location = new Point(695, 195);
            bttn_Cancel.Name = "bttn_Cancel";
            bttn_Cancel.Size = new Size(75, 23);
            bttn_Cancel.TabIndex = 4;
            bttn_Cancel.Text = "Cancelar";
            bttn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Grid_Cita
            // 
            Grid_Cita.BackgroundColor = Color.FromArgb(34, 33, 74);
            Grid_Cita.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Grid_Cita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Cita.Location = new Point(36, 252);
            Grid_Cita.Name = "Grid_Cita";
            Grid_Cita.RowTemplate.Height = 25;
            Grid_Cita.Size = new Size(734, 163);
            Grid_Cita.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(120, 88);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(164, 23);
            txt_Nombre.TabIndex = 6;
            txt_Nombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(46, 88);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(354, 38);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 13;
            label5.Text = "Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(354, 88);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 15;
            label6.Text = "Cantidad";
            label6.Click += label6_Click;
            // 
            // Combo_Cant
            // 
            Combo_Cant.FormattingEnabled = true;
            Combo_Cant.Items.AddRange(new object[] { "Corte de Pelo", "Corte de Pelo y Rasurado", "Tinte", "Tratamiento" });
            Combo_Cant.Location = new Point(453, 90);
            Combo_Cant.Name = "Combo_Cant";
            Combo_Cant.Size = new Size(164, 23);
            Combo_Cant.TabIndex = 22;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ID.ForeColor = Color.Gainsboro;
            lbl_ID.Location = new Point(487, 9);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(19, 21);
            lbl_ID.TabIndex = 54;
            lbl_ID.Text = "#";
            lbl_ID.UseMnemonic = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(453, 9);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 53;
            label7.Text = "ID:";
            label7.UseMnemonic = false;
            // 
            // Combo_Product
            // 
            Combo_Product.FormattingEnabled = true;
            Combo_Product.Location = new Point(453, 40);
            Combo_Product.Name = "Combo_Product";
            Combo_Product.Size = new Size(164, 23);
            Combo_Product.TabIndex = 55;
            // 
            Txt_Tel.Location = new Point(120, 39);
            Txt_Tel.Name = "Txt_Tel";
            Txt_Tel.Size = new Size(164, 23);
            Txt_Tel.TabIndex = 55;
            Txt_Tel.Tag = "";
            Txt_Tel.Text = "000-000-0000";
            Txt_Tel.TextAlign = HorizontalAlignment.Center;
            // 
            // Ventas
            // 
            AcceptButton = bttn_Save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
<<<<<<< HEAD
            Controls.Add(Combo_Product);
=======
            Controls.Add(Txt_Tel);
            Controls.Add(lbl_ID);
            Controls.Add(label7);
            Controls.Add(Combo_Cant);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txt_Nombre);
            Controls.Add(Grid_Cita);
            Controls.Add(bttn_Cancel);
            Controls.Add(bttn_Delete);
            Controls.Add(bttn_Modify);
            Controls.Add(bttn_Save);
            Controls.Add(label1);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
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
        private TextBox txt_Nombre;
        private Label label2;
        private Label label5;
        private Label label6;
        private ComboBox Combo_Barber;
 
        private ComboBox Combo_Cant;
        private Label lbl_ID;
        private Label label7;
        private ComboBox Combo_Product;
 
        private ComboBox Combo_Tipo;
        private Label lbl_ID;
        private Label label7;
        private TextBox Txt_Tel;
>>>>>>> c108d02bd921a5ed3346d4df70a30362671f61a6
    }
}