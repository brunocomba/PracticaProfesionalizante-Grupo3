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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCanchas));
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnVolver = new Button();
            dgvCanchas = new DataGridView();
            canchaBindingSource = new BindingSource(components);
            panel2 = new Panel();
            btnEliminarCancha = new Button();
            btnAgregarCancha = new Button();
            btnModCancha = new Button();
            btnElementosDeCancha = new Button();
            toolTip1 = new ToolTip(components);
            btnDeportes = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCanchas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1267, 96);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(432, 32);
            label1.TabIndex = 0;
            label1.Text = "LISTA CANCHAS REGISTRADAS";
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(1111, 681);
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
            dgvCanchas.Location = new Point(219, 138);
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
            dgvCanchas.Size = new Size(831, 561);
            dgvCanchas.TabIndex = 13;
            // 
            // canchaBindingSource
            // 
            canchaBindingSource.DataSource = typeof(Cancha);
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(btnEliminarCancha);
            panel2.Controls.Add(btnAgregarCancha);
            panel2.Controls.Add(btnModCancha);
            panel2.Location = new Point(-3, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 664);
            panel2.TabIndex = 12;
            // 
            // btnEliminarCancha
            // 
            btnEliminarCancha.FlatAppearance.BorderColor = Color.Black;
            btnEliminarCancha.FlatAppearance.BorderSize = 0;
            btnEliminarCancha.FlatStyle = FlatStyle.Flat;
            btnEliminarCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarCancha.ForeColor = Color.White;
            btnEliminarCancha.Image = (Image)resources.GetObject("btnEliminarCancha.Image");
            btnEliminarCancha.Location = new Point(46, 287);
            btnEliminarCancha.Name = "btnEliminarCancha";
            btnEliminarCancha.Size = new Size(49, 56);
            btnEliminarCancha.TabIndex = 16;
            btnEliminarCancha.UseVisualStyleBackColor = true;
            btnEliminarCancha.Click += btnEliminarCancha_Click;
            // 
            // btnAgregarCancha
            // 
            btnAgregarCancha.FlatAppearance.BorderColor = Color.Black;
            btnAgregarCancha.FlatAppearance.BorderSize = 0;
            btnAgregarCancha.FlatStyle = FlatStyle.Flat;
            btnAgregarCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCancha.ForeColor = Color.White;
            btnAgregarCancha.Image = (Image)resources.GetObject("btnAgregarCancha.Image");
            btnAgregarCancha.Location = new Point(46, 61);
            btnAgregarCancha.Name = "btnAgregarCancha";
            btnAgregarCancha.Size = new Size(49, 57);
            btnAgregarCancha.TabIndex = 14;
            btnAgregarCancha.UseVisualStyleBackColor = true;
            btnAgregarCancha.Click += btnAgregarCancha_Click;
            // 
            // btnModCancha
            // 
            btnModCancha.FlatAppearance.BorderColor = Color.Black;
            btnModCancha.FlatAppearance.BorderSize = 0;
            btnModCancha.FlatStyle = FlatStyle.Flat;
            btnModCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModCancha.ForeColor = Color.White;
            btnModCancha.Image = (Image)resources.GetObject("btnModCancha.Image");
            btnModCancha.Location = new Point(46, 177);
            btnModCancha.Name = "btnModCancha";
            btnModCancha.Size = new Size(49, 51);
            btnModCancha.TabIndex = 15;
            btnModCancha.UseVisualStyleBackColor = true;
            btnModCancha.Click += btnModCancha_Click;
            // 
            // btnElementosDeCancha
            // 
            btnElementosDeCancha.FlatAppearance.BorderSize = 2;
            btnElementosDeCancha.FlatStyle = FlatStyle.Flat;
            btnElementosDeCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnElementosDeCancha.ForeColor = Color.White;
            btnElementosDeCancha.Location = new Point(1083, 160);
            btnElementosDeCancha.Name = "btnElementosDeCancha";
            btnElementosDeCancha.Size = new Size(132, 44);
            btnElementosDeCancha.TabIndex = 9;
            btnElementosDeCancha.Text = "ELEMENTOS DE CANCHA";
            btnElementosDeCancha.UseVisualStyleBackColor = true;
            btnElementosDeCancha.Click += btnElementosDeCancha_Click;
            // 
            // btnDeportes
            // 
            btnDeportes.FlatAppearance.BorderSize = 2;
            btnDeportes.FlatStyle = FlatStyle.Flat;
            btnDeportes.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeportes.ForeColor = Color.White;
            btnDeportes.Location = new Point(1083, 263);
            btnDeportes.Name = "btnDeportes";
            btnDeportes.Size = new Size(132, 44);
            btnDeportes.TabIndex = 14;
            btnDeportes.Text = "DEPORTES ";
            btnDeportes.UseVisualStyleBackColor = true;
            btnDeportes.Click += btnDeportes_Click;
            // 
            // ListaCanchas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1259, 748);
            Controls.Add(btnDeportes);
            Controls.Add(btnElementosDeCancha);
            Controls.Add(dgvCanchas);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaCanchas";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += ListaCanchas_FormClosing;
            Load += ListaCanchas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCanchas).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource).EndInit();
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
        private Panel panel2;
        private Button btnElementosDeCancha;
        private DataGridViewTextBoxColumn cantidadJugadoresDataGridViewTextBoxColumn;
        private BindingSource canchaBindingSource;
        private Button btnEliminarCancha;
        private Button btnAgregarCancha;
        private Button btnModCancha;
        private ToolTip toolTip1;
        private Button btnDeportes;
    }
}