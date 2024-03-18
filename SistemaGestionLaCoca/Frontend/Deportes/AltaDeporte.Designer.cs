namespace Frontend.Deportes
{
    partial class AltaDeporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaDeporte));
            btnVolver = new Button();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            txtCantJugadores = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(737, 516);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(119, 43);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtCantJugadores);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(215, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(475, 341);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(179, 239);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 38);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantJugadores
            // 
            txtCantJugadores.Location = new Point(153, 161);
            txtCantJugadores.MaxLength = 120;
            txtCantJugadores.Name = "txtCantJugadores";
            txtCantJugadores.Size = new Size(223, 23);
            txtCantJugadores.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 152);
            label5.Name = "label5";
            label5.Size = new Size(66, 32);
            label5.TabIndex = 26;
            label5.Text = "Cantidad\r\nJugadores\r\n";
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
            label2.Location = new Point(171, 40);
            label2.Name = "label2";
            label2.Size = new Size(137, 18);
            label2.TabIndex = 22;
            label2.Text = "DATOS DEPORTE";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-5, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 88);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "23";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(391, 32);
            label1.TabIndex = 4;
            label1.Text = "AGREGAR NUEVO DEPORTE";
            // 
            // AltaDeporte
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
            Name = "AltaDeporte";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += AltaDeporte_FormClosing;
            Load += AltaDeporte_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox2;
        private Label lblErrorDni;
        private Label lblErrorTel;
        private Button btnAgregar;
        private TextBox txtTel;
        private TextBox txtCantJugadores;
        private TextBox txtDNI;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
    }
}