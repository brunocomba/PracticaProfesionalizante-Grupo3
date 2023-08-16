namespace Frontend
{
    partial class AltaNuevosHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaNuevosHorarios));
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            dateTimePicker3 = new DateTimePicker();
            btnAgregarCancha = new Button();
            btnAddHorarios = new Button();
            cmboxCancha = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            horarioBindingSource = new BindingSource(components);
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)horarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-2, -10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(811, 83);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(161, 32);
            label4.Name = "label4";
            label4.Size = new Size(512, 32);
            label4.TabIndex = 8;
            label4.Text = "NUEVOS HORARIOS PARA RESERVAR";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(btnAgregarCancha);
            groupBox1.Controls.Add(btnAddHorarios);
            groupBox1.Controls.Add(cmboxCancha);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(32, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 325);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 133);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 21;
            label1.Text = "Horario";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(105, 128);
            dateTimePicker3.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePicker3.MinDate = new DateTime(2023, 8, 13, 0, 0, 0, 0);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(214, 21);
            dateTimePicker3.TabIndex = 20;
            dateTimePicker3.Value = new DateTime(2023, 8, 13, 16, 0, 0, 0);
            dateTimePicker3.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // btnAgregarCancha
            // 
            btnAgregarCancha.FlatAppearance.BorderSize = 2;
            btnAgregarCancha.FlatStyle = FlatStyle.Flat;
            btnAgregarCancha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCancha.ForeColor = Color.White;
            btnAgregarCancha.Location = new Point(127, 193);
            btnAgregarCancha.Name = "btnAgregarCancha";
            btnAgregarCancha.Size = new Size(112, 35);
            btnAgregarCancha.TabIndex = 4;
            btnAgregarCancha.Text = "AGREGAR";
            btnAgregarCancha.UseVisualStyleBackColor = true;
            btnAgregarCancha.Click += btnAgregarCancha_Click;
            // 
            // btnAddHorarios
            // 
            btnAddHorarios.BackColor = Color.FromArgb(26, 32, 40);
            btnAddHorarios.FlatStyle = FlatStyle.Popup;
            btnAddHorarios.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddHorarios.ForeColor = Color.White;
            btnAddHorarios.Location = new Point(338, 72);
            btnAddHorarios.Name = "btnAddHorarios";
            btnAddHorarios.Size = new Size(32, 28);
            btnAddHorarios.TabIndex = 19;
            btnAddHorarios.Text = "+";
            btnAddHorarios.UseVisualStyleBackColor = false;
            btnAddHorarios.Click += btnAddHorarios_Click;
            // 
            // cmboxCancha
            // 
            cmboxCancha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxCancha.FlatStyle = FlatStyle.Flat;
            cmboxCancha.FormattingEnabled = true;
            cmboxCancha.Location = new Point(105, 77);
            cmboxCancha.Name = "cmboxCancha";
            cmboxCancha.Size = new Size(214, 23);
            cmboxCancha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 3;
            label2.Text = "Cancha";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(671, 403);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 13;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // horarioBindingSource
            // 
            horarioBindingSource.DataSource = typeof(Logica.Clases.Horario);
            // 
            // AltaNuevosHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AltaNuevosHorarios";
            Load += AltaNuevosHorarios_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)horarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnAddHorarios;
        private Button btnAgregarCancha;
        private ComboBox cmboxCancha;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker3;
        private Button button1;
        private BindingSource horarioBindingSource;
    }
}