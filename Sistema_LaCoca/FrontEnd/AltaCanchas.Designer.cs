namespace FrontEnd
{
    partial class AltaCanchas
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
            btnAgregarCancha = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            cmboxTipo = new ComboBox();
            groupBox1 = new GroupBox();
            cmboxCantJugadores = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarCancha
            // 
            btnAgregarCancha.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarCancha.Location = new Point(168, 230);
            btnAgregarCancha.Name = "btnAgregarCancha";
            btnAgregarCancha.Size = new Size(98, 35);
            btnAgregarCancha.TabIndex = 1;
            btnAgregarCancha.Text = "AGREGAR";
            btnAgregarCancha.UseVisualStyleBackColor = true;
            btnAgregarCancha.Click += btnAgregarCancha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 110);
            label1.Name = "label1";
            label1.Size = new Size(31, 16);
            label1.TabIndex = 2;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 158);
            label2.Name = "label2";
            label2.Size = new Size(63, 32);
            label2.TabIndex = 3;
            label2.Text = "Cantidad\r\njugadores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 54);
            label3.Name = "label3";
            label3.Size = new Size(19, 16);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(103, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(214, 23);
            txtID.TabIndex = 5;
            // 
            // cmboxTipo
            // 
            cmboxTipo.FormattingEnabled = true;
            cmboxTipo.Location = new Point(105, 103);
            cmboxTipo.Name = "cmboxTipo";
            cmboxTipo.Size = new Size(214, 23);
            cmboxTipo.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmboxCantJugadores);
            groupBox1.Controls.Add(cmboxTipo);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregarCancha);
            groupBox1.Location = new Point(35, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 317);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // cmboxCantJugadores
            // 
            cmboxCantJugadores.FormattingEnabled = true;
            cmboxCantJugadores.Location = new Point(103, 167);
            cmboxCantJugadores.Name = "cmboxCantJugadores";
            cmboxCantJugadores.Size = new Size(214, 23);
            cmboxCantJugadores.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(357, 399);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 7;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(127, 36);
            label4.Name = "label4";
            label4.Size = new Size(239, 24);
            label4.TabIndex = 8;
            label4.Text = "DATOS NUEVA CANCHA";
            // 
            // AltaCanchas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 446);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "AltaCanchas";
            Text = "AltaCanchas";
            Load += AltaCanchas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregarCancha;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private ComboBox cmboxTipo;
        private GroupBox groupBox1;
        private Button button1;
        private Label label4;
        private ComboBox cmboxCantJugadores;
    }
}