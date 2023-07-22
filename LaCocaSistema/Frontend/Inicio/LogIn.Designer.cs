namespace FrontEnd
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            button1 = new Button();
            btnContinuar = new Button();
            txtContrasenia = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnContinuar);
            groupBox1.Controls.Add(txtContrasenia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(238, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 349);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(152, 151);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 18);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(62, 268);
            label5.Name = "label5";
            label5.Size = new Size(197, 15);
            label5.TabIndex = 7;
            label5.Text = "¿No tienes una cuenta registrada?";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(103, 295);
            button1.Name = "button1";
            button1.Size = new Size(110, 31);
            button1.TabIndex = 6;
            button1.Text = "Crear cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.FlatAppearance.BorderSize = 2;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = Color.White;
            btnContinuar.Location = new Point(103, 188);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(110, 32);
            btnContinuar.TabIndex = 4;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(93, 112);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(180, 23);
            txtContrasenia.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 120);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(93, 19);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "INICIO DE SESION";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(93, 56);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 23);
            txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 64);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 34);
            label1.Name = "label1";
            label1.Size = new Size(429, 32);
            label1.TabIndex = 6;
            label1.Text = "GESTION DE TURNOS LA COCA";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(-1, -12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(812, 86);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(804, 461);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LogIn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Button button1;
        private Button btnContinuar;
        private TextBox txtContrasenia;
        private Label label4;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private Label label1;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
    }
}