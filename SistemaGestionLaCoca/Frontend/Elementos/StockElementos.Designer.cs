namespace Frontend.Elementos
{
    partial class StockElementos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockElementos));
            dgvElementos = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            elementoBindingSource = new BindingSource(components);
            btnVolver = new Button();
            panel2 = new Panel();
            btnDelete = new Button();
            btnAgregarElemento = new Button();
            btnModElemento = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnAgregarStock = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvElementos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elementoBindingSource).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvElementos
            // 
            dgvElementos.AllowUserToAddRows = false;
            dgvElementos.AllowUserToDeleteRows = false;
            dgvElementos.AllowUserToResizeColumns = false;
            dgvElementos.AllowUserToResizeRows = false;
            dgvElementos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvElementos.AutoGenerateColumns = false;
            dgvElementos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvElementos.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvElementos.BorderStyle = BorderStyle.None;
            dgvElementos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvElementos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvElementos.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            dgvElementos.DataSource = elementoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvElementos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvElementos.EnableHeadersVisualStyles = false;
            dgvElementos.GridColor = Color.MidnightBlue;
            dgvElementos.Location = new Point(227, 126);
            dgvElementos.Name = "dgvElementos";
            dgvElementos.ReadOnly = true;
            dgvElementos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvElementos.RowHeadersVisible = false;
            dgvElementos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvElementos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvElementos.RowTemplate.Height = 25;
            dgvElementos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvElementos.Size = new Size(858, 577);
            dgvElementos.TabIndex = 17;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elementoBindingSource
            // 
            elementoBindingSource.DataSource = typeof(Logica.Clases.Elemento);
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(1103, 671);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 44);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAgregarElemento);
            panel2.Controls.Add(btnModElemento);
            panel2.Location = new Point(-3, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 674);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(41, 278);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(49, 56);
            btnDelete.TabIndex = 20;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAgregarElemento
            // 
            btnAgregarElemento.FlatAppearance.BorderColor = Color.Black;
            btnAgregarElemento.FlatAppearance.BorderSize = 0;
            btnAgregarElemento.FlatStyle = FlatStyle.Flat;
            btnAgregarElemento.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarElemento.ForeColor = Color.White;
            btnAgregarElemento.Image = (Image)resources.GetObject("btnAgregarElemento.Image");
            btnAgregarElemento.Location = new Point(41, 68);
            btnAgregarElemento.Name = "btnAgregarElemento";
            btnAgregarElemento.Size = new Size(49, 57);
            btnAgregarElemento.TabIndex = 19;
            btnAgregarElemento.UseVisualStyleBackColor = true;
            btnAgregarElemento.Click += btnAgregarElemento_Click;
            // 
            // btnModElemento
            // 
            btnModElemento.FlatAppearance.BorderColor = Color.Black;
            btnModElemento.FlatAppearance.BorderSize = 0;
            btnModElemento.FlatStyle = FlatStyle.Flat;
            btnModElemento.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModElemento.ForeColor = Color.White;
            btnModElemento.Image = (Image)resources.GetObject("btnModElemento.Image");
            btnModElemento.Location = new Point(41, 176);
            btnModElemento.Name = "btnModElemento";
            btnModElemento.Size = new Size(49, 51);
            btnModElemento.TabIndex = 18;
            btnModElemento.UseVisualStyleBackColor = true;
            btnModElemento.Click += btnModElemento_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, -22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1265, 96);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 44);
            label1.Name = "label1";
            label1.Size = new Size(329, 32);
            label1.TabIndex = 0;
            label1.Text = "STOCK DE ELEMENTOS";
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.FlatAppearance.BorderSize = 2;
            btnAgregarStock.FlatStyle = FlatStyle.Flat;
            btnAgregarStock.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarStock.ForeColor = Color.White;
            btnAgregarStock.Location = new Point(1103, 142);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(116, 44);
            btnAgregarStock.TabIndex = 18;
            btnAgregarStock.Text = "AGREGAR STOCK";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // StockElementos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1259, 748);
            Controls.Add(btnAgregarStock);
            Controls.Add(dgvElementos);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StockElementos";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += StockElementos_FormClosing;
            Load += ListaElementos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvElementos).EndInit();
            ((System.ComponentModel.ISupportInitialize)elementoBindingSource).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvElementos;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private BindingSource elementoBindingSource;
        private Button btnVolver;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnDelete;
        private Button btnAgregarElemento;
        private Button btnModElemento;
        private Button btnAgregarStock;
        private ToolTip toolTip1;
    }
}