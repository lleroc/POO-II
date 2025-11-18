namespace _01_Proyecto_1.Vistas.Docentes
{
    partial class Lista_Docentes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(191, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 0;
            label1.Text = "Lista de Docentes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 359);
            dataGridView1.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_buscar.Location = new Point(382, 58);
            btn_buscar.Margin = new Padding(5);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(80, 32);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_buscar.Location = new Point(5, 59);
            txt_buscar.Margin = new Padding(5);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(367, 32);
            txt_buscar.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_buscar);
            panel1.Controls.Add(txt_buscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 96);
            panel1.TabIndex = 4;
            // 
            // Lista_Docentes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Lista_Docentes";
            Size = new Size(523, 359);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_buscar;
        private TextBox txt_buscar;
        private Panel panel1;
    }
}
