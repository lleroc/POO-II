namespace Data_Base_firts.Vistas.Usuarios
{
    partial class frm_usuarios
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
            lst_lista_usuarios = new ListBox();
            label1 = new Label();
            txt_nombre = new TextBox();
            btn_nuevo = new Button();
            label2 = new Label();
            label3 = new Label();
            txt_apellido = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            txt_contrasenia = new TextBox();
            chb_estado = new CheckBox();
            label6 = new Label();
            btn_Guardar = new Button();
            btn_editar = new Button();
            btn_cancelar = new Button();
            btn_salir = new Button();
            label7 = new Label();
            cmb_rol = new ComboBox();
            SuspendLayout();
            // 
            // lst_lista_usuarios
            // 
            lst_lista_usuarios.FormattingEnabled = true;
            lst_lista_usuarios.ItemHeight = 15;
            lst_lista_usuarios.Location = new Point(214, 51);
            lst_lista_usuarios.Name = "lst_lista_usuarios";
            lst_lista_usuarios.Size = new Size(193, 259);
            lst_lista_usuarios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE USUARIOS";
            // 
            // txt_nombre
            // 
            txt_nombre.Enabled = false;
            txt_nombre.Location = new Point(12, 69);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(162, 23);
            txt_nombre.TabIndex = 2;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(12, 378);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(75, 23);
            btn_nuevo.TabIndex = 3;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellidos";
            label3.Click += label3_Click;
            // 
            // txt_apellido
            // 
            txt_apellido.Enabled = false;
            txt_apellido.Location = new Point(12, 123);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(162, 23);
            txt_apellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 8;
            label4.Text = "Correo Electronico";
            // 
            // txt_email
            // 
            txt_email.Enabled = false;
            txt_email.Location = new Point(12, 180);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(162, 23);
            txt_email.TabIndex = 7;
            txt_email.Leave += txt_email_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "Contraseña";
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.Enabled = false;
            txt_contrasenia.Location = new Point(12, 229);
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.Size = new Size(162, 23);
            txt_contrasenia.TabIndex = 9;
            // 
            // chb_estado
            // 
            chb_estado.AutoSize = true;
            chb_estado.Enabled = false;
            chb_estado.Location = new Point(13, 329);
            chb_estado.Name = "chb_estado";
            chb_estado.Size = new Size(15, 14);
            chb_estado.TabIndex = 11;
            chb_estado.UseVisualStyleBackColor = true;
            chb_estado.CheckedChanged += chb_estado_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 311);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 12;
            label6.Text = "Estado de Usuario";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Enabled = false;
            btn_Guardar.Location = new Point(91, 378);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(75, 23);
            btn_Guardar.TabIndex = 13;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(172, 378);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 14;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Enabled = false;
            btn_cancelar.Location = new Point(253, 378);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 15;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(334, 378);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 16;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 255);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 17;
            label7.Text = "Rol";
            // 
            // cmb_rol
            // 
            cmb_rol.Enabled = false;
            cmb_rol.FormattingEnabled = true;
            cmb_rol.Location = new Point(12, 273);
            cmb_rol.Name = "cmb_rol";
            cmb_rol.Size = new Size(162, 23);
            cmb_rol.TabIndex = 18;
            // 
            // frm_usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 443);
            Controls.Add(cmb_rol);
            Controls.Add(label7);
            Controls.Add(btn_salir);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_editar);
            Controls.Add(btn_Guardar);
            Controls.Add(label6);
            Controls.Add(chb_estado);
            Controls.Add(label5);
            Controls.Add(txt_contrasenia);
            Controls.Add(label4);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(txt_apellido);
            Controls.Add(label2);
            Controls.Add(btn_nuevo);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(lst_lista_usuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frm_usuarios";
            Text = "frm_usuarios";
            Load += frm_usuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_lista_usuarios;
        private Label label1;
        private TextBox txt_nombre;
        private Button btn_nuevo;
        private Label label2;
        private Label label3;
        private TextBox txt_apellido;
        private Label label4;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_contrasenia;
        private CheckBox chb_estado;
        private Label label6;
        private Button btn_Guardar;
        private Button btn_editar;
        private Button btn_cancelar;
        private Button btn_salir;
        private Label label7;
        private ComboBox cmb_rol;
    }
}