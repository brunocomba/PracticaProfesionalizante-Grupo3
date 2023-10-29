namespace Frontend.Elementos_Cancha
{
    partial class ListaElementosCancha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaElementosCancha));
            dgvElementosCancha = new DataGridView();
            btnVolver = new Button();
            panel2 = new Panel();
            btnDeleteAsig = new Button();
            btnAgregarAsig = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvElementosCancha).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvElementosCancha
            // 
            dgvElementosCancha.AllowUserToAddRows = false;
            dgvElementosCancha.AllowUserToDeleteRows = false;
            dgvElementosCancha.AllowUserToResizeColumns = false;
            dgvElementosCancha.AllowUserToResizeRows = false;
            dgvElementosCancha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvElementosCancha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvElementosCancha.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvElementosCancha.BorderStyle = BorderStyle.None;
            dgvElementosCancha.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvElementosCancha.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvElementosCancha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvElementosCancha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvElementosCancha.DefaultCellStyle = dataGridViewCellStyle2;
            dgvElementosCancha.EnableHeadersVisualStyles = false;
            dgvElementosCancha.GridColor = Color.MidnightBlue;
            dgvElementosCancha.Location = new Point(225, 124);
            dgvElementosCancha.Name = "dgvElementosCancha";
            dgvElementosCancha.ReadOnly = true;
            dgvElementosCancha.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvElementosCancha.RowHeadersVisible = false;
            dgvElementosCancha.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvElementosCancha.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvElementosCancha.RowTemplate.Height = 25;
            dgvElementosCancha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvElementosCancha.Size = new Size(851, 579);
            dgvElementosCancha.TabIndex = 21;
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(1120, 683);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 40);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(btnDeleteAsig);
            panel2.Controls.Add(btnAgregarAsig);
            panel2.Location = new Point(-3, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 672);
            panel2.TabIndex = 20;
            // 
            // btnDeleteAsig
            // 
            btnDeleteAsig.FlatAppearance.BorderColor = Color.Black;
            btnDeleteAsig.FlatAppearance.BorderSize = 0;
            btnDeleteAsig.FlatStyle = FlatStyle.Flat;
            btnDeleteAsig.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteAsig.ForeColor = Color.White;
            btnDeleteAsig.Image = (Image)resources.GetObject("btnDeleteAsig.Image");
            btnDeleteAsig.Location = new Point(44, 188);
            btnDeleteAsig.Name = "btnDeleteAsig";
            btnDeleteAsig.Size = new Size(49, 56);
            btnDeleteAsig.TabIndex = 24;
            btnDeleteAsig.UseVisualStyleBackColor = true;
            btnDeleteAsig.Click += btnDeleteAsig_Click;
            // 
            // btnAgregarAsig
            // 
            btnAgregarAsig.FlatAppearance.BorderColor = Color.Black;
            btnAgregarAsig.FlatAppearance.BorderSize = 0;
            btnAgregarAsig.FlatStyle = FlatStyle.Flat;
            btnAgregarAsig.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarAsig.ForeColor = Color.White;
            btnAgregarAsig.Image = (Image)resources.GetObject("btnAgregarAsig.Image");
            btnAgregarAsig.Location = new Point(44, 69);
            btnAgregarAsig.Name = "btnAgregarAsig";
            btnAgregarAsig.Size = new Size(49, 57);
            btnAgregarAsig.TabIndex = 23;
            btnAgregarAsig.UseVisualStyleBackColor = true;
            btnAgregarAsig.Click += btnAgregarAsig_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, -24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1312, 98);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(401, 45);
            label1.Name = "label1";
            label1.Size = new Size(496, 32);
            label1.TabIndex = 0;
            label1.Text = "LISTADO ELEMENTOS POR CANCHA";
            // 
            // ListaElementosCancha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1259, 748);
            Controls.Add(dgvElementosCancha);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaElementosCancha";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += ListaElementosCancha_FormClosing;
            Load += ListaElementosCancha_Load;
            ((System.ComponentModel.ISupportInitialize)dgvElementosCancha).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvElementosCancha;
        private Button btnVolver;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnDeleteAsig;
        private Button btnAgregarAsig;
        private ToolTip toolTip1;
    }
}