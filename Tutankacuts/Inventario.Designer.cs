namespace Tutankacuts
{
    partial class Inventario
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
            txt_Name = new TextBox();
            label2 = new Label();
            txt_Price = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            txt_Cont = new TextBox();
            label8 = new Label();
            Combo_Tipo = new ComboBox();
            Combo_Proov = new ComboBox();
            Grid_Product = new DataGridView();
            bttn_Cancel = new Button();
            bttn_Delete = new Button();
            bttn_Modify = new Button();
            bttn_Save = new Button();
            Combo_Units = new ComboBox();
            lbl_ID = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_Product).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(50, 62);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(138, 65);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(164, 23);
            txt_Name.TabIndex = 1;
            txt_Name.TextChanged += txt_Name_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(340, 151);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 7;
            label2.Text = "Proveedor";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(428, 108);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(164, 23);
            txt_Price.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(340, 106);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 9;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(340, 63);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 11;
            label4.Text = "Unidades";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(50, 106);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 15;
            label7.Text = "Tipo";
            // 
            // txt_Cont
            // 
            txt_Cont.Location = new Point(138, 153);
            txt_Cont.Name = "txt_Cont";
            txt_Cont.Size = new Size(164, 23);
            txt_Cont.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(50, 151);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 13;
            label8.Text = "Contenido";
            // 
            // Combo_Tipo
            // 
            Combo_Tipo.FormattingEnabled = true;
            Combo_Tipo.Items.AddRange(new object[] { "Aceite hidratante", "Aceite para barba", "Cera", "Cepillo", "Crema de afeitar", "Gel", "Mascarilla", "Navajas", "Peine", "Pomada", "Shampoo" });
            Combo_Tipo.Location = new Point(138, 108);
            Combo_Tipo.Name = "Combo_Tipo";
            Combo_Tipo.Size = new Size(164, 23);
            Combo_Tipo.TabIndex = 2;
            // 
            // Combo_Proov
            // 
            Combo_Proov.FormattingEnabled = true;
            Combo_Proov.Items.AddRange(new object[] { "P1", "P2", "P3", "P4" });
            Combo_Proov.Location = new Point(428, 153);
            Combo_Proov.Name = "Combo_Proov";
            Combo_Proov.Size = new Size(164, 23);
            Combo_Proov.TabIndex = 6;
            // 
            // Grid_Product
            // 
            Grid_Product.BackgroundColor = Color.FromArgb(34, 33, 74);
            Grid_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Product.Location = new Point(50, 205);
            Grid_Product.Name = "Grid_Product";
            Grid_Product.RowTemplate.Height = 25;
            Grid_Product.Size = new Size(700, 233);
            Grid_Product.TabIndex = 31;
            Grid_Product.CellContentClick += Grid_Product_CellContentClick;
            // 
            // bttn_Cancel
            // 
            bttn_Cancel.Location = new Point(681, 153);
            bttn_Cancel.Name = "bttn_Cancel";
            bttn_Cancel.Size = new Size(75, 23);
            bttn_Cancel.TabIndex = 35;
            bttn_Cancel.Text = "Cancelar";
            bttn_Cancel.UseVisualStyleBackColor = true;
            bttn_Cancel.Click += bttn_Cancel_Click;
            // 
            // bttn_Delete
            // 
            bttn_Delete.Location = new Point(681, 107);
            bttn_Delete.Name = "bttn_Delete";
            bttn_Delete.Size = new Size(75, 23);
            bttn_Delete.TabIndex = 34;
            bttn_Delete.Text = "Eliminar";
            bttn_Delete.UseVisualStyleBackColor = true;
            bttn_Delete.Click += bttn_Delete_Click;
            // 
            // bttn_Modify
            // 
            bttn_Modify.Location = new Point(681, 73);
            bttn_Modify.Name = "bttn_Modify";
            bttn_Modify.Size = new Size(75, 23);
            bttn_Modify.TabIndex = 33;
            bttn_Modify.Text = "Modificar";
            bttn_Modify.UseVisualStyleBackColor = true;
            bttn_Modify.Click += bttn_Modify_Click;
            // 
            // bttn_Save
            // 
            bttn_Save.Location = new Point(681, 44);
            bttn_Save.Name = "bttn_Save";
            bttn_Save.Size = new Size(75, 23);
            bttn_Save.TabIndex = 32;
            bttn_Save.Text = "Agregar";
            bttn_Save.UseVisualStyleBackColor = true;
            bttn_Save.Click += bttn_Save_Click;
            // 
            // Combo_Units
            // 
            Combo_Units.FormattingEnabled = true;
            Combo_Units.Items.AddRange(new object[] { "P1", "P2", "P3", "P4" });
            Combo_Units.Location = new Point(428, 65);
            Combo_Units.Name = "Combo_Units";
            Combo_Units.Size = new Size(164, 23);
            Combo_Units.TabIndex = 4;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ID.ForeColor = Color.Gainsboro;
            lbl_ID.Location = new Point(172, 41);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(19, 21);
            lbl_ID.TabIndex = 54;
            lbl_ID.Text = "#";
            lbl_ID.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(138, 41);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 53;
            label5.Text = "ID:";
            label5.UseMnemonic = false;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ID);
            Controls.Add(label5);
            Controls.Add(Combo_Units);
            Controls.Add(bttn_Cancel);
            Controls.Add(bttn_Delete);
            Controls.Add(bttn_Modify);
            Controls.Add(bttn_Save);
            Controls.Add(Grid_Product);
            Controls.Add(Combo_Proov);
            Controls.Add(Combo_Tipo);
            Controls.Add(label7);
            Controls.Add(txt_Cont);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txt_Price);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Name);
            Controls.Add(label1);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_Name;
        private Label label2;
        private TextBox txt_Price;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox txt_Cont;
        private Label label8;
        private ComboBox Combo_Tipo;
        private ComboBox Combo_Proov;
        private DataGridView Grid_Product;
        private Button bttn_Cancel;
        private Button bttn_Delete;
        private Button bttn_Modify;
        private Button bttn_Save;
        private ComboBox Combo_Units;
        private Label lbl_ID;
        private Label label5;
    }
}