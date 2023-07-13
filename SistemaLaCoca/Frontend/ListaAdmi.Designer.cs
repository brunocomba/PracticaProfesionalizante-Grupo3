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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administradorBindingSource = new BindingSource(components);
            btnVolver = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1041, 107);
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
            dgvAdministradores.AutoGenerateColumns = false;
            dgvAdministradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministradores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, usuarioDataGridViewTextBoxColumn });
            dgvAdministradores.DataSource = administradorBindingSource;
            dgvAdministradores.Location = new Point(216, 113);
            dgvAdministradores.Name = "dgvAdministradores";
            dgvAdministradores.RowTemplate.Height = 25;
            dgvAdministradores.Size = new Size(643, 439);
            dgvAdministradores.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // administradorBindingSource
            // 
            administradorBindingSource.DataSource = typeof(LogicaClases.Clases.Administrador);
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(754, 598);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 37);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(28, 245);
            button1.Name = "button1";
            button1.Size = new Size(116, 41);
            button1.TabIndex = 3;
            button1.Text = "MODIFICAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(28, 348);
            button2.Name = "button2";
            button2.Size = new Size(116, 44);
            button2.TabIndex = 4;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // ListaAdmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 661);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnVolver);
            Controls.Add(dgvAdministradores);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaAdmi";
            Load += ListaAdmi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).EndInit();
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
        private Button button1;
        private Button button2;
    }
}