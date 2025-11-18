namespace _02_CRUD.Vistas.Usuarios
{
    partial class frm_insertar_usuario
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
            btn_Guardar = new Button();
            label1 = new Label();
            txt_Nombres = new TextBox();
            chb_Estado = new CheckBox();
            label2 = new Label();
            txt_Apellidos = new TextBox();
            label3 = new Label();
            txt_Correos = new TextBox();
            label4 = new Label();
            txt_Contrasenia = new TextBox();
            label5 = new Label();
            txt_Cedula = new TextBox();
            label6 = new Label();
            btn_Cancelar = new Button();
            btn_Salir = new Button();
            SuspendLayout();
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(12, 98);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(95, 32);
            btn_Guardar.TabIndex = 7;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 21);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR USUARIOS";
            label1.Click += label1_Click;
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(148, 98);
            txt_Nombres.MaxLength = 50;
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(242, 32);
            txt_Nombres.TabIndex = 1;
            // 
            // chb_Estado
            // 
            chb_Estado.AutoSize = true;
            chb_Estado.Location = new Point(148, 394);
            chb_Estado.Name = "chb_Estado";
            chb_Estado.Size = new Size(87, 29);
            chb_Estado.TabIndex = 6;
            chb_Estado.Text = "Estado";
            chb_Estado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 70);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 4;
            label2.Text = "Nombres";
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(148, 161);
            txt_Apellidos.MaxLength = 50;
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(242, 32);
            txt_Apellidos.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 133);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 6;
            label3.Text = "Apellidos";
            // 
            // txt_Correos
            // 
            txt_Correos.Location = new Point(148, 224);
            txt_Correos.MaxLength = 50;
            txt_Correos.Name = "txt_Correos";
            txt_Correos.Size = new Size(242, 32);
            txt_Correos.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 196);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 8;
            label4.Text = "Correo";
            // 
            // txt_Contrasenia
            // 
            txt_Contrasenia.Location = new Point(148, 289);
            txt_Contrasenia.MaxLength = 50;
            txt_Contrasenia.Name = "txt_Contrasenia";
            txt_Contrasenia.Size = new Size(242, 32);
            txt_Contrasenia.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 261);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 10;
            label5.Text = "Contraseña";
            // 
            // txt_Cedula
            // 
            txt_Cedula.Location = new Point(148, 356);
            txt_Cedula.MaxLength = 10;
            txt_Cedula.Name = "txt_Cedula";
            txt_Cedula.Size = new Size(242, 32);
            txt_Cedula.TabIndex = 5;
            txt_Cedula.Leave += txt_Cedula_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 328);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 12;
            label6.Text = "Cedula";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(12, 136);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(95, 32);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(12, 174);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(95, 32);
            btn_Salir.TabIndex = 9;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // frm_insertar_usuario
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 469);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(label6);
            Controls.Add(txt_Cedula);
            Controls.Add(label5);
            Controls.Add(txt_Contrasenia);
            Controls.Add(label4);
            Controls.Add(txt_Correos);
            Controls.Add(label3);
            Controls.Add(txt_Apellidos);
            Controls.Add(label2);
            Controls.Add(chb_Estado);
            Controls.Add(txt_Nombres);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_insertar_usuario";
            Text = "frm_insertar_usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Guardar;
        private Label label1;
        private TextBox txt_Nombres;
        private CheckBox chb_Estado;
        private Label label2;
        private TextBox txt_Apellidos;
        private Label label3;
        private TextBox txt_Correos;
        private Label label4;
        private TextBox txt_Contrasenia;
        private Label label5;
        private TextBox txt_Cedula;
        private Label label6;
        private Button btn_Cancelar;
        private Button btn_Salir;
    }
}