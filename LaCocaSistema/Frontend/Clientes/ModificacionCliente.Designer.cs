namespace Frontend
{
    partial class ModificacionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionCliente));
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblErrorDni = new Label();
            lblErrorTel = new Label();
            btnModificar = new Button();
            txtTel = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MidnightBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-1, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 85);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "23";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(267, 35);
            label1.Name = "label1";
            label1.Size = new Size(291, 32);
            label1.TabIndex = 4;
            label1.Text = "MODIFICAR CLIENTE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblErrorDni);
            groupBox2.Controls.Add(lblErrorTel);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(txtTel);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(222, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 327);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorDni.ForeColor = Color.Red;
            lblErrorDni.Location = new Point(113, 188);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(0, 14);
            lblErrorDni.TabIndex = 32;
            // 
            // lblErrorTel
            // 
            lblErrorTel.AutoSize = true;
            lblErrorTel.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTel.ForeColor = Color.Red;
            lblErrorTel.Location = new Point(113, 234);
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
            btnModificar.Location = new Point(129, 255);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(102, 34);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnAgregar_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(113, 205);
            txtTel.MaxLength = 10;
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(183, 23);
            txtTel.TabIndex = 30;
            txtTel.TextChanged += txtTel_TextChanged;
            txtTel.KeyPress += txtTel_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(113, 130);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 29;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(113, 168);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(183, 23);
            txtDNI.TabIndex = 28;
            txtDNI.TextChanged += txtDNI_TextChanged;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(32, 208);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 27;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 133);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 26;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 171);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 25;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 90);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 24;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 21;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 29);
            label2.Name = "label2";
            label2.Size = new Size(174, 34);
            label2.TabIndex = 22;
            label2.Text = "DATOS PERSONALES A\r\nMODIFICAR";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(643, 415);
            button1.Name = "button1";
            button1.Size = new Size(102, 34);
            button1.TabIndex = 33;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ModificacionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(804, 461);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ModificacionCliente";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnModificar;
        private TextBox txtTel;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label lblErrorTel;
        private Label lblErrorDni;
        private Button button1;
    }
}