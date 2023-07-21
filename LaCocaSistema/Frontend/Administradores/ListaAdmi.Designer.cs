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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaAdmi));
            groupBox1 = new GroupBox();
            label1 = new Label();
            dgvAdministradores = new DataGridView();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administradorBindingSource1 = new BindingSource(components);
            administradorBindingSource = new BindingSource(components);
            btnVolver = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCrear = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateBlue;
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
            label1.Font = new Font("Arial", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(219, 41);
            label1.Name = "label1";
            label1.Size = new Size(641, 35);
            label1.TabIndex = 0;
            label1.Text = "LISTA ADMINISTRADORES REGISTRADOS";
            // 
            // dgvAdministradores
            // 
            dgvAdministradores.AllowUserToResizeColumns = false;
            dgvAdministradores.AllowUserToResizeRows = false;
            dgvAdministradores.AutoGenerateColumns = false;
            dgvAdministradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdministradores.BackgroundColor = Color.White;
            dgvAdministradores.BorderStyle = BorderStyle.None;
            dgvAdministradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministradores.Columns.AddRange(new DataGridViewColumn[] { dniDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, usuarioDataGridViewTextBoxColumn });
            dgvAdministradores.DataSource = administradorBindingSource1;
            dgvAdministradores.Location = new Point(214, 125);
            dgvAdministradores.Name = "dgvAdministradores";
            dgvAdministradores.ReadOnly = true;
            dgvAdministradores.RowTemplate.Height = 25;
            dgvAdministradores.Size = new Size(643, 439);
            dgvAdministradores.TabIndex = 1;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
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
            // administradorBindingSource1
            // 
            administradorBindingSource1.DataSource = typeof(LogicaClases.Clases.Administrador);
            // 
            // administradorBindingSource
            // 
            administradorBindingSource.DataSource = typeof(LogicaClases.Clases.Administrador);
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnModificar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnCrear.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.Location = new Point(17, 121);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(116, 44);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnEliminar);
            panel1.Location = new Point(-3, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 584);
            panel1.TabIndex = 12;
            // 
            // ListaAdmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 661);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(dgvAdministradores);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaAdmi";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ListaAdmi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvAdministradores;
        private BindingSource administradorBindingSource;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private Button btnVolver;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCrear;
        private BindingSource administradorBindingSource1;
        private Panel panel1;
    }
}