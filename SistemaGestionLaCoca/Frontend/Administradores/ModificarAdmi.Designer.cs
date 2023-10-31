namespace Frontend
{
    partial class ModificarAdmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAdmi));
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnVolver = new Button();
            groupBox2 = new GroupBox();
            txtConfiContra = new TextBox();
            checkBoXMostrarContra = new CheckBox();
            lblErrorPass = new Label();
            label10 = new Label();
            btnCrear = new Button();
            label9 = new Label();
            txtContra = new TextBox();
            txtUser = new TextBox();
            label4 = new Label();
            label3 = new Label();
            DatosPers = new GroupBox();
            cmboxAdm = new ComboBox();
            label11 = new Label();
            txtDNI = new TextBox();
            lblErrorApellido = new Label();
            lblErrorDni = new Label();
            lblErrorTel = new Label();
            label8 = new Label();
            txtApellido = new TextBox();
            txtTel = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            DatosPers.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-2, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(931, 88);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(277, 32);
            label1.Name = "label1";
            label1.Size = new Size(403, 32);
            label1.TabIndex = 4;
            label1.Text = "MODIFICAR ADMINISTRADOR";
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(703, 519);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(134, 39);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtConfiContra);
            groupBox2.Controls.Add(checkBoXMostrarContra);
            groupBox2.Controls.Add(lblErrorPass);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnCrear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtContra);
            groupBox2.Controls.Add(txtUser);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(464, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 407);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // txtConfiContra
            // 
            txtConfiContra.ForeColor = Color.Black;
            txtConfiContra.Location = new Point(159, 189);
            txtConfiContra.Name = "txtConfiContra";
            txtConfiContra.PasswordChar = '*';
            txtConfiContra.Size = new Size(212, 23);
            txtConfiContra.TabIndex = 7;
            // 
            // checkBoXMostrarContra
            // 
            checkBoXMostrarContra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoXMostrarContra.AutoSize = true;
            checkBoXMostrarContra.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoXMostrarContra.ForeColor = Color.White;
            checkBoXMostrarContra.Location = new Point(250, 241);
            checkBoXMostrarContra.Name = "checkBoXMostrarContra";
            checkBoXMostrarContra.Size = new Size(121, 18);
            checkBoXMostrarContra.TabIndex = 22;
            checkBoXMostrarContra.Text = "Mostrar contraseña";
            checkBoXMostrarContra.UseVisualStyleBackColor = true;
            checkBoXMostrarContra.CheckedChanged += checkBoXMostrarContra_CheckedChanged_1;
            // 
            // lblErrorPass
            // 
            lblErrorPass.AutoSize = true;
            lblErrorPass.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPass.ForeColor = Color.Red;
            lblErrorPass.Location = new Point(159, 212);
            lblErrorPass.Name = "lblErrorPass";
            lblErrorPass.Size = new Size(0, 14);
            lblErrorPass.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(45, 179);
            label10.Name = "label10";
            label10.Size = new Size(71, 32);
            label10.TabIndex = 19;
            label10.Text = "Confirmar \r\ncontraseña";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(26, 32, 40);
            btnCrear.FlatAppearance.BorderSize = 2;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(159, 290);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(121, 40);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "MODIFICAR";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(138, 34);
            label9.Name = "label9";
            label9.Size = new Size(131, 18);
            label9.TabIndex = 18;
            label9.Text = "DATOS USUARIO";
            // 
            // txtContra
            // 
            txtContra.BackColor = SystemColors.Window;
            txtContra.Location = new Point(159, 137);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(212, 23);
            txtContra.TabIndex = 6;
            // 
            // txtUser
            // 
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(159, 85);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(212, 23);
            txtUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 139);
            label4.Name = "label4";
            label4.Size = new Size(73, 16);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 87);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // DatosPers
            // 
            DatosPers.Controls.Add(cmboxAdm);
            DatosPers.Controls.Add(label11);
            DatosPers.Controls.Add(txtDNI);
            DatosPers.Controls.Add(lblErrorApellido);
            DatosPers.Controls.Add(lblErrorDni);
            DatosPers.Controls.Add(lblErrorTel);
            DatosPers.Controls.Add(label8);
            DatosPers.Controls.Add(txtApellido);
            DatosPers.Controls.Add(txtTel);
            DatosPers.Controls.Add(label7);
            DatosPers.Controls.Add(label6);
            DatosPers.Controls.Add(label5);
            DatosPers.Controls.Add(label2);
            DatosPers.Controls.Add(txtNombre);
            DatosPers.Location = new Point(12, 85);
            DatosPers.Name = "DatosPers";
            DatosPers.Size = new Size(446, 407);
            DatosPers.TabIndex = 23;
            DatosPers.TabStop = false;
            // 
            // cmboxAdm
            // 
            cmboxAdm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxAdm.FormattingEnabled = true;
            cmboxAdm.Location = new Point(160, 87);
            cmboxAdm.Name = "cmboxAdm";
            cmboxAdm.Size = new Size(212, 23);
            cmboxAdm.TabIndex = 22;
            cmboxAdm.SelectedIndexChanged += cmboxAdm_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(50, 87);
            label11.Name = "label11";
            label11.Size = new Size(87, 32);
            label11.TabIndex = 21;
            label11.Text = "Administrador\r\na modificar";
            // 
            // txtDNI
            // 
            txtDNI.ForeColor = Color.Black;
            txtDNI.Location = new Point(160, 241);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(212, 23);
            txtDNI.TabIndex = 3;
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(123, 189);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(0, 13);
            lblErrorApellido.TabIndex = 20;
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorDni.ForeColor = Color.Red;
            lblErrorDni.Location = new Point(160, 264);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(0, 13);
            lblErrorDni.TabIndex = 19;
            // 
            // lblErrorTel
            // 
            lblErrorTel.AutoSize = true;
            lblErrorTel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTel.ForeColor = Color.Red;
            lblErrorTel.Location = new Point(160, 320);
            lblErrorTel.Name = "lblErrorTel";
            lblErrorTel.Size = new Size(0, 13);
            lblErrorTel.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(148, 34);
            label8.Name = "label8";
            label8.Size = new Size(165, 18);
            label8.TabIndex = 17;
            label8.Text = "DATOS PERSONALES";
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(160, 189);
            txtApellido.MaxLength = 40;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(212, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtTel
            // 
            txtTel.ForeColor = Color.Black;
            txtTel.Location = new Point(160, 294);
            txtTel.MaxLength = 10;
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(212, 23);
            txtTel.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(50, 196);
            label7.Name = "label7";
            label7.Size = new Size(53, 16);
            label7.TabIndex = 9;
            label7.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(75, 248);
            label6.Name = "label6";
            label6.Size = new Size(28, 16);
            label6.TabIndex = 8;
            label6.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(64, 301);
            label5.Name = "label5";
            label5.Size = new Size(54, 16);
            label5.TabIndex = 7;
            label5.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 146);
            label2.Name = "label2";
            label2.Size = new Size(52, 16);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(160, 139);
            txtNombre.MaxLength = 35;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 1;
            // 
            // ModificarAdmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(925, 570);
            Controls.Add(DatosPers);
            Controls.Add(groupBox2);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ModificarAdmi";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += ModificarAdmi_FormClosing;
            Load += ModificarAdmi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            DatosPers.ResumeLayout(false);
            DatosPers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnVolver;
        private GroupBox groupBox2;
        private CheckBox checkBoXMostrarContra;
        private Label lblErrorPass;
        private Label label10;
        private Button btnCrear;
        private TextBox txtConfirmPass;
        private Label label9;
        private TextBox txtContra;
        private TextBox txtUser;
        private Label label4;
        private Label label3;
        private GroupBox DatosPers;
        private Label lblErrorApellido;
        private Label lblErrorDni;
        private Label lblErrorTel;
        private Label label8;
        private TextBox txtApellido;
        private TextBox txtTel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtConfiContra;
        private Label label11;
        private ComboBox cmboxAdm;
    }
}