﻿namespace Frontend
{
    partial class ListaCanchas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCanchas));
            groupBox1 = new GroupBox();
            label1 = new Label();
            panel2 = new Panel();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            canchaBindingSource = new BindingSource(components);
            btnVolver = new Button();
            canchaBindingSource1 = new BindingSource(components);
            canchaBindingSource2 = new BindingSource(components);
            canchaBindingSource3 = new BindingSource(components);
            canchaBindingSource4 = new BindingSource(components);
            canchaBindingSource5 = new BindingSource(components);
            canchaBindingSource7 = new BindingSource(components);
            administradorBindingSource = new BindingSource(components);
            canchaBindingSource6 = new BindingSource(components);
            canchaBindingSource8 = new BindingSource(components);
            canchaBindingSource9 = new BindingSource(components);
            administradorBindingSource1 = new BindingSource(components);
            administradorBindingSource2 = new BindingSource(components);
            canchaBindingSource10 = new BindingSource(components);
            canchaBindingSource11 = new BindingSource(components);
            canchaBindingSource12 = new BindingSource(components);
            dgvClientes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantJugadoresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1095, 79);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(334, 33);
            label1.Name = "label1";
            label1.Size = new Size(429, 32);
            label1.TabIndex = 0;
            label1.Text = "LISTA CANCHAS REGISTRADAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 596);
            panel2.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(17, 52);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 44);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(17, 160);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 44);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(17, 268);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 44);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // canchaBindingSource
            // 
            canchaBindingSource.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(890, 605);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 44);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // canchaBindingSource1
            // 
            canchaBindingSource1.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource2
            // 
            canchaBindingSource2.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource3
            // 
            canchaBindingSource3.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource4
            // 
            canchaBindingSource4.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource5
            // 
            canchaBindingSource5.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource7
            // 
            canchaBindingSource7.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // administradorBindingSource
            // 
            administradorBindingSource.DataSource = typeof(LogicaClases.Clases.Administrador);
            // 
            // canchaBindingSource6
            // 
            canchaBindingSource6.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource8
            // 
            canchaBindingSource8.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource9
            // 
            canchaBindingSource9.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // administradorBindingSource1
            // 
            administradorBindingSource1.DataSource = typeof(LogicaClases.Clases.Administrador);
            // 
            // administradorBindingSource2
            // 
            administradorBindingSource2.DataSource = typeof(LogicaClases.Clases.Administrador);
            // 
            // canchaBindingSource10
            // 
            canchaBindingSource10.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource11
            // 
            canchaBindingSource11.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource12
            // 
            canchaBindingSource12.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, cantJugadoresDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn });
            dgvClientes.DataSource = canchaBindingSource12;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.MidnightBlue;
            dgvClientes.Location = new Point(260, 121);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(563, 474);
            dgvClientes.TabIndex = 13;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantJugadoresDataGridViewTextBoxColumn
            // 
            cantJugadoresDataGridViewTextBoxColumn.DataPropertyName = "cantJugadores";
            cantJugadoresDataGridViewTextBoxColumn.HeaderText = "Cantidad  jugadores";
            cantJugadoresDataGridViewTextBoxColumn.Name = "cantJugadoresDataGridViewTextBoxColumn";
            cantJugadoresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListaCanchas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1034, 661);
            Controls.Add(dgvClientes);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaCanchas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ListaCanchas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource7).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource8).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource9).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource10).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource11).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource12).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Panel panel2;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private BindingSource canchaBindingSource;
        private Button btnVolver;
        private BindingSource canchaBindingSource2;
        private BindingSource canchaBindingSource1;
        private BindingSource canchaBindingSource3;
        private BindingSource canchaBindingSource4;
        private BindingSource canchaBindingSource5;
        private BindingSource administradorBindingSource;
        private BindingSource canchaBindingSource6;
        private BindingSource canchaBindingSource7;
        private BindingSource canchaBindingSource10;
        private BindingSource canchaBindingSource8;
        private BindingSource canchaBindingSource9;
        private BindingSource administradorBindingSource1;
        private BindingSource administradorBindingSource2;
        private BindingSource canchaBindingSource11;
        private BindingSource canchaBindingSource12;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantJugadoresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}