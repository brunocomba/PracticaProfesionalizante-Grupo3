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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
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
            dateTimePicker1 = new DateTimePicker();
            dgvTurnosDeHoy = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnosDeHoy).BeginInit();
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
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(-4, -8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1264, 102);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = SystemColors.WindowText;
            dateTimePicker1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(1004, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 22);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTurnosDeHoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTurnosDeHoy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvTurnosDeHoy.DefaultCellStyle = dataGridViewCellStyle5;
            dgvTurnosDeHoy.EnableHeadersVisualStyles = false;
            dgvTurnosDeHoy.GridColor = Color.MidnightBlue;
            dgvTurnosDeHoy.Location = new Point(281, 148);
            dgvTurnosDeHoy.Name = "dgvTurnosDeHoy";
            dgvTurnosDeHoy.ReadOnly = true;
            dgvTurnosDeHoy.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTurnosDeHoy.RowHeadersVisible = false;
            dgvTurnosDeHoy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvTurnosDeHoy.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvTurnosDeHoy.RowTemplate.Height = 25;
            dgvTurnosDeHoy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnosDeHoy.Size = new Size(872, 561);
            dgvTurnosDeHoy.TabIndex = 20;
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1259, 748);
            Controls.Add(dgvTurnosDeHoy);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MenuInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MenuInicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTurnosDeHoy).EndInit();
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
    }
}