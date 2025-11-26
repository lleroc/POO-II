namespace _02_CRUD.Vistas.Clientes
{
    partial class frm_agregar_cliente
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
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            label6 = new Label();
            txt_Cedula = new TextBox();
            label5 = new Label();
            txt_Direccion = new TextBox();
            label4 = new Label();
            txt_Correos = new TextBox();
            label3 = new Label();
            txt_Apellidos = new TextBox();
            label2 = new Label();
            chb_Estado = new CheckBox();
            txt_Nombres = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txt_telefono = new TextBox();
            SuspendLayout();
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(11, 168);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(95, 32);
            btn_Salir.TabIndex = 25;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(11, 130);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(95, 32);
            btn_Cancelar.TabIndex = 23;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(11, 92);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(95, 32);
            btn_Guardar.TabIndex = 22;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 311);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 27;
            label6.Text = "Cedula o RUC";
            // 
            // txt_Cedula
            // 
            txt_Cedula.Location = new Point(130, 339);
            txt_Cedula.MaxLength = 10;
            txt_Cedula.Name = "txt_Cedula";
            txt_Cedula.Size = new Size(242, 29);
            txt_Cedula.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 244);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 26;
            label5.Text = "Direccion";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(130, 272);
            txt_Direccion.MaxLength = 50;
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(242, 29);
            txt_Direccion.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 179);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 24;
            label4.Text = "Correo";
            // 
            // txt_Correos
            // 
            txt_Correos.Location = new Point(130, 207);
            txt_Correos.MaxLength = 50;
            txt_Correos.Name = "txt_Correos";
            txt_Correos.Size = new Size(242, 29);
            txt_Correos.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 116);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 20;
            label3.Text = "Apellidos";
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(130, 144);
            txt_Apellidos.MaxLength = 50;
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(242, 29);
            txt_Apellidos.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 53);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 18;
            label2.Text = "Nombres";
            // 
            // chb_Estado
            // 
            chb_Estado.AutoSize = true;
            chb_Estado.Location = new Point(130, 434);
            chb_Estado.Name = "chb_Estado";
            chb_Estado.Size = new Size(75, 25);
            chb_Estado.TabIndex = 21;
            chb_Estado.Text = "Estado";
            chb_Estado.UseVisualStyleBackColor = true;
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(130, 81);
            txt_Nombres.MaxLength = 50;
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(242, 29);
            txt_Nombres.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 23);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 13;
            label1.Text = "AGREGAR CLIENTE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 371);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 29;
            label7.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(130, 399);
            txt_telefono.MaxLength = 10;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(242, 29);
            txt_telefono.TabIndex = 28;
            // 
            // frm_agregar_cliente
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 482);
            Controls.Add(label7);
            Controls.Add(txt_telefono);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(label6);
            Controls.Add(txt_Cedula);
            Controls.Add(label5);
            Controls.Add(txt_Direccion);
            Controls.Add(label4);
            Controls.Add(txt_Correos);
            Controls.Add(label3);
            Controls.Add(txt_Apellidos);
            Controls.Add(label2);
            Controls.Add(chb_Estado);
            Controls.Add(txt_Nombres);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frm_agregar_cliente";
            Text = "Agregar un Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Label label6;
        private TextBox txt_Cedula;
        private Label label5;
        private TextBox txt_Direccion;
        private Label label4;
        private TextBox txt_Correos;
        private Label label3;
        private TextBox txt_Apellidos;
        private Label label2;
        private CheckBox chb_Estado;
        private TextBox txt_Nombres;
        private Label label1;
        private Label label7;
        private TextBox txt_telefono;
    }
}