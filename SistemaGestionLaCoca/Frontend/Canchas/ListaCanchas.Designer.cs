using Logica.Clases;

namespace Frontend
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCanchas));
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnVolver = new Button();
            dgvCanchas = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCanchas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1041, 96);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(353, 36);
            label1.Name = "label1";
            label1.Size = new Size(429, 32);
            label1.TabIndex = 0;
            label1.Text = "LISTA CANCHAS REGISTRADAS";
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
            // dgvCanchas
            // 
            dgvCanchas.AllowUserToAddRows = false;
            dgvCanchas.AllowUserToDeleteRows = false;
            dgvCanchas.AllowUserToResizeColumns = false;
            dgvCanchas.AllowUserToResizeRows = false;
            dgvCanchas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCanchas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCanchas.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvCanchas.BorderStyle = BorderStyle.None;
            dgvCanchas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCanchas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCanchas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCanchas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCanchas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCanchas.EnableHeadersVisualStyles = false;
            dgvCanchas.GridColor = Color.MidnightBlue;
            dgvCanchas.Location = new Point(263, 121);
            dgvCanchas.Name = "dgvCanchas";
            dgvCanchas.ReadOnly = true;
            dgvCanchas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCanchas.RowHeadersVisible = false;
            dgvCanchas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvCanchas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCanchas.RowTemplate.Height = 25;
            dgvCanchas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCanchas.Size = new Size(563, 474);
            dgvCanchas.TabIndex = 13;
            dgvCanchas.CellContentClick += dgvCanchas_CellContentClick;
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
            btnEliminar.Click += btnEliminar_Click;
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
            btnModificar.Click += btnModificar_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(-3, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 585);
            panel2.TabIndex = 12;
            // 
            // ListaCanchas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1034, 661);
            Controls.Add(dgvCanchas);
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
            ((System.ComponentModel.ISupportInitialize)dgvCanchas).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnVolver;
        private DataGridView dgvCanchas;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantJugadoresDataGridViewTextBoxColumn;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Panel panel2;
    }
}