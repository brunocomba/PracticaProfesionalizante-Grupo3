namespace FrontEnd
{
    partial class MenuInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btneElementos = new Button();
            label2 = new Label();
            btnClientes = new Button();
            btnCanchas = new Button();
            btnAdministradores = new Button();
            btnTurnos = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnAdministrador = new Button();
            pictureBox2 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            dgvTurnosDeHoy = new DataGridView();
            panelAdmiLogueado = new Panel();
            btnCerrarCesion = new Button();
            btnCambiarCuenta = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTurnosDeHoy).BeginInit();
            panelAdmiLogueado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateGray;
            label1.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 124);
            label1.Name = "label1";
            label1.Size = new Size(145, 60);
            label1.TabIndex = 0;
            label1.Text = "MENU DE\r\nOPCIONES";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(btneElementos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnCanchas);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAdministradores);
            groupBox1.Controls.Add(btnTurnos);
            groupBox1.Location = new Point(-4, -8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 763);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btneElementos
            // 
            btneElementos.FlatAppearance.BorderSize = 2;
            btneElementos.FlatStyle = FlatStyle.Flat;
            btneElementos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btneElementos.ForeColor = Color.White;
            btneElementos.Location = new Point(27, 478);
            btneElementos.Name = "btneElementos";
            btneElementos.RightToLeft = RightToLeft.Yes;
            btneElementos.Size = new Size(118, 52);
            btneElementos.TabIndex = 10;
            btneElementos.Text = "Stock Elementos";
            btneElementos.UseVisualStyleBackColor = true;
            btneElementos.Click += btneElementos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(-7, 184);
            label2.Name = "label2";
            label2.Size = new Size(182, 15);
            label2.TabIndex = 9;
            label2.Text = "-----------------------------------";
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 2;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(27, 311);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(118, 34);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCanchas
            // 
            btnCanchas.FlatAppearance.BorderSize = 2;
            btnCanchas.FlatStyle = FlatStyle.Flat;
            btnCanchas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCanchas.ForeColor = Color.White;
            btnCanchas.Location = new Point(27, 398);
            btnCanchas.Name = "btnCanchas";
            btnCanchas.RightToLeft = RightToLeft.Yes;
            btnCanchas.Size = new Size(118, 34);
            btnCanchas.TabIndex = 2;
            btnCanchas.Text = "Canchas";
            btnCanchas.UseVisualStyleBackColor = true;
            btnCanchas.Click += btnCanchas_Click;
            // 
            // btnAdministradores
            // 
            btnAdministradores.FlatAppearance.BorderSize = 2;
            btnAdministradores.FlatStyle = FlatStyle.Flat;
            btnAdministradores.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdministradores.ForeColor = Color.White;
            btnAdministradores.Location = new Point(16, 563);
            btnAdministradores.Name = "btnAdministradores";
            btnAdministradores.RightToLeft = RightToLeft.Yes;
            btnAdministradores.Size = new Size(152, 38);
            btnAdministradores.TabIndex = 4;
            btnAdministradores.Text = "Administradores";
            btnAdministradores.UseVisualStyleBackColor = true;
            btnAdministradores.Click += btnAdministradores_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.FlatAppearance.BorderSize = 2;
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTurnos.ForeColor = Color.White;
            btnTurnos.Location = new Point(27, 228);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(118, 32);
            btnTurnos.TabIndex = 1;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Frontend.Properties.Resources.LaCoca;
            pictureBox1.Location = new Point(0, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnAdministrador);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(-4, -8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1264, 102);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnAdministrador
            // 
            btnAdministrador.FlatAppearance.BorderSize = 0;
            btnAdministrador.FlatAppearance.MouseDownBackColor = Color.White;
            btnAdministrador.FlatStyle = FlatStyle.Flat;
            btnAdministrador.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnAdministrador.ForeColor = Color.White;
            btnAdministrador.Location = new Point(1079, 68);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.RightToLeft = RightToLeft.Yes;
            btnAdministrador.Size = new Size(179, 28);
            btnAdministrador.TabIndex = 11;
            btnAdministrador.UseVisualStyleBackColor = true;
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1044, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 28);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.FromArgb(255, 192, 192);
            dateTimePicker1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1044, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 22);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2023, 7, 21, 22, 23, 0, 0);
            // 
            // dgvTurnosDeHoy
            // 
            dgvTurnosDeHoy.AllowUserToAddRows = false;
            dgvTurnosDeHoy.AllowUserToDeleteRows = false;
            dgvTurnosDeHoy.AllowUserToResizeColumns = false;
            dgvTurnosDeHoy.AllowUserToResizeRows = false;
            dgvTurnosDeHoy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTurnosDeHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnosDeHoy.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvTurnosDeHoy.BorderStyle = BorderStyle.None;
            dgvTurnosDeHoy.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTurnosDeHoy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTurnosDeHoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTurnosDeHoy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTurnosDeHoy.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTurnosDeHoy.EnableHeadersVisualStyles = false;
            dgvTurnosDeHoy.GridColor = Color.MidnightBlue;
            dgvTurnosDeHoy.Location = new Point(223, 163);
            dgvTurnosDeHoy.Name = "dgvTurnosDeHoy";
            dgvTurnosDeHoy.ReadOnly = true;
            dgvTurnosDeHoy.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTurnosDeHoy.RowHeadersVisible = false;
            dgvTurnosDeHoy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvTurnosDeHoy.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTurnosDeHoy.RowTemplate.Height = 25;
            dgvTurnosDeHoy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnosDeHoy.Size = new Size(887, 561);
            dgvTurnosDeHoy.TabIndex = 20;
            // 
            // panelAdmiLogueado
            // 
            panelAdmiLogueado.BackColor = Color.SlateGray;
            panelAdmiLogueado.Controls.Add(btnCerrarCesion);
            panelAdmiLogueado.Controls.Add(btnCambiarCuenta);
            panelAdmiLogueado.Location = new Point(1075, 100);
            panelAdmiLogueado.Name = "panelAdmiLogueado";
            panelAdmiLogueado.Size = new Size(179, 76);
            panelAdmiLogueado.TabIndex = 21;
            panelAdmiLogueado.Visible = false;
            // 
            // btnCerrarCesion
            // 
            btnCerrarCesion.FlatAppearance.BorderSize = 0;
            btnCerrarCesion.FlatAppearance.MouseDownBackColor = Color.White;
            btnCerrarCesion.FlatStyle = FlatStyle.Flat;
            btnCerrarCesion.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarCesion.ForeColor = Color.White;
            btnCerrarCesion.Location = new Point(0, 42);
            btnCerrarCesion.Name = "btnCerrarCesion";
            btnCerrarCesion.RightToLeft = RightToLeft.Yes;
            btnCerrarCesion.Size = new Size(179, 28);
            btnCerrarCesion.TabIndex = 13;
            btnCerrarCesion.Text = "Cerrar cesion";
            btnCerrarCesion.UseVisualStyleBackColor = true;
            btnCerrarCesion.Click += btnCerrarCesion_Click;
            // 
            // btnCambiarCuenta
            // 
            btnCambiarCuenta.FlatAppearance.BorderSize = 0;
            btnCambiarCuenta.FlatAppearance.MouseDownBackColor = Color.White;
            btnCambiarCuenta.FlatStyle = FlatStyle.Flat;
            btnCambiarCuenta.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarCuenta.ForeColor = Color.White;
            btnCambiarCuenta.Location = new Point(0, 3);
            btnCambiarCuenta.Name = "btnCambiarCuenta";
            btnCambiarCuenta.RightToLeft = RightToLeft.Yes;
            btnCambiarCuenta.Size = new Size(179, 33);
            btnCambiarCuenta.TabIndex = 12;
            btnCambiarCuenta.Text = "Cambiar cuenta";
            btnCambiarCuenta.UseVisualStyleBackColor = true;
            btnCambiarCuenta.Click += btnCambiarCuenta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(986, 25);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 11;
            label3.Text = "Hoy es:";
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1259, 748);
            Controls.Add(panelAdmiLogueado);
            Controls.Add(dgvTurnosDeHoy);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MenuInicio";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MenuInicio_FormClosing;
            Load += MenuInicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTurnosDeHoy).EndInit();
            panelAdmiLogueado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnTurnos;
        private Button btnClientes;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        public Button btnAdministradores;
        public Button btnCanchas;
        private Label label2;
        public Button btneElementos;
        private DataGridView dgvTurnosDeHoy;
        private PictureBox pictureBox2;
        public Button btnAdministrador;
        private Panel panelAdmiLogueado;
        public Button btnCambiarCuenta;
        public Button btnCerrarCesion;
        private Label label3;
    }
}