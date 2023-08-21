using Logica.Clases;

namespace Frontend
{
    partial class HistorialTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialTurnos));
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnVolver = new Button();
            panel1 = new Panel();
            btnCrear = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtFiltrarTurnos = new TextBox();
            turnoBindingSource8 = new BindingSource(components);
            turnoBindingSource3 = new BindingSource(components);
            turnoBindingSource = new BindingSource(components);
            clienteBindingSource = new BindingSource(components);
            turnoBindingSource1 = new BindingSource(components);
            turnoBindingSource2 = new BindingSource(components);
            turnoBindingSource4 = new BindingSource(components);
            turnoBindingSource5 = new BindingSource(components);
            turnoBindingSource6 = new BindingSource(components);
            turnoBindingSource7 = new BindingSource(components);
            turnoBindingSource9 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            canchaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource9).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1041, 96);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(381, 40);
            label1.Name = "label1";
            label1.Size = new Size(277, 32);
            label1.TabIndex = 0;
            label1.Text = "HISTORIAL TURNOS";
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(906, 605);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 44);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnEliminar);
            panel1.Location = new Point(-3, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 597);
            panel1.TabIndex = 16;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.SlateGray;
            btnCrear.BackgroundImageLayout = ImageLayout.None;
            btnCrear.FlatAppearance.BorderColor = Color.White;
            btnCrear.FlatAppearance.BorderSize = 2;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(15, 41);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(116, 44);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderColor = Color.White;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(17, 132);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 41);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(17, 224);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 44);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(208, 134);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 17;
            label2.Text = "FILTRAR";
            // 
            // txtFiltrarTurnos
            // 
            txtFiltrarTurnos.BackColor = Color.FromArgb(26, 32, 40);
            txtFiltrarTurnos.BorderStyle = BorderStyle.FixedSingle;
            txtFiltrarTurnos.Location = new Point(287, 126);
            txtFiltrarTurnos.Name = "txtFiltrarTurnos";
            txtFiltrarTurnos.Size = new Size(613, 23);
            txtFiltrarTurnos.TabIndex = 18;
            txtFiltrarTurnos.TextChanged += txtFiltrarTurnos_TextChanged;
            // 
            // turnoBindingSource8
            // 
            turnoBindingSource8.DataSource = typeof(Turno);
            // 
            // turnoBindingSource3
            // 
            turnoBindingSource3.DataSource = typeof(Turno);
            // 
            // turnoBindingSource
            // 
            turnoBindingSource.DataSource = typeof(Turno);
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Cliente);
            // 
            // turnoBindingSource1
            // 
            turnoBindingSource1.DataSource = typeof(Turno);
            // 
            // turnoBindingSource2
            // 
            turnoBindingSource2.DataSource = typeof(Turno);
            // 
            // turnoBindingSource4
            // 
            turnoBindingSource4.DataSource = typeof(Turno);
            // 
            // turnoBindingSource5
            // 
            turnoBindingSource5.DataSource = typeof(Turno);
            // 
            // turnoBindingSource6
            // 
            turnoBindingSource6.DataSource = typeof(Turno);
            // 
            // turnoBindingSource7
            // 
            turnoBindingSource7.DataSource = typeof(Turno);
            // 
            // turnoBindingSource9
            // 
            turnoBindingSource9.DataSource = typeof(Turno);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 94;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.Width = 94;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            horarioDataGridViewTextBoxColumn.DataPropertyName = "horario";
            horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            horarioDataGridViewTextBoxColumn.Width = 94;
            // 
            // canchaDataGridViewTextBoxColumn
            // 
            canchaDataGridViewTextBoxColumn.DataPropertyName = "cancha";
            canchaDataGridViewTextBoxColumn.HeaderText = "cancha";
            canchaDataGridViewTextBoxColumn.Name = "canchaDataGridViewTextBoxColumn";
            canchaDataGridViewTextBoxColumn.Width = 94;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            clienteDataGridViewTextBoxColumn.Width = 94;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(26, 32, 40);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ColumnWidth = 23;
            listBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(226, 217);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(674, 408);
            listBox1.TabIndex = 19;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(224, 189);
            label3.Name = "label3";
            label3.Size = new Size(19, 16);
            label3.TabIndex = 20;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(518, 189);
            label4.Name = "label4";
            label4.Size = new Size(54, 16);
            label4.TabIndex = 21;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(447, 189);
            label5.Name = "label5";
            label5.Size = new Size(53, 16);
            label5.TabIndex = 22;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(378, 189);
            label6.Name = "label6";
            label6.Size = new Size(52, 16);
            label6.TabIndex = 23;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(320, 189);
            label7.Name = "label7";
            label7.Size = new Size(34, 16);
            label7.TabIndex = 24;
            label7.Text = "Hora";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(260, 189);
            label8.Name = "label8";
            label8.Size = new Size(43, 16);
            label8.TabIndex = 25;
            label8.Text = "Fecha";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(578, 173);
            label9.Name = "label9";
            label9.Size = new Size(51, 32);
            label9.TabIndex = 26;
            label9.Text = "Cancha\r\n    ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(635, 189);
            label10.Name = "label10";
            label10.Size = new Size(52, 16);
            label10.TabIndex = 27;
            label10.Text = "Deporte";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(693, 189);
            label11.Name = "label11";
            label11.Size = new Size(44, 16);
            label11.TabIndex = 28;
            label11.Text = "Precio";
            // 
            // HistorialTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1034, 661);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(txtFiltrarTurnos);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HistorialTurnos";
            Load += HistorialTurnos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource8).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource7).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnVolver;
        private Panel panel1;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtFiltrarTurnos;
        private BindingSource turnoBindingSource8;
        private DataGridViewTextBoxColumn canchaQueVaTenerElTurnoDataGridViewTextBoxColumn;
        private BindingSource turnoBindingSource;
        private BindingSource clienteBindingSource;
        private BindingSource turnoBindingSource1;
        private DataGridViewTextBoxColumn canchaTurnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteTurnoDataGridViewTextBoxColumn;
        private BindingSource turnoBindingSource2;
        private BindingSource turnoBindingSource3;
        private BindingSource turnoBindingSource4;
        private BindingSource turnoBindingSource5;
        private BindingSource turnoBindingSource7;
        private BindingSource turnoBindingSource6;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn canchaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoCanchaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telClienteDataGridViewTextBoxColumn;
        private BindingSource turnoBindingSource9;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn canchaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn canchaDataGridViewTextBoxColumn1;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}