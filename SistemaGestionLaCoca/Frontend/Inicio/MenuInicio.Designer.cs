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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            button1 = new Button();
            btnAdministradores = new Button();
            btnClientes = new Button();
            btnTurnos = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            turnoBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            condicionReservadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            cancha = new DataGridViewTextBoxColumn();
            clienteTurnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAdministradores);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnTurnos);
            groupBox1.Location = new Point(-4, -8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 675);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
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
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(27, 309);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(118, 34);
            button1.TabIndex = 8;
            button1.Text = "Canchas";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAdministradores
            // 
            btnAdministradores.FlatAppearance.BorderSize = 2;
            btnAdministradores.FlatStyle = FlatStyle.Flat;
            btnAdministradores.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdministradores.ForeColor = Color.White;
            btnAdministradores.Location = new Point(16, 484);
            btnAdministradores.Name = "btnAdministradores";
            btnAdministradores.RightToLeft = RightToLeft.Yes;
            btnAdministradores.Size = new Size(152, 38);
            btnAdministradores.TabIndex = 7;
            btnAdministradores.Text = "Administradores";
            btnAdministradores.UseVisualStyleBackColor = true;
            btnAdministradores.Click += btnAdministradores_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 2;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(27, 394);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(118, 34);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
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
            btnTurnos.TabIndex = 2;
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
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(-4, -8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1041, 102);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = SystemColors.WindowText;
            dateTimePicker1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(779, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 22);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2023, 7, 21, 22, 23, 0, 0);
            // 
            // turnoBindingSource
            // 
            turnoBindingSource.DataSource = typeof(Logica.Clases.Turno);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, horarioDataGridViewTextBoxColumn, condicionReservadoDataGridViewCheckBoxColumn, cancha, clienteTurnoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = turnoBindingSource;
            dataGridView1.Location = new Point(272, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(669, 430);
            dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            // 
            // condicionReservadoDataGridViewCheckBoxColumn
            // 
            condicionReservadoDataGridViewCheckBoxColumn.DataPropertyName = "condicionReservado";
            condicionReservadoDataGridViewCheckBoxColumn.HeaderText = "condicionReservado";
            condicionReservadoDataGridViewCheckBoxColumn.Name = "condicionReservadoDataGridViewCheckBoxColumn";
            // 
            // cancha
            // 
            cancha.DataPropertyName = "canchaTurno";
            cancha.HeaderText = "canchaTurno";
            cancha.Name = "cancha";
            // 
            // clienteTurnoDataGridViewTextBoxColumn
            // 
            clienteTurnoDataGridViewTextBoxColumn.DataPropertyName = "clienteTurno";
            clienteTurnoDataGridViewTextBoxColumn.HeaderText = "clienteTurno";
            clienteTurnoDataGridViewTextBoxColumn.Name = "clienteTurnoDataGridViewTextBoxColumn";
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1034, 661);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        public Button button1;
        private Label label2;
        private BindingSource turnoBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn condicionReservadoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn cancha;
        private DataGridViewTextBoxColumn clienteTurnoDataGridViewTextBoxColumn;
    }
}