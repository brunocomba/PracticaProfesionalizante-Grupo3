namespace FrontEnd
{
    partial class AltaCanchas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCanchas));
            btnAgregarCancha = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            cmboxDeporte = new ComboBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            cmboxCantJugadores = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarCancha
            // 
            btnAgregarCancha.FlatAppearance.BorderSize = 2;
            btnAgregarCancha.FlatStyle = FlatStyle.Flat;
            btnAgregarCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCancha.ForeColor = Color.White;
            btnAgregarCancha.Location = new Point(162, 333);
            btnAgregarCancha.Name = "btnAgregarCancha";
            btnAgregarCancha.Size = new Size(129, 41);
            btnAgregarCancha.TabIndex = 4;
            btnAgregarCancha.Text = "AGREGAR";
            btnAgregarCancha.UseVisualStyleBackColor = true;
            btnAgregarCancha.Click += btnAgregarCancha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 150);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 2;
            label1.Text = "Deporte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 207);
            label2.Name = "label2";
            label2.Size = new Size(63, 32);
            label2.TabIndex = 3;
            label2.Text = "Cantidad\r\njugadores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 85);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 23);
            txtNombre.TabIndex = 1;
            // 
            // cmboxDeporte
            // 
            cmboxDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxDeporte.FlatStyle = FlatStyle.Flat;
            cmboxDeporte.FormattingEnabled = true;
            cmboxDeporte.Location = new Point(140, 143);
            cmboxDeporte.Name = "cmboxDeporte";
            cmboxDeporte.Size = new Size(236, 23);
            cmboxDeporte.TabIndex = 2;
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
            groupBox1.Controls.Add(btnAgregarCancha);
            groupBox1.Location = new Point(240, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 404);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(162, 30);
            label7.Name = "label7";
            label7.Size = new Size(109, 16);
            label7.TabIndex = 11;
            label7.Text = "DATOS CANCHA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(121, 274);
            label6.Name = "label6";
            label6.Size = new Size(16, 17);
            label6.TabIndex = 10;
            label6.Text = "$";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(140, 268);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(236, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 270);
            label5.Name = "label5";
            label5.Size = new Size(73, 32);
            label5.TabIndex = 5;
            label5.Text = "Precio total\r\ndel turno";
            // 
            // cmboxCantJugadores
            // 
            cmboxCantJugadores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxCantJugadores.FlatStyle = FlatStyle.Flat;
            cmboxCantJugadores.FormattingEnabled = true;
            cmboxCantJugadores.Location = new Point(140, 205);
            cmboxCantJugadores.Name = "cmboxCantJugadores";
            cmboxCantJugadores.Size = new Size(236, 23);
            cmboxCantJugadores.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(771, 523);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 5;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(335, 36);
            label4.Name = "label4";
            label4.Size = new Size(251, 34);
            label4.TabIndex = 8;
            label4.Text = " NUEVA CANCHA";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(0, -13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(934, 96);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // AltaCanchas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(925, 570);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AltaCanchas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AltaCanchas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregarCancha;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private ComboBox cmboxDeporte;
        private GroupBox groupBox1;
        private Button button1;
        private Label label4;
        private ComboBox cmboxCantJugadores;
        private GroupBox groupBox2;
        private TextBox txtPrecio;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}