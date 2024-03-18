namespace Frontend.Turnos
{
    partial class ModificarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarTurno));
            groupBox3 = new GroupBox();
            txtPrecio = new TextBox();
            btnModificarTurno = new Button();
            FechaTurno = new DateTimePicker();
            label7 = new Label();
            cmboxHorarios = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            cmboxTurnos = new ComboBox();
            label10 = new Label();
            btnAddCanchas = new Button();
            label9 = new Label();
            cmboxCliente = new ComboBox();
            label3 = new Label();
            btnAgregarClientes = new Button();
            cmboxDeporte = new ComboBox();
            cmboxCancha = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtPrecio);
            groupBox3.Controls.Add(btnModificarTurno);
            groupBox3.Controls.Add(FechaTurno);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cmboxHorarios);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(518, 105);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 388);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(105, 220);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(286, 23);
            txtPrecio.TabIndex = 19;
            // 
            // btnModificarTurno
            // 
            btnModificarTurno.FlatAppearance.BorderSize = 2;
            btnModificarTurno.FlatStyle = FlatStyle.Flat;
            btnModificarTurno.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarTurno.ForeColor = Color.White;
            btnModificarTurno.Location = new Point(142, 292);
            btnModificarTurno.Name = "btnModificarTurno";
            btnModificarTurno.Size = new Size(134, 41);
            btnModificarTurno.TabIndex = 4;
            btnModificarTurno.Text = "MODIFICAR";
            btnModificarTurno.UseVisualStyleBackColor = true;
            btnModificarTurno.Click += btnModificarTurno_Click;
            // 
            // FechaTurno
            // 
            FechaTurno.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FechaTurno.Format = DateTimePickerFormat.Custom;
            FechaTurno.Location = new Point(105, 74);
            FechaTurno.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            FechaTurno.MinDate = new DateTime(2023, 8, 13, 0, 0, 0, 0);
            FechaTurno.Name = "FechaTurno";
            FechaTurno.Size = new Size(286, 21);
            FechaTurno.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 80);
            label7.Name = "label7";
            label7.Size = new Size(43, 16);
            label7.TabIndex = 16;
            label7.Text = "Fecha";
            // 
            // cmboxHorarios
            // 
            cmboxHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxHorarios.FlatStyle = FlatStyle.Flat;
            cmboxHorarios.FormattingEnabled = true;
            cmboxHorarios.Location = new Point(105, 148);
            cmboxHorarios.Name = "cmboxHorarios";
            cmboxHorarios.Size = new Size(286, 23);
            cmboxHorarios.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(84, 226);
            label6.Name = "label6";
            label6.Size = new Size(16, 17);
            label6.TabIndex = 12;
            label6.Text = "$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 228);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 5;
            label5.Text = "Precio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(33, 156);
            label8.Name = "label8";
            label8.Size = new Size(55, 16);
            label8.TabIndex = 17;
            label8.Text = "Horarios";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(26, 32, 40);
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(880, 546);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 42);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmboxTurnos);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnAddCanchas);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmboxCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAgregarClientes);
            groupBox1.Controls.Add(cmboxDeporte);
            groupBox1.Controls.Add(cmboxCancha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 333);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // cmboxTurnos
            // 
            cmboxTurnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxTurnos.FormattingEnabled = true;
            cmboxTurnos.Location = new Point(98, 72);
            cmboxTurnos.Name = "cmboxTurnos";
            cmboxTurnos.Size = new Size(276, 23);
            cmboxTurnos.TabIndex = 21;
            cmboxTurnos.SelectedIndexChanged += cmboxTurnos_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(25, 63);
            label10.Name = "label10";
            label10.Size = new Size(59, 32);
            label10.TabIndex = 20;
            label10.Text = "Turno a\r\nmodificar";
            // 
            // btnAddCanchas
            // 
            btnAddCanchas.BackColor = Color.FromArgb(26, 32, 40);
            btnAddCanchas.FlatStyle = FlatStyle.Popup;
            btnAddCanchas.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCanchas.ForeColor = Color.White;
            btnAddCanchas.Location = new Point(390, 262);
            btnAddCanchas.Name = "btnAddCanchas";
            btnAddCanchas.Size = new Size(32, 28);
            btnAddCanchas.TabIndex = 19;
            btnAddCanchas.Text = "+";
            btnAddCanchas.UseVisualStyleBackColor = false;
            btnAddCanchas.Click += btnAddCanchas_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(148, 19);
            label9.Name = "label9";
            label9.Size = new Size(151, 16);
            label9.TabIndex = 5;
            label9.Text = "DATOS MODIFICACION";
            // 
            // cmboxCliente
            // 
            cmboxCliente.BackColor = SystemColors.Window;
            cmboxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxCliente.FlatStyle = FlatStyle.Flat;
            cmboxCliente.FormattingEnabled = true;
            cmboxCliente.Location = new Point(98, 124);
            cmboxCliente.Name = "cmboxCliente";
            cmboxCliente.Size = new Size(276, 23);
            cmboxCliente.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 135);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 4;
            label3.Text = "Cliente";
            // 
            // btnAgregarClientes
            // 
            btnAgregarClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnAgregarClientes.FlatStyle = FlatStyle.Popup;
            btnAgregarClientes.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarClientes.ForeColor = Color.White;
            btnAgregarClientes.Location = new Point(390, 122);
            btnAgregarClientes.Name = "btnAgregarClientes";
            btnAgregarClientes.Size = new Size(32, 28);
            btnAgregarClientes.TabIndex = 12;
            btnAgregarClientes.Text = "+";
            btnAgregarClientes.UseVisualStyleBackColor = false;
            btnAgregarClientes.Click += btnAgregarClientes_Click;
            // 
            // cmboxDeporte
            // 
            cmboxDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxDeporte.FlatStyle = FlatStyle.Flat;
            cmboxDeporte.FormattingEnabled = true;
            cmboxDeporte.Location = new Point(98, 196);
            cmboxDeporte.Name = "cmboxDeporte";
            cmboxDeporte.Size = new Size(276, 23);
            cmboxDeporte.TabIndex = 2;
            cmboxDeporte.SelectedIndexChanged += cmboxDeporte_SelectedIndexChanged;
            // 
            // cmboxCancha
            // 
            cmboxCancha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxCancha.FlatStyle = FlatStyle.Flat;
            cmboxCancha.FormattingEnabled = true;
            cmboxCancha.Location = new Point(98, 268);
            cmboxCancha.Name = "cmboxCancha";
            cmboxCancha.Size = new Size(276, 23);
            cmboxCancha.TabIndex = 3;
            cmboxCancha.SelectedIndexChanged += cmboxCancha_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 275);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 3;
            label2.Text = "Cancha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 203);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 2;
            label1.Text = "Deporte";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-5, -11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1035, 85);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 35);
            label4.Name = "label4";
            label4.Size = new Size(271, 32);
            label4.TabIndex = 8;
            label4.Text = "MODIFICAR TURNO";
            // 
            // ModificarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1025, 610);
            Controls.Add(groupBox3);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ModificarTurno";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += ModificarTurno_FormClosing;
            Load += ModificarTurno_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txtPrecio;
        private Button btnModificarTurno;
        private DateTimePicker FechaTurno;
        private Label label7;
        private ComboBox cmboxHorarios;
        private Label label6;
        private Label label5;
        private Label label8;
        private Button btnVolver;
        private GroupBox groupBox1;
        private Button btnAddCanchas;
        private Label label9;
        private ComboBox cmboxCliente;
        private Label label3;
        private Button btnAgregarClientes;
        private ComboBox cmboxDeporte;
        private ComboBox cmboxCancha;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private ToolTip toolTip1;
        private ComboBox cmboxTurnos;
        private Label label10;
    }
}