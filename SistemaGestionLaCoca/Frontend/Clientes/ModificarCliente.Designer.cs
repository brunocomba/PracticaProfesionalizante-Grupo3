namespace Frontend
{
    partial class ModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCliente));
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnVolver = new Button();
            groupBox3 = new GroupBox();
            lblErrorDni = new Label();
            lblErrorTel = new Label();
            btnModificar = new Button();
            txtTEL = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-1, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(934, 85);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "23";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(303, 35);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 4;
            label1.Text = "MODIFICAR CLIENTE";
            // 
            // btnVolver
            // 
            btnVolver.Enabled = false;
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(745, 515);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(119, 43);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblErrorDni);
            groupBox3.Controls.Add(lblErrorTel);
            groupBox3.Controls.Add(btnModificar);
            groupBox3.Controls.Add(txtTEL);
            groupBox3.Controls.Add(txtApellido);
            groupBox3.Controls.Add(txtDNI);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(220, 107);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(475, 408);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
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
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(167, 332);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(129, 38);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtTEL
            // 
            txtTEL.Location = new Point(153, 254);
            txtTEL.MaxLength = 10;
            txtTEL.Name = "txtTEL";
            txtTEL.Size = new Size(202, 23);
            txtTEL.TabIndex = 30;
            txtTEL.Validating += txtTEL_Validating;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(153, 145);
            txtApellido.MaxLength = 120;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(202, 23);
            txtApellido.TabIndex = 29;
            txtApellido.Validating += txtApellido_Validating;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(153, 197);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(202, 23);
            txtDNI.TabIndex = 28;
            txtDNI.Validating += txtDNI_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(68, 262);
            label9.Name = "label9";
            label9.Size = new Size(54, 16);
            label9.TabIndex = 27;
            label9.Text = "Telefono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(71, 153);
            label10.Name = "label10";
            label10.Size = new Size(53, 16);
            label10.TabIndex = 26;
            label10.Text = "Apellido";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(94, 205);
            label11.Name = "label11";
            label11.Size = new Size(28, 16);
            label11.TabIndex = 25;
            label11.Text = "DNI";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(70, 98);
            label12.Name = "label12";
            label12.Size = new Size(52, 16);
            label12.TabIndex = 24;
            label12.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 90);
            txtNombre.MaxLength = 120;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(202, 23);
            txtNombre.TabIndex = 21;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(153, 33);
            label2.Name = "label2";
            label2.Size = new Size(177, 36);
            label2.TabIndex = 22;
            label2.Text = "DATOS PERSONALES A\r\nMODIFICAR";
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(925, 570);
            Controls.Add(groupBox3);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ModificarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnVolver;
        private GroupBox groupBox3;
        private Label lblErrorDni;
        private Label lblErrorTel;
        private Button btnModificar;
        private TextBox txtTEL;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtNombre;
        private Label label2;
    }
}