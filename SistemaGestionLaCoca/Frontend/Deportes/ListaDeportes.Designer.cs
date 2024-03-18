namespace Frontend.Deportes
{
    partial class ListaDeportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeportes));
            dgvDeportes = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantJugadoresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deporteBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deporteBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDeportes
            // 
            dgvDeportes.AllowUserToAddRows = false;
            dgvDeportes.AllowUserToDeleteRows = false;
            dgvDeportes.AllowUserToResizeColumns = false;
            dgvDeportes.AllowUserToResizeRows = false;
            dgvDeportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDeportes.AutoGenerateColumns = false;
            dgvDeportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeportes.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvDeportes.BorderStyle = BorderStyle.None;
            dgvDeportes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDeportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDeportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDeportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDeportes.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, cantJugadoresDataGridViewTextBoxColumn });
            dgvDeportes.DataSource = deporteBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDeportes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDeportes.EnableHeadersVisualStyles = false;
            dgvDeportes.GridColor = Color.MidnightBlue;
            dgvDeportes.Location = new Point(21, 120);
            dgvDeportes.Name = "dgvDeportes";
            dgvDeportes.ReadOnly = true;
            dgvDeportes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDeportes.RowHeadersVisible = false;
            dgvDeportes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvDeportes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDeportes.RowTemplate.Height = 25;
            dgvDeportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeportes.Size = new Size(315, 400);
            dgvDeportes.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantJugadoresDataGridViewTextBoxColumn
            // 
            cantJugadoresDataGridViewTextBoxColumn.DataPropertyName = "Cant_Jugadores";
            cantJugadoresDataGridViewTextBoxColumn.HeaderText = "Jugadores";
            cantJugadoresDataGridViewTextBoxColumn.Name = "cantJugadoresDataGridViewTextBoxColumn";
            cantJugadoresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deporteBindingSource
            // 
            deporteBindingSource.DataSource = typeof(Logica.Clases.Deporte);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-9, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 86);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "DEPORTES";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(779, 494);
            button1.Name = "button1";
            button1.Size = new Size(111, 41);
            button1.TabIndex = 6;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(396, 145);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 36);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(396, 227);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 37);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ListaDeportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(925, 570);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dgvDeportes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaDeportes";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += ListaDeportes_FormClosing;
            Load += ListaDeportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)deporteBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDeportes;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantJugadoresDataGridViewTextBoxColumn;
        private BindingSource deporteBindingSource;
    }
}