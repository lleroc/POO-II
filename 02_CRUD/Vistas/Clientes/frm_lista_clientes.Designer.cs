namespace _02_CRUD.Vistas.Clientes
{
    partial class frm_lista_clientes
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
            lst_lista_clientes = new ListBox();
            btn_salir = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            label1 = new Label();
            btn_agregar = new Button();
            SuspendLayout();
            // 
            // lst_lista_clientes
            // 
            lst_lista_clientes.FormattingEnabled = true;
            lst_lista_clientes.ItemHeight = 25;
            lst_lista_clientes.Location = new Point(120, 59);
            lst_lista_clientes.Name = "lst_lista_clientes";
            lst_lista_clientes.Size = new Size(240, 179);
            lst_lista_clientes.TabIndex = 11;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(19, 200);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(95, 41);
            btn_salir.TabIndex = 10;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(19, 153);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(95, 41);
            btn_eliminar.TabIndex = 9;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(19, 106);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(95, 41);
            btn_editar.TabIndex = 7;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.Location = new Point(66, 15);
            label1.Name = "label1";
            label1.Size = new Size(254, 22);
            label1.TabIndex = 8;
            label1.Text = "Centro de Control de Clientes";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(19, 59);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(95, 41);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // frm_lista_clientes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 257);
            Controls.Add(lst_lista_clientes);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(label1);
            Controls.Add(btn_agregar);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frm_lista_clientes";
            Text = "Lista de Cliente";
            Load += frm_lista_clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_lista_clientes;
        private Button btn_salir;
        private Button btn_eliminar;
        private Button btn_editar;
        private Label label1;
        private Button btn_agregar;
    }
}