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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(131, 62);
            label1.TabIndex = 0;
            label1.Text = "MENU DE\r\nOPCIONES";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateBlue;
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(-4, -8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 475);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(16, 129);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 2;
            button1.Text = "Turnos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(16, 204);
            button5.Name = "button5";
            button5.Size = new Size(118, 29);
            button5.TabIndex = 6;
            button5.Text = "Clientes";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(16, 282);
            button6.Name = "button6";
            button6.Size = new Size(118, 29);
            button6.TabIndex = 7;
            button6.Text = "Administradores";
            button6.UseVisualStyleBackColor = true;
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(groupBox1);
            Name = "MenuInicio";
            Text = "MenuInicio";
            Load += MenuInicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button6;
        private Button button5;
    }
}