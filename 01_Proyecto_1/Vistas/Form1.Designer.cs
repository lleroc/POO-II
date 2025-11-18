namespace _01_Proyecto_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Cargar_Lista = new Button();
            btn_Nuevo_Estudiante = new Button();
            lst_Lista_Estudiantes = new ListBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cargar_Lista
            // 
            btn_Cargar_Lista.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Cargar_Lista.Location = new Point(171, 34);
            btn_Cargar_Lista.Name = "btn_Cargar_Lista";
            btn_Cargar_Lista.Padding = new Padding(5);
            btn_Cargar_Lista.Size = new Size(123, 37);
            btn_Cargar_Lista.TabIndex = 7;
            btn_Cargar_Lista.Text = "Cargar Lista";
            btn_Cargar_Lista.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo_Estudiante
            // 
            btn_Nuevo_Estudiante.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Nuevo_Estudiante.Location = new Point(12, 34);
            btn_Nuevo_Estudiante.Name = "btn_Nuevo_Estudiante";
            btn_Nuevo_Estudiante.Padding = new Padding(5);
            btn_Nuevo_Estudiante.Size = new Size(131, 37);
            btn_Nuevo_Estudiante.TabIndex = 6;
            btn_Nuevo_Estudiante.Text = "Nuevo Estudiante";
            btn_Nuevo_Estudiante.UseVisualStyleBackColor = true;
            btn_Nuevo_Estudiante.Click += btn_Nuevo_Estudiante_Click;
            // 
            // lst_Lista_Estudiantes
            // 
            lst_Lista_Estudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lst_Lista_Estudiantes.FormattingEnabled = true;
            lst_Lista_Estudiantes.ItemHeight = 15;
            lst_Lista_Estudiantes.Location = new Point(19, 12);
            lst_Lista_Estudiantes.Name = "lst_Lista_Estudiantes";
            lst_Lista_Estudiantes.Size = new Size(275, 244);
            lst_Lista_Estudiantes.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(29, 11);
            label1.Margin = new Padding(2, 2, 20, 2);
            label1.Name = "label1";
            label1.Size = new Size(250, 37);
            label1.TabIndex = 5;
            label1.Text = "Lista de Estudiantes";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 68);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(lst_Lista_Estudiantes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 368);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_Nuevo_Estudiante);
            panel3.Controls.Add(btn_Cargar_Lista);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 336);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 100);
            panel3.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 436);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Cargar_Lista;
        private Button btn_Nuevo_Estudiante;
        private ListBox lst_Lista_Estudiantes;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
