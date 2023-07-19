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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCanchas));
            groupBox1 = new GroupBox();
            label1 = new Label();
            panel2 = new Panel();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            canchaBindingSource = new BindingSource(components);
            btnVolver = new Button();
            canchaBindingSource1 = new BindingSource(components);
            canchaBindingSource2 = new BindingSource(components);
            canchaBindingSource3 = new BindingSource(components);
            canchaBindingSource4 = new BindingSource(components);
            canchaBindingSource5 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantJugadoresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1095, 79);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 31);
            label1.Name = "label1";
            label1.Size = new Size(490, 35);
            label1.TabIndex = 0;
            label1.Text = "LISTA CANCHAS REGISTRADAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 596);
            panel2.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(17, 85);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 44);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(17, 194);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 44);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(17, 307);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 44);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // canchaBindingSource
            // 
            canchaBindingSource.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(855, 605);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 44);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // canchaBindingSource1
            // 
            canchaBindingSource1.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource2
            // 
            canchaBindingSource2.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource3
            // 
            canchaBindingSource3.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource4
            // 
            canchaBindingSource4.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // canchaBindingSource5
            // 
            canchaBindingSource5.DataSource = typeof(LogicaClases.Clases.Cancha);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, cantJugadoresDataGridViewTextBoxColumn });
            dataGridView1.DataSource = canchaBindingSource;
            dataGridView1.Location = new Point(275, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(594, 461);
            dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.FillWeight = 72.33274F;
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.FillWeight = 102.898338F;
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 142;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            tipoDataGridViewTextBoxColumn.FillWeight = 111.283768F;
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.Width = 154;
            // 
            // cantJugadoresDataGridViewTextBoxColumn
            // 
            cantJugadoresDataGridViewTextBoxColumn.DataPropertyName = "cantJugadores";
            cantJugadoresDataGridViewTextBoxColumn.FillWeight = 113.485191F;
            cantJugadoresDataGridViewTextBoxColumn.HeaderText = "Cantidad de jugadores";
            cantJugadoresDataGridViewTextBoxColumn.Name = "cantJugadoresDataGridViewTextBoxColumn";
            cantJugadoresDataGridViewTextBoxColumn.Width = 157;
            // 
            // ListaCanchas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 661);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaCanchas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ListaCanchas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)canchaBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Panel panel2;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private BindingSource canchaBindingSource;
        private Button btnVolver;
        private BindingSource canchaBindingSource2;
        private BindingSource canchaBindingSource1;
        private BindingSource canchaBindingSource3;
        private BindingSource canchaBindingSource4;
        private BindingSource canchaBindingSource5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantJugadoresDataGridViewTextBoxColumn;
    }
}