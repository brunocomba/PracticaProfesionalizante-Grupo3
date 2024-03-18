namespace Frontend.Elementos
{
    partial class AgregarStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarStock));
            groupBox2 = new GroupBox();
            label4 = new Label();
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            cmboxElementos = new ComboBox();
            label7 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnAgregarStock = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-5, -12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(934, 85);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 32);
            label4.Name = "label4";
            label4.Size = new Size(484, 34);
            label4.TabIndex = 8;
            label4.Text = "AGREGAR STOCK DE ELEMENTO";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(26, 32, 40);
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(766, 509);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 39);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmboxElementos);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregarStock);
            groupBox1.Location = new Point(235, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 323);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // cmboxElementos
            // 
            cmboxElementos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxElementos.FlatStyle = FlatStyle.Flat;
            cmboxElementos.FormattingEnabled = true;
            cmboxElementos.Location = new Point(126, 88);
            cmboxElementos.Name = "cmboxElementos";
            cmboxElementos.Size = new Size(254, 23);
            cmboxElementos.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(145, 33);
            label7.Name = "label7";
            label7.Size = new Size(149, 16);
            label7.TabIndex = 11;
            label7.Text = "DATOS NUEVO STOCK";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(126, 153);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(254, 23);
            txtStock.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 95);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 4;
            label3.Text = "Elemento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 160);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 2;
            label1.Text = "Stock";
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.FlatAppearance.BorderSize = 2;
            btnAgregarStock.FlatStyle = FlatStyle.Flat;
            btnAgregarStock.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarStock.ForeColor = Color.White;
            btnAgregarStock.Location = new Point(156, 224);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(129, 51);
            btnAgregarStock.TabIndex = 4;
            btnAgregarStock.Text = "AGREGAR STOCK";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // AgregarStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(925, 570);
            Controls.Add(groupBox2);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AgregarStock";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += AgregarStock_FormClosing;
            Load += AgregarStock_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private Button btnVolver;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtStock;
        private Label label3;
        private Label label1;
        private Button btnAgregarStock;
        private ComboBox cmboxElementos;
    }
}