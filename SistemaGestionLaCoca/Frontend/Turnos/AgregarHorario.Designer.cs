namespace Frontend.Turnos
{
    partial class AgregarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarHorario));
            groupBox2 = new GroupBox();
            label4 = new Label();
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            cmboxDeporte = new ComboBox();
            label7 = new Label();
            txtHorario = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnAgregarElemento = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-5, -17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(934, 91);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(341, 42);
            label4.Name = "label4";
            label4.Size = new Size(261, 34);
            label4.TabIndex = 8;
            label4.Text = "NUEVO HORARIO";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(26, 32, 40);
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.AppWorkspace;
            btnVolver.Location = new Point(766, 513);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 36);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmboxDeporte);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtHorario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregarElemento);
            groupBox1.Location = new Point(235, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 329);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // cmboxDeporte
            // 
            cmboxDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxDeporte.FlatStyle = FlatStyle.Flat;
            cmboxDeporte.FormattingEnabled = true;
            cmboxDeporte.Location = new Point(126, 88);
            cmboxDeporte.Name = "cmboxDeporte";
            cmboxDeporte.Size = new Size(254, 23);
            cmboxDeporte.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(140, 29);
            label7.Name = "label7";
            label7.Size = new Size(164, 16);
            label7.TabIndex = 11;
            label7.Text = "DATOS NUEVO HORARIO";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(126, 153);
            txtHorario.MaxLength = 5;
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(254, 23);
            txtHorario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 95);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 4;
            label3.Text = "Deporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 160);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 2;
            label1.Text = "Horario";
            // 
            // btnAgregarElemento
            // 
            btnAgregarElemento.FlatAppearance.BorderSize = 2;
            btnAgregarElemento.FlatStyle = FlatStyle.Flat;
            btnAgregarElemento.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarElemento.ForeColor = Color.White;
            btnAgregarElemento.Location = new Point(156, 224);
            btnAgregarElemento.Name = "btnAgregarElemento";
            btnAgregarElemento.Size = new Size(129, 41);
            btnAgregarElemento.TabIndex = 4;
            btnAgregarElemento.Text = "AGREGAR";
            btnAgregarElemento.UseVisualStyleBackColor = true;
            btnAgregarElemento.Click += btnAgregarElemento_Click;
            // 
            // AgregarHorario
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
            Name = "AgregarHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AgregarHorario_Load;
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
        private TextBox txtHorario;
        private Label label3;
        private Label label1;
        private Button btnAgregarElemento;
        private ComboBox cmboxDeporte;
    }
}