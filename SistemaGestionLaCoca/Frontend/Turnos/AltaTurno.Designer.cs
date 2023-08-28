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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaTurno));
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnAddHorarios = new Button();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            cmboxHorarios = new ComboBox();
            btnAgregarClientes = new Button();
            label6 = new Label();
            cmboxPrecio = new ComboBox();
            btnAgregarCancha = new Button();
            cmboxCliente = new ComboBox();
            label5 = new Label();
            cmboxCancha = new ComboBox();
            cmboxDeporte = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            horarioBindingSource = new BindingSource(components);
            turnoBindingSource = new BindingSource(components);
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)horarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-4, -13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1035, 96);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(332, 39);
            label4.Name = "label4";
            label4.Size = new Size(378, 32);
            label4.TabIndex = 8;
            label4.Text = "REGISTRAR NUEVO TURNO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddHorarios);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmboxHorarios);
            groupBox1.Controls.Add(btnAgregarClientes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmboxPrecio);
            groupBox1.Controls.Add(btnAgregarCancha);
            groupBox1.Controls.Add(cmboxCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmboxCancha);
            groupBox1.Controls.Add(cmboxDeporte);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 496);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAddHorarios
            // 
            btnAddHorarios.BackColor = Color.FromArgb(26, 32, 40);
            btnAddHorarios.FlatStyle = FlatStyle.Popup;
            btnAddHorarios.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddHorarios.ForeColor = Color.White;
            btnAddHorarios.Location = new Point(337, 271);
            btnAddHorarios.Name = "btnAddHorarios";
            btnAddHorarios.Size = new Size(32, 28);
            btnAddHorarios.TabIndex = 19;
            btnAddHorarios.Text = "+";
            btnAddHorarios.UseVisualStyleBackColor = false;
            btnAddHorarios.Click += btnAddHorarios_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(105, 215);
            dateTimePicker1.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 8, 13, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 21);
            dateTimePicker1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 278);
            label8.Name = "label8";
            label8.Size = new Size(55, 16);
            label8.TabIndex = 17;
            label8.Text = "Horarios";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 220);
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
            cmboxHorarios.Location = new Point(105, 271);
            cmboxHorarios.Name = "cmboxHorarios";
            cmboxHorarios.Size = new Size(214, 23);
            cmboxHorarios.TabIndex = 15;
            // 
            // btnAgregarClientes
            // 
            btnAgregarClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnAgregarClientes.FlatStyle = FlatStyle.Popup;
            btnAgregarClientes.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarClientes.ForeColor = Color.White;
            btnAgregarClientes.Location = new Point(337, 51);
            btnAgregarClientes.Name = "btnAgregarClientes";
            btnAgregarClientes.Size = new Size(32, 28);
            btnAgregarClientes.TabIndex = 12;
            btnAgregarClientes.Text = "+";
            btnAgregarClientes.UseVisualStyleBackColor = false;
            btnAgregarClientes.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(83, 367);
            label6.Name = "label6";
            label6.Size = new Size(16, 17);
            label6.TabIndex = 12;
            label6.Text = "$";
            // 
            // cmboxPrecio
            // 
            cmboxPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxPrecio.Enabled = false;
            cmboxPrecio.FlatStyle = FlatStyle.Flat;
            cmboxPrecio.FormattingEnabled = true;
            cmboxPrecio.Location = new Point(105, 360);
            cmboxPrecio.Name = "cmboxPrecio";
            cmboxPrecio.Size = new Size(214, 23);
            cmboxPrecio.TabIndex = 13;
            cmboxPrecio.SelectedIndexChanged += cmboxPrecio_SelectedIndexChanged;
            // 
            // btnAgregarCancha
            // 
            btnAgregarCancha.FlatAppearance.BorderSize = 2;
            btnAgregarCancha.FlatStyle = FlatStyle.Flat;
            btnAgregarCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCancha.ForeColor = Color.White;
            btnAgregarCancha.Location = new Point(141, 420);
            btnAgregarCancha.Name = "btnAgregarCancha";
            btnAgregarCancha.Size = new Size(107, 41);
            btnAgregarCancha.TabIndex = 4;
            btnAgregarCancha.Text = "AGREGAR";
            btnAgregarCancha.UseVisualStyleBackColor = true;
            btnAgregarCancha.Click += btnAgregarCancha_Click;
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
            label5.Location = new Point(16, 367);
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
            cmboxCancha.Location = new Point(105, 161);
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
            label3.Location = new Point(20, 59);
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
            label2.Location = new Point(17, 168);
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
            label1.Location = new Point(20, 110);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 2;
            label1.Text = "Deporte";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(891, 563);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 7;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // turnoBindingSource
            // 
            turnoBindingSource.DataSource = typeof(Logica.Clases.Turno);
            // 
            // AltaTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1025, 610);
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
            ((System.ComponentModel.ISupportInitialize)horarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).EndInit();
            ResumeLayout(false);
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
        private ComboBox cmboxCliente;
        private Button button1;
        private Label label6;
        private ComboBox cmboxPrecio;
        private Button btnAgregarClientes;
        private Label label8;
        private Label label7;
        private ComboBox cmboxHorarios;
        private DateTimePicker dateTimePicker1;
        private Button btnAddHorarios;
        private Button button2;
        private ToolTip toolTip1;
        private BindingSource horarioBindingSource;
        private Button btnAgregarCancha;
        private DataGridViewTextBoxColumn canchaTurnoDataGridViewTextBoxColumn;
        private BindingSource turnoBindingSource;
    }
}