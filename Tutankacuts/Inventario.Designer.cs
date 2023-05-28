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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            txt_Name = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label7 = new Label();
            txt_Cont = new TextBox();
            label8 = new Label();
            Combo_Item = new ComboBox();
            comboBox2 = new ComboBox();
            Name = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Contenido = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Proov = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(34, 33, 74);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Tipo, Contenido, Unidad, Costo, Proov });
            dataGridView1.Location = new Point(44, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(700, 179);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(669, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(669, 86);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(669, 131);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(669, 177);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Canecelar";
            button4.UseVisualStyleBackColor = true;
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
            txt_Name.TabIndex = 6;
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
            // textBox3
            // 
            textBox3.Location = new Point(428, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 10;
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
            // textBox4
            // 
            textBox4.Location = new Point(428, 65);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 12;
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
            txt_Cont.TabIndex = 14;
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
            // Combo_Item
            // 
            Combo_Item.FormattingEnabled = true;
            Combo_Item.Items.AddRange(new object[] { "Aceite hidratante", "Aceite para barba", "Cera", "Cepillo", "Crema de afeitar", "Gel", "Mascarilla", "Navajas", "Peine", "Pomada", "Shampoo" });
            Combo_Item.Location = new Point(138, 108);
            Combo_Item.Name = "Combo_Item";
            Combo_Item.Size = new Size(164, 23);
            Combo_Item.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Aceite hidratante", "Aceite para barba", "Cera", "Cepillo", "Crema de afeitar", "Gel", "Mascarilla", "Navajas", "Peine", "Pomada", "Shampoo" });
            comboBox2.Location = new Point(428, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 22;
            // 
            // Name
            // 
            Name.HeaderText = "Nombre";
            Name.Name = "Name";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Contenido
            // 
            Contenido.HeaderText = "Contenido";
            Contenido.Name = "Contenido";
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidades";
            Unidad.Name = "Unidad";
            // 
            // Costo
            // 
            Costo.HeaderText = "Precio";
            Costo.Name = "Costo";
            // 
            // Proov
            // 
            Proov.HeaderText = "Proveedor";
            Proov.Name = "Proov";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(Combo_Item);
            Controls.Add(label7);
            Controls.Add(txt_Cont);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Name);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox txt_Name;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label7;
        private TextBox txt_Cont;
        private Label label8;
        private ComboBox Combo_Item;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Contenido;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Proov;
    }
}