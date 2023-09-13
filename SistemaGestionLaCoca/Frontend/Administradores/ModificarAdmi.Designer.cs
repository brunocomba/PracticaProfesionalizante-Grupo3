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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAdmi));
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnModificar = new Button();
            button1 = new Button();
            errorProviderPass = new ErrorProvider(components);
            DatosPers = new GroupBox();
            lblErrorApellido = new Label();
            lblErrorDni = new Label();
            lblErrorTel = new Label();
            label8 = new Label();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTel = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            groupBox2 = new GroupBox();
            checkBoXMostrarContra = new CheckBox();
            lblErrorPass = new Label();
            txtConfirPass = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtContra = new TextBox();
            txtUser = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderPass).BeginInit();
            DatosPers.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-2, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(816, 88);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(210, 39);
            label1.Name = "label1";
            label1.Size = new Size(403, 32);
            label1.TabIndex = 4;
            label1.Text = "MODIFICAR ADMINISTRADOR";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(26, 32, 40);
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(115, 246);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 40);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(622, 413);
            button1.Name = "button1";
            button1.Size = new Size(119, 41);
            button1.TabIndex = 22;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProviderPass
            // 
            errorProviderPass.ContainerControl = this;
            // 
            // DatosPers
            // 
            DatosPers.Controls.Add(lblErrorApellido);
            DatosPers.Controls.Add(lblErrorDni);
            DatosPers.Controls.Add(lblErrorTel);
            DatosPers.Controls.Add(label8);
            DatosPers.Controls.Add(txtApellido);
            DatosPers.Controls.Add(txtDni);
            DatosPers.Controls.Add(txtTel);
            DatosPers.Controls.Add(label7);
            DatosPers.Controls.Add(label6);
            DatosPers.Controls.Add(label5);
            DatosPers.Controls.Add(label2);
            DatosPers.Controls.Add(txtNombre);
            DatosPers.Location = new Point(12, 85);
            DatosPers.Name = "DatosPers";
            DatosPers.Size = new Size(381, 310);
            DatosPers.TabIndex = 23;
            DatosPers.TabStop = false;
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(127, 137);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(0, 13);
            lblErrorApellido.TabIndex = 20;
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorDni.ForeColor = Color.Red;
            lblErrorDni.Location = new Point(128, 196);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(0, 13);
            lblErrorDni.TabIndex = 19;
            // 
            // lblErrorTel
            // 
            lblErrorTel.AutoSize = true;
            lblErrorTel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTel.ForeColor = Color.Red;
            lblErrorTel.Location = new Point(128, 246);
            lblErrorTel.Name = "lblErrorTel";
            lblErrorTel.Size = new Size(0, 13);
            lblErrorTel.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(138, 34);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 17;
            label8.Text = "DATOS PERSONALES";
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(128, 119);
            txtApellido.MaxLength = 40;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(195, 23);
            txtApellido.TabIndex = 2;
            txtApellido.Validating += txtApellido_Validating;
            // 
            // txtDni
            // 
            txtDni.ForeColor = Color.Black;
            txtDni.Location = new Point(127, 170);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(196, 23);
            txtDni.TabIndex = 3;
            txtDni.Validating += txtDni_Validating;
            // 
            // txtTel
            // 
            txtTel.ForeColor = Color.Black;
            txtTel.Location = new Point(127, 220);
            txtTel.MaxLength = 10;
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(195, 23);
            txtTel.TabIndex = 4;
            txtTel.Validating += txtTel_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(54, 127);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 9;
            label7.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(75, 173);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 8;
            label6.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(49, 228);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 7;
            label5.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 80);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(127, 72);
            txtNombre.MaxLength = 35;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 1;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoXMostrarContra);
            groupBox2.Controls.Add(lblErrorPass);
            groupBox2.Controls.Add(txtConfirPass);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(txtContra);
            groupBox2.Controls.Add(txtUser);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(399, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 310);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // checkBoXMostrarContra
            // 
            checkBoXMostrarContra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoXMostrarContra.AutoSize = true;
            checkBoXMostrarContra.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoXMostrarContra.ForeColor = Color.White;
            checkBoXMostrarContra.Location = new Point(200, 211);
            checkBoXMostrarContra.Name = "checkBoXMostrarContra";
            checkBoXMostrarContra.Size = new Size(121, 18);
            checkBoXMostrarContra.TabIndex = 23;
            checkBoXMostrarContra.Text = "Mostrar contraseña";
            checkBoXMostrarContra.UseVisualStyleBackColor = true;
            checkBoXMostrarContra.CheckedChanged += checkBoXMostrarContra_CheckedChanged;
            // 
            // lblErrorPass
            // 
            lblErrorPass.AutoSize = true;
            lblErrorPass.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPass.ForeColor = Color.Red;
            lblErrorPass.Location = new Point(115, 191);
            lblErrorPass.Name = "lblErrorPass";
            lblErrorPass.Size = new Size(0, 14);
            lblErrorPass.TabIndex = 21;
            // 
            // txtConfirPass
            // 
            txtConfirPass.Location = new Point(115, 165);
            txtConfirPass.Name = "txtConfirPass";
            txtConfirPass.Size = new Size(206, 23);
            txtConfirPass.TabIndex = 20;
            txtConfirPass.Validated += txtConfirPass_Validated_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(21, 163);
            label10.Name = "label10";
            label10.Size = new Size(69, 30);
            label10.TabIndex = 19;
            label10.Text = "Confirmar \r\ncontraseña";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(126, 34);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 18;
            label9.Text = "DATOS USUARIO";
            // 
            // txtContra
            // 
            txtContra.BackColor = SystemColors.InactiveBorder;
            txtContra.Location = new Point(115, 119);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(206, 23);
            txtContra.TabIndex = 15;
            txtContra.Validated += txtContra_Validated_1;
            // 
            // txtUser
            // 
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(115, 72);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(206, 23);
            txtUser.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 127);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 80);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // ModificarAdmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(804, 466);
            Controls.Add(groupBox2);
            Controls.Add(DatosPers);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ModificarAdmi";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderPass).EndInit();
            DatosPers.ResumeLayout(false);
            DatosPers.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnModificar;
        private Button button1;
        private ErrorProvider errorProviderPass;
        private GroupBox DatosPers;
        private Label lblErrorApellido;
        private Label lblErrorDni;
        private Label lblErrorTel;
        private Label label8;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private TextBox txtNombre;
        private GroupBox groupBox2;
        private Label lblErrorPass;
        private TextBox txtConfirPass;
        private Label label10;
        private Label label9;
        private TextBox txtContra;
        private TextBox txtUser;
        private Label label4;
        private Label label3;
        private CheckBox checkBoXMostrarContra;
    }
}