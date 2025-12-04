namespace Data_Base_firts.Vistas.Clientes
{
    partial class frm_clientes
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
            btn_eliminar = new Button();
            label7 = new Label();
            btn_salir = new Button();
            btn_cancelar = new Button();
            btn_editar = new Button();
            btn_Guardar = new Button();
            label5 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_apellido = new TextBox();
            label2 = new Label();
            btn_nuevo = new Button();
            txt_nombre = new TextBox();
            label1 = new Label();
            lst_lista_clientes = new ListBox();
            txt_direccion = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_eliminar
            // 
            btn_eliminar.ForeColor = Color.DarkRed;
            btn_eliminar.Location = new Point(123, 406);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(102, 36);
            btn_eliminar.TabIndex = 39;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 291);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 37;
            label7.Text = "Dieccion";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(230, 406);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(102, 36);
            btn_salir.TabIndex = 36;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Enabled = false;
            btn_cancelar.Location = new Point(18, 406);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(102, 36);
            btn_cancelar.TabIndex = 35;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(230, 364);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(102, 36);
            btn_editar.TabIndex = 34;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Enabled = false;
            btn_Guardar.Location = new Point(123, 364);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(102, 36);
            btn_Guardar.TabIndex = 33;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 30;
            label5.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.Enabled = false;
            txt_telefono.Location = new Point(12, 256);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(189, 32);
            txt_telefono.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 28;
            label4.Text = "Correo Electronico";
            // 
            // txt_email
            // 
            txt_email.Enabled = false;
            txt_email.Location = new Point(12, 193);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(189, 32);
            txt_email.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 26;
            label3.Text = "Apellidos";
            // 
            // txt_apellido
            // 
            txt_apellido.Enabled = false;
            txt_apellido.Location = new Point(12, 130);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(189, 32);
            txt_apellido.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 24;
            label2.Text = "Nombres";
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(18, 364);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(102, 36);
            btn_nuevo.TabIndex = 23;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Enabled = false;
            txt_nombre.Location = new Point(12, 67);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(189, 32);
            txt_nombre.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(117, 7);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 21;
            label1.Text = "GESTION DE CLIENTES";
            // 
            // lst_lista_clientes
            // 
            lst_lista_clientes.FormattingEnabled = true;
            lst_lista_clientes.ItemHeight = 25;
            lst_lista_clientes.Location = new Point(214, 49);
            lst_lista_clientes.Name = "lst_lista_clientes";
            lst_lista_clientes.Size = new Size(220, 304);
            lst_lista_clientes.TabIndex = 20;
            // 
            // txt_direccion
            // 
            txt_direccion.Enabled = false;
            txt_direccion.Location = new Point(12, 319);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(189, 32);
            txt_direccion.TabIndex = 40;
            // 
            // button1
            // 
            button1.Location = new Point(338, 364);
            button1.Name = "button1";
            button1.Size = new Size(102, 78);
            button1.TabIndex = 41;
            button1.Text = "Exportar Clientes";
            button1.UseVisualStyleBackColor = true;
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 466);
            Controls.Add(button1);
            Controls.Add(txt_direccion);
            Controls.Add(btn_eliminar);
            Controls.Add(label7);
            Controls.Add(btn_salir);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_editar);
            Controls.Add(btn_Guardar);
            Controls.Add(label5);
            Controls.Add(txt_telefono);
            Controls.Add(label4);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(txt_apellido);
            Controls.Add(label2);
            Controls.Add(btn_nuevo);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(lst_lista_clientes);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frm_clientes";
            Text = "Clientes";
            Load += frm_clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_eliminar;
        private ComboBox cmb_rol;
        private Label label7;
        private Button btn_salir;
        private Button btn_cancelar;
        private Button btn_editar;
        private Button btn_Guardar;
        private Label label5;
        private TextBox txt_telefono;
        private Label label4;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_apellido;
        private Label label2;
        private Button btn_nuevo;
        private TextBox txt_nombre;
        private Label label1;
        private ListBox lst_lista_clientes;
        private TextBox txt_direccion;
        private Button button1;
    }
}