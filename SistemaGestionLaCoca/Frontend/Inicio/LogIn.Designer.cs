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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            groupBox1 = new GroupBox();
            iconoPass = new PictureBox();
            iconoUsuario = new PictureBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            button1 = new Button();
            btnContinuar = new Button();
            txtContrasenia = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoUsuario).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(iconoPass);
            groupBox1.Controls.Add(iconoUsuario);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnContinuar);
            groupBox1.Controls.Add(txtContrasenia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(238, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 426);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // iconoPass
            // 
            iconoPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconoPass.Image = (Image)resources.GetObject("iconoPass.Image");
            iconoPass.Location = new Point(86, 139);
            iconoPass.Name = "iconoPass";
            iconoPass.Size = new Size(23, 26);
            iconoPass.TabIndex = 10;
            iconoPass.TabStop = false;
            // 
            // iconoUsuario
            // 
            iconoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconoUsuario.Image = (Image)resources.GetObject("iconoUsuario.Image");
            iconoUsuario.Location = new Point(86, 72);
            iconoUsuario.Name = "iconoUsuario";
            iconoUsuario.Size = new Size(23, 32);
            iconoUsuario.TabIndex = 9;
            iconoUsuario.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(213, 177);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 18);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(105, 320);
            label5.Name = "label5";
            label5.Size = new Size(206, 16);
            label5.TabIndex = 7;
            label5.Text = "¿No tienes una cuenta registrada?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(140, 352);
            button1.Name = "button1";
            button1.Size = new Size(128, 33);
            button1.TabIndex = 4;
            button1.Text = "CREAR CUENTA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnContinuar.FlatAppearance.BorderSize = 2;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = Color.White;
            btnContinuar.Location = new Point(140, 225);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(128, 32);
            btnContinuar.TabIndex = 3;
            btnContinuar.Text = "ENTRAR";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(120, 139);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(214, 23);
            txtContrasenia.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(152, 19);
            label2.Name = "label2";
            label2.Size = new Size(121, 16);
            label2.TabIndex = 1;
            label2.Text = "INICIO DE SESION";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(120, 72);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(431, 32);
            label1.TabIndex = 6;
            label1.Text = "GESTION DE TURNOS LA COCA";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(-1, -12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(933, 86);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(925, 570);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LogIn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconoPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoUsuario).EndInit();
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
        private Label label2;
        private TextBox txtUsuario;
        private Label label1;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private PictureBox iconoUsuario;
        private PictureBox iconoPass;
        private ToolTip toolTip1;
    }
}