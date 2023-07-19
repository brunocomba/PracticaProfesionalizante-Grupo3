namespace FrontEnd
{
    partial class MenuInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnAdministradores = new Button();
            btnClientes = new Button();
            btnTurnos = new Button();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 58);
            label1.TabIndex = 0;
            label1.Text = "MENU DE\r\nOPCIONES";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateBlue;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnAdministradores);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnTurnos);
            groupBox1.Location = new Point(-4, -8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 675);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(27, 244);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(118, 34);
            button1.TabIndex = 8;
            button1.Text = "Canchas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Frontend.Properties.Resources.LaCoca;
            pictureBox1.Location = new Point(0, 556);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnAdministradores
            // 
            btnAdministradores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministradores.Location = new Point(16, 447);
            btnAdministradores.Name = "btnAdministradores";
            btnAdministradores.RightToLeft = RightToLeft.Yes;
            btnAdministradores.Size = new Size(141, 36);
            btnAdministradores.TabIndex = 7;
            btnAdministradores.Text = "Administradores";
            btnAdministradores.UseVisualStyleBackColor = true;
            btnAdministradores.Click += btnAdministradores_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Location = new Point(27, 349);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(118, 34);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTurnos.Location = new Point(27, 148);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(118, 32);
            btnTurnos.TabIndex = 2;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSlateBlue;
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(-4, -8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1041, 106);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(779, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 661);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MenuInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MenuInicio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnTurnos;
        private Button btnClientes;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        public Button btnAdministradores;
        public Button button1;
    }
}