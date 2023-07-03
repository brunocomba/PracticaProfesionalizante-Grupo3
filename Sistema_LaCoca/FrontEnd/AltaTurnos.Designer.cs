namespace FrontEnd
{
    partial class AltaTurnos
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
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(172, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2023, 7, 3, 0, 0, 0, 0);
            // 
            // AltaTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(dateTimePicker1);
            Name = "AltaTurnos";
            Text = "AltaTurnos";
            Load += AltaTurnos_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
    }
}