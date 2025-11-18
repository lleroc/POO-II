namespace _02_CRUD.Vistas.Usuarios
{
    partial class frm_lista_usuarios
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
            btn_agregar = new Button();
            label1 = new Label();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            lst_lista_usuarios = new ListBox();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(12, 53);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(95, 41);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 22);
            label1.TabIndex = 2;
            label1.Text = "Centro de Control de Usuarios";
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(12, 100);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(95, 41);
            btn_editar.TabIndex = 2;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(12, 147);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(95, 41);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 194);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(95, 41);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // lst_lista_usuarios
            // 
            lst_lista_usuarios.FormattingEnabled = true;
            lst_lista_usuarios.ItemHeight = 21;
            lst_lista_usuarios.Location = new Point(113, 53);
            lst_lista_usuarios.Name = "lst_lista_usuarios";
            lst_lista_usuarios.Size = new Size(240, 193);
            lst_lista_usuarios.TabIndex = 5;
            // 
            // frm_lista_usuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 262);
            Controls.Add(lst_lista_usuarios);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(label1);
            Controls.Add(btn_agregar);
            Font = new Font("Times New Roman", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "frm_lista_usuarios";
            Text = "Usuarios ";
            Load += frm_lista_usuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregar;
        private Label label1;
        private Button btn_editar;
        private Button btn_eliminar;
        private Button btn_salir;
        private ListBox lst_lista_usuarios;
    }
}