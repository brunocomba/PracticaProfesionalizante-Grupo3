namespace FrontEnd
{
    partial class AltaAdmin
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTel = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            txtContra = new TextBox();
            btnCrear = new Button();
            txtUser = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtConfirPass = new TextBox();
            label10 = new Label();
            label9 = new Label();
            lblErrorPass = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(24, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 332);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(128, 34);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 17;
            label8.Text = "DATOS PERSONALES";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(127, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(195, 23);
            txtApellido.TabIndex = 2;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(128, 150);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(195, 23);
            txtDni.TabIndex = 3;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(127, 193);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(195, 23);
            txtTel.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 119);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 9;
            label7.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 158);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 8;
            label6.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 201);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 7;
            label5.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(660, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 39);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(105, 111);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(195, 23);
            txtContra.TabIndex = 15;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(139, 232);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(90, 38);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear nuevo\r\nusuario";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(105, 77);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(195, 23);
            txtUser.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 119);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 85);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(233, 11);
            label1.Name = "label1";
            label1.Size = new Size(333, 24);
            label1.TabIndex = 4;
            label1.Text = "Crear nuevo usuario administrador";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblErrorPass);
            groupBox2.Controls.Add(txtConfirPass);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnCrear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtContra);
            groupBox2.Controls.Add(txtUser);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(426, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 332);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // txtConfirPass
            // 
            txtConfirPass.Location = new Point(105, 155);
            txtConfirPass.Name = "txtConfirPass";
            txtConfirPass.Size = new Size(195, 23);
            txtConfirPass.TabIndex = 20;
            txtConfirPass.TextChanged += txtConfirPass_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 150);
            label10.Name = "label10";
            label10.Size = new Size(65, 30);
            label10.TabIndex = 19;
            label10.Text = "Confirmar \r\ncontraseña";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(105, 34);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 18;
            label9.Text = "DATOS USUARIO";
            // 
            // lblErrorPass
            // 
            lblErrorPass.AutoSize = true;
            lblErrorPass.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPass.ForeColor = Color.Red;
            lblErrorPass.Location = new Point(105, 193);
            lblErrorPass.Name = "lblErrorPass";
            lblErrorPass.Size = new Size(0, 14);
            lblErrorPass.TabIndex = 21;
            // 
            // AltaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Name = "AltaAdmin";
            Text = "AltaAdmin";
            Load += AltaAdmin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelar;
        private TextBox txtContra;
        private Button btnCrear;
        private TextBox txtUser;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTel;
        private Label label4;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox txtConfirPass;
        private Label label10;
        private Label label9;
        private Label lblErrorPass;
    }
}