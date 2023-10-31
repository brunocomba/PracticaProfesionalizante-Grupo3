namespace Frontend
{
    partial class AltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCliente));
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblErrorDni = new Label();
            lblErrorTel = new Label();
            btnAgregar = new Button();
            txtTel = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-5, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 87);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "23";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(342, 36);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 4;
            label1.Text = "NUEVO CLIENTE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblErrorDni);
            groupBox2.Controls.Add(lblErrorTel);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtTel);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(215, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(475, 408);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorDni.ForeColor = Color.Red;
            lblErrorDni.Location = new Point(153, 223);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(0, 14);
            lblErrorDni.TabIndex = 32;
            // 
            // lblErrorTel
            // 
            lblErrorTel.AutoSize = true;
            lblErrorTel.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTel.ForeColor = Color.Red;
            lblErrorTel.Location = new Point(153, 280);
            lblErrorTel.Name = "lblErrorTel";
            lblErrorTel.Size = new Size(0, 14);
            lblErrorTel.TabIndex = 31;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(167, 332);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 38);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(153, 254);
            txtTel.MaxLength = 10;
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(223, 23);
            txtTel.TabIndex = 30;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(153, 145);
            txtApellido.MaxLength = 120;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(223, 23);
            txtApellido.TabIndex = 29;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(153, 197);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(223, 23);
            txtDNI.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(68, 262);
            label6.Name = "label6";
            label6.Size = new Size(54, 16);
            label6.TabIndex = 27;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 152);
            label5.Name = "label5";
            label5.Size = new Size(53, 16);
            label5.TabIndex = 26;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(68, 204);
            label4.Name = "label4";
            label4.Size = new Size(28, 16);
            label4.TabIndex = 25;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(68, 97);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 24;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 90);
            txtNombre.MaxLength = 120;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(153, 39);
            label2.Name = "label2";
            label2.Size = new Size(165, 18);
            label2.TabIndex = 22;
            label2.Text = "DATOS PERSONALES";
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(737, 516);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(119, 42);
            btnVolver.TabIndex = 31;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(925, 570);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AltaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += AltaCliente_FormClosing;
            Load += AltaCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private TextBox txtTel;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Button btnVolver;
        private Label lblErrorDni;
        private Label lblErrorTel;
    }
}