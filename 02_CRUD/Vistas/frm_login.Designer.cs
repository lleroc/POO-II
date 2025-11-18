namespace _02_CRUD.Vistas
{
    partial class frm_login
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
            label1 = new Label();
            txt_correo = new TextBox();
            btn_Login1 = new Button();
            txt_contrasenia = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_login2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION";
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Segoe UI", 14F);
            txt_correo.Location = new Point(12, 67);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(207, 32);
            txt_correo.TabIndex = 1;
            txt_correo.Leave += txt_correo_Leave;
            // 
            // btn_Login1
            // 
            btn_Login1.Font = new Font("Segoe UI", 14F);
            btn_Login1.Location = new Point(12, 168);
            btn_Login1.Name = "btn_Login1";
            btn_Login1.Size = new Size(91, 37);
            btn_Login1.TabIndex = 2;
            btn_Login1.Text = "Login 1";
            btn_Login1.UseVisualStyleBackColor = true;
            btn_Login1.Click += btn_Login1_Click;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.Font = new Font("Segoe UI", 14F);
            txt_contrasenia.Location = new Point(12, 130);
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.Size = new Size(207, 32);
            txt_contrasenia.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 5;
            label3.Text = "Correo Electrónico";
            // 
            // btn_login2
            // 
            btn_login2.Font = new Font("Segoe UI", 14F);
            btn_login2.Location = new Point(111, 168);
            btn_login2.Name = "btn_login2";
            btn_login2.Size = new Size(91, 37);
            btn_login2.TabIndex = 6;
            btn_login2.Text = "Login 2";
            btn_login2.UseVisualStyleBackColor = true;
            btn_login2.Click += btn_login2_Click;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 229);
            Controls.Add(btn_login2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_contrasenia);
            Controls.Add(btn_Login1);
            Controls.Add(txt_correo);
            Controls.Add(label1);
            Name = "frm_login";
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_correo;
        private Button btn_Login1;
        private TextBox txt_contrasenia;
        private Label label2;
        private Label label3;
        private Button btn_login2;
    }
}