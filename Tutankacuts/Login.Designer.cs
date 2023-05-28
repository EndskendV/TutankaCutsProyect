namespace Tutankacuts
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label2 = new Label();
            txt_Pswrd = new TextBox();
            label1 = new Label();
            txt_User = new TextBox();
            Cancelar = new Button();
            Continue = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Pswrd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_User);
            panel1.Controls.Add(Cancelar);
            panel1.Controls.Add(Continue);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 252);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(217, 132);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // txt_Pswrd
            // 
            txt_Pswrd.Location = new Point(217, 160);
            txt_Pswrd.Name = "txt_Pswrd";
            txt_Pswrd.PasswordChar = '*';
            txt_Pswrd.Size = new Size(261, 23);
            txt_Pswrd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(217, 60);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // txt_User
            // 
            txt_User.Location = new Point(217, 88);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(261, 23);
            txt_User.TabIndex = 1;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(455, 216);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 4;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Continue
            // 
            Continue.BackColor = Color.White;
            Continue.Location = new Point(362, 216);
            Continue.Name = "Continue";
            Continue.Size = new Size(75, 23);
            Continue.TabIndex = 3;
            Continue.Text = "Continuar";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(19, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 195);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AcceptButton = Continue;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            CancelButton = Cancelar;
            ClientSize = new Size(568, 276);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Continue;
        private PictureBox pictureBox1;
        private TextBox txt_User;
        private Button Cancelar;
        private Label label2;
        private TextBox txt_Pswrd;
        private Label label1;
    }
}