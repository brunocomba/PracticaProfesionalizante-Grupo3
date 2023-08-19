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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            dgvTurnos = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
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
            // dgvTurnos
            // 
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.AllowUserToResizeColumns = false;
            dgvTurnos.AllowUserToResizeRows = false;
            dgvTurnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvTurnos.BorderStyle = BorderStyle.None;
            dgvTurnos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTurnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTurnos.EnableHeadersVisualStyles = false;
            dgvTurnos.GridColor = Color.MidnightBlue;
            dgvTurnos.Location = new Point(266, 175);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTurnos.RowHeadersVisible = false;
            dgvTurnos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvTurnos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.Size = new Size(563, 474);
            dgvTurnos.TabIndex = 19;
            // 
            // HistorialTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1034, 661);
            Controls.Add(dgvTurnos);
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
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
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
        private DataGridView dgvTurnos;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn1;
    }
}