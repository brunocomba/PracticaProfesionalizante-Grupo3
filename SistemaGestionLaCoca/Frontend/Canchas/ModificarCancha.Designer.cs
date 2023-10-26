namespace Frontend
{
    partial class ModificarCancha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCancha));
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            cmboxCantJugadores = new ComboBox();
            cmboxDeporte = new ComboBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnModificarCancha = new Button();
            button1 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-4, -11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(942, 88);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(330, 32);
            label4.Name = "label4";
            label4.Size = new Size(291, 32);
            label4.TabIndex = 8;
            label4.Text = "MODIFICAR CANCHA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmboxCantJugadores);
            groupBox1.Controls.Add(cmboxDeporte);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnModificarCancha);
            groupBox1.Location = new Point(253, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 395);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(146, 19);
            label7.Name = "label7";
            label7.Size = new Size(141, 16);
            label7.TabIndex = 9;
            label7.Text = "DATOS A MODIFICAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(109, 232);
            label6.Name = "label6";
            label6.Size = new Size(16, 17);
            label6.TabIndex = 7;
            label6.Text = "$";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(131, 226);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(248, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(42, 233);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 5;
            label5.Text = "Precio";
            // 
            // cmboxCantJugadores
            // 
            cmboxCantJugadores.FlatStyle = FlatStyle.Flat;
            cmboxCantJugadores.FormattingEnabled = true;
            cmboxCantJugadores.Location = new Point(131, 174);
            cmboxCantJugadores.Name = "cmboxCantJugadores";
            cmboxCantJugadores.Size = new Size(248, 23);
            cmboxCantJugadores.TabIndex = 3;
            cmboxCantJugadores.MouseClick += cmboxCantJugadores_MouseClick;
            // 
            // cmboxDeporte
            // 
            cmboxDeporte.FlatStyle = FlatStyle.Flat;
            cmboxDeporte.FormattingEnabled = true;
            cmboxDeporte.Location = new Point(131, 121);
            cmboxDeporte.Name = "cmboxDeporte";
            cmboxDeporte.Size = new Size(248, 23);
            cmboxDeporte.TabIndex = 2;
            cmboxDeporte.MouseClick += cmboxDeporte_MouseClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 23);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 72);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 165);
            label2.Name = "label2";
            label2.Size = new Size(63, 32);
            label2.TabIndex = 3;
            label2.Text = "Cantidad\r\njugadores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 128);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 2;
            label1.Text = "Deporte";
            // 
            // btnModificarCancha
            // 
            btnModificarCancha.FlatAppearance.BorderSize = 2;
            btnModificarCancha.FlatStyle = FlatStyle.Flat;
            btnModificarCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarCancha.ForeColor = Color.White;
            btnModificarCancha.Location = new Point(154, 294);
            btnModificarCancha.Name = "btnModificarCancha";
            btnModificarCancha.Size = new Size(133, 35);
            btnModificarCancha.TabIndex = 4;
            btnModificarCancha.Text = "MODIFICAR";
            btnModificarCancha.UseVisualStyleBackColor = true;
            btnModificarCancha.Click += btnModificarCancha_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(793, 522);
            button1.Name = "button1";
            button1.Size = new Size(104, 36);
            button1.TabIndex = 12;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ModificarCancha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(925, 570);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ModificarCancha";
            Load += ModificarCancha_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtPrecio;
        private Label label5;
        private ComboBox cmboxCantJugadores;
        private ComboBox cmboxDeporte;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnModificarCancha;
        private Button button1;
        private Label label6;
        private Label label7;
    }
}