namespace FrontEnd
{
    partial class ListaAdmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaAdmi));
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnVolver = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCrear = new Button();
            panel1 = new Panel();
            dgvAdministradores = new DataGridView();
            administradorBindingSource = new BindingSource(components);
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1041, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(239, 41);
            label1.Name = "label1";
            label1.Size = new Size(564, 32);
            label1.TabIndex = 0;
            label1.Text = "LISTA ADMINISTRADORES REGISTRADOS";
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(867, 596);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 43);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderColor = Color.White;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(17, 232);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 41);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(17, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 44);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
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
            btnCrear.Location = new Point(17, 121);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(116, 44);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnEliminar);
            panel1.Location = new Point(-3, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 585);
            panel1.TabIndex = 12;
            // 
            // dgvAdministradores
            // 
            dgvAdministradores.AllowUserToAddRows = false;
            dgvAdministradores.AllowUserToDeleteRows = false;
            dgvAdministradores.AllowUserToResizeColumns = false;
            dgvAdministradores.AllowUserToResizeRows = false;
            dgvAdministradores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdministradores.AutoGenerateColumns = false;
            dgvAdministradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdministradores.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvAdministradores.BorderStyle = BorderStyle.None;
            dgvAdministradores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAdministradores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAdministradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdministradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAdministradores.Columns.AddRange(new DataGridViewColumn[] { dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, usuarioDataGridViewTextBoxColumn });
            dgvAdministradores.DataSource = administradorBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAdministradores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAdministradores.EnableHeadersVisualStyles = false;
            dgvAdministradores.GridColor = Color.MidnightBlue;
            dgvAdministradores.Location = new Point(255, 138);
            dgvAdministradores.Name = "dgvAdministradores";
            dgvAdministradores.ReadOnly = true;
            dgvAdministradores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAdministradores.RowHeadersVisible = false;
            dgvAdministradores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvAdministradores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvAdministradores.RowTemplate.Height = 25;
            dgvAdministradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdministradores.Size = new Size(563, 474);
            dgvAdministradores.TabIndex = 13;
            // 
            // administradorBindingSource
            // 
            administradorBindingSource.DataSource = typeof(LogicaClases.Clases.Administrador);
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListaAdmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1034, 661);
            Controls.Add(dgvAdministradores);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaAdmi";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ListaAdmi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Button btnVolver;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCrear;
        private Panel panel1;
        private DataGridView dgvAdministradores;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private BindingSource administradorBindingSource;
    }
}