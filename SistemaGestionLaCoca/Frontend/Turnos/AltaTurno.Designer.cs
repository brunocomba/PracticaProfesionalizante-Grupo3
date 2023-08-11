namespace Frontend
{
    partial class AltaTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaTurno));
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtPrecio = new TextBox();
            label6 = new Label();
            cmboxCliente = new ComboBox();
            label5 = new Label();
            cmboxCancha = new ComboBox();
            cmboxDeporte = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregarCancha = new Button();
            cmboxPrecio = new ComboBox();
            button1 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-4, -13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(812, 96);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(299, 41);
            label4.Name = "label4";
            label4.Size = new Size(211, 32);
            label4.TabIndex = 8;
            label4.Text = "NUEVO TURNO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmboxPrecio);
            groupBox1.Controls.Add(cmboxCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmboxCancha);
            groupBox1.Controls.Add(cmboxDeporte);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregarCancha);
            groupBox1.Location = new Point(39, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 345);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(462, 252);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(214, 23);
            txtPrecio.TabIndex = 13;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(83, 214);
            label6.Name = "label6";
            label6.Size = new Size(16, 17);
            label6.TabIndex = 12;
            label6.Text = "$";
            // 
            // cmboxCliente
            // 
            cmboxCliente.BackColor = SystemColors.Window;
            cmboxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxCliente.FlatStyle = FlatStyle.Flat;
            cmboxCliente.FormattingEnabled = true;
            cmboxCliente.Location = new Point(105, 52);
            cmboxCliente.Name = "cmboxCliente";
            cmboxCliente.Size = new Size(214, 23);
            cmboxCliente.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 215);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 5;
            label5.Text = "Precio";
            // 
            // cmboxCancha
            // 
            cmboxCancha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxCancha.FlatStyle = FlatStyle.Flat;
            cmboxCancha.FormattingEnabled = true;
            cmboxCancha.Location = new Point(105, 156);
            cmboxCancha.Name = "cmboxCancha";
            cmboxCancha.Size = new Size(214, 23);
            cmboxCancha.TabIndex = 3;
            cmboxCancha.SelectedIndexChanged += cmboxCancha_SelectedIndexChanged;
            // 
            // cmboxDeporte
            // 
            cmboxDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxDeporte.FlatStyle = FlatStyle.Flat;
            cmboxDeporte.FormattingEnabled = true;
            cmboxDeporte.Location = new Point(105, 103);
            cmboxDeporte.Name = "cmboxDeporte";
            cmboxDeporte.Size = new Size(214, 23);
            cmboxDeporte.TabIndex = 2;
            cmboxDeporte.SelectedIndexChanged += cmboxDeporte_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 54);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 4;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 163);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 3;
            label2.Text = "Cancha ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 110);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 2;
            label1.Text = "Deporte";
            // 
            // btnAgregarCancha
            // 
            btnAgregarCancha.FlatAppearance.BorderSize = 2;
            btnAgregarCancha.FlatStyle = FlatStyle.Flat;
            btnAgregarCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCancha.ForeColor = Color.White;
            btnAgregarCancha.Location = new Point(141, 288);
            btnAgregarCancha.Name = "btnAgregarCancha";
            btnAgregarCancha.Size = new Size(98, 35);
            btnAgregarCancha.TabIndex = 4;
            btnAgregarCancha.Text = "AGREGAR";
            btnAgregarCancha.UseVisualStyleBackColor = true;
            // 
            // cmboxPrecio
            // 
            cmboxPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxPrecio.Enabled = false;
            cmboxPrecio.FlatStyle = FlatStyle.Flat;
            cmboxPrecio.FormattingEnabled = true;
            cmboxPrecio.Location = new Point(105, 208);
            cmboxPrecio.Name = "cmboxPrecio";
            cmboxPrecio.Size = new Size(214, 23);
            cmboxPrecio.TabIndex = 13;
            cmboxPrecio.SelectedIndexChanged += cmboxPrecio_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(676, 403);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 7;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AltaTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecio);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AltaTurno";
            Load += AltaTurno_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cmboxCancha;
        private ComboBox cmboxDeporte;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregarCancha;
        private ComboBox cmboxCliente;
        private Button button1;
        private Label label6;
        private ComboBox cmboxPrecio;
        private TextBox txtPrecio;
    }
}