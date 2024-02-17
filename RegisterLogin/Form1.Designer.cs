namespace RegisterLogin
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
            label1 = new Label();
            labelUsuario = new Label();
            panel1 = new Panel();
            txtUsuario = new TextBox();
            panel2 = new Panel();
            txtPassword = new TextBox();
            labelContraseña = new Label();
            buttonIngresar = new Button();
            panel3 = new Panel();
            labelRegistro = new Label();
            panel4 = new Panel();
            txtRegUsuario = new TextBox();
            labelRegistroUsuario = new Label();
            panel5 = new Panel();
            txtNombre = new TextBox();
            labelNombre = new Label();
            panel6 = new Panel();
            txtEmail = new TextBox();
            labelEmail = new Label();
            panel7 = new Panel();
            txtCedula = new TextBox();
            labelCedula = new Label();
            panel8 = new Panel();
            txtRegPassword = new TextBox();
            labelRegistroPassword = new Label();
            panel9 = new Panel();
            txtComPassword = new TextBox();
            label2 = new Label();
            buttonRegistro = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(52, 26);
            label1.Name = "label1";
            label1.Size = new Size(87, 26);
            label1.TabIndex = 0;
            label1.Text = "Ingresar";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Constantia", 12F);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(30, 16);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(68, 19);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(12, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 46);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(104, 12);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(134, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(labelContraseña);
            panel2.Location = new Point(12, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 46);
            panel2.TabIndex = 2;
            panel2.Paint += panel1_Paint;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(104, 12);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(134, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Constantia", 12F);
            labelContraseña.ForeColor = Color.White;
            labelContraseña.Location = new Point(13, 12);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(92, 19);
            labelContraseña.TabIndex = 1;
            labelContraseña.Text = "Contraseña:";
            // 
            // buttonIngresar
            // 
            buttonIngresar.Cursor = Cursors.Hand;
            buttonIngresar.FlatStyle = FlatStyle.System;
            buttonIngresar.Font = new Font("Constantia", 16F);
            buttonIngresar.Location = new Point(90, 212);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(102, 36);
            buttonIngresar.TabIndex = 3;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(294, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 439);
            panel3.TabIndex = 4;
            // 
            // labelRegistro
            // 
            labelRegistro.AutoSize = true;
            labelRegistro.Font = new Font("Constantia", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelRegistro.ForeColor = SystemColors.ButtonFace;
            labelRegistro.Location = new Point(366, 26);
            labelRegistro.Name = "labelRegistro";
            labelRegistro.Size = new Size(113, 26);
            labelRegistro.TabIndex = 5;
            labelRegistro.Text = "Registrarse";
            labelRegistro.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSeaGreen;
            panel4.Controls.Add(txtRegUsuario);
            panel4.Controls.Add(labelRegistroUsuario);
            panel4.Location = new Point(327, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 46);
            panel4.TabIndex = 2;
            panel4.Paint += panel1_Paint;
            // 
            // txtRegUsuario
            // 
            txtRegUsuario.Cursor = Cursors.IBeam;
            txtRegUsuario.Location = new Point(104, 12);
            txtRegUsuario.Multiline = true;
            txtRegUsuario.Name = "txtRegUsuario";
            txtRegUsuario.Size = new Size(134, 23);
            txtRegUsuario.TabIndex = 2;
            txtRegUsuario.TextChanged += textBox1_TextChanged;
            // 
            // labelRegistroUsuario
            // 
            labelRegistroUsuario.AutoSize = true;
            labelRegistroUsuario.Font = new Font("Constantia", 12F);
            labelRegistroUsuario.ForeColor = Color.White;
            labelRegistroUsuario.Location = new Point(30, 16);
            labelRegistroUsuario.Name = "labelRegistroUsuario";
            labelRegistroUsuario.Size = new Size(68, 19);
            labelRegistroUsuario.TabIndex = 1;
            labelRegistroUsuario.Text = "Usuario:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSeaGreen;
            panel5.Controls.Add(txtNombre);
            panel5.Controls.Add(labelNombre);
            panel5.Location = new Point(327, 144);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 46);
            panel5.TabIndex = 2;
            panel5.Paint += panel1_Paint;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(104, 12);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(134, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Constantia", 12F);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(18, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(80, 38);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre\r\ncompleto:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSeaGreen;
            panel6.Controls.Add(txtEmail);
            panel6.Controls.Add(labelEmail);
            panel6.Location = new Point(327, 196);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 46);
            panel6.TabIndex = 2;
            panel6.Paint += panel1_Paint;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(104, 12);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(134, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Constantia", 12F);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(30, 16);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 19);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightSeaGreen;
            panel7.Controls.Add(txtCedula);
            panel7.Controls.Add(labelCedula);
            panel7.Location = new Point(327, 248);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 46);
            panel7.TabIndex = 2;
            panel7.Paint += panel1_Paint;
            // 
            // txtCedula
            // 
            txtCedula.Cursor = Cursors.IBeam;
            txtCedula.Location = new Point(104, 12);
            txtCedula.Multiline = true;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(134, 23);
            txtCedula.TabIndex = 2;
            txtCedula.TextChanged += textBox1_TextChanged;
            // 
            // labelCedula
            // 
            labelCedula.AutoSize = true;
            labelCedula.Font = new Font("Constantia", 12F);
            labelCedula.ForeColor = Color.White;
            labelCedula.Location = new Point(30, 16);
            labelCedula.Name = "labelCedula";
            labelCedula.Size = new Size(36, 19);
            labelCedula.TabIndex = 1;
            labelCedula.Text = "C.I.:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightSeaGreen;
            panel8.Controls.Add(txtRegPassword);
            panel8.Controls.Add(labelRegistroPassword);
            panel8.Location = new Point(327, 300);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 46);
            panel8.TabIndex = 2;
            panel8.Paint += panel1_Paint;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Cursor = Cursors.IBeam;
            txtRegPassword.Location = new Point(104, 12);
            txtRegPassword.Multiline = true;
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(134, 23);
            txtRegPassword.TabIndex = 2;
            txtRegPassword.TextChanged += textBox1_TextChanged;
            // 
            // labelRegistroPassword
            // 
            labelRegistroPassword.AutoSize = true;
            labelRegistroPassword.Font = new Font("Constantia", 12F);
            labelRegistroPassword.ForeColor = Color.White;
            labelRegistroPassword.Location = new Point(10, 12);
            labelRegistroPassword.Name = "labelRegistroPassword";
            labelRegistroPassword.Size = new Size(92, 19);
            labelRegistroPassword.TabIndex = 1;
            labelRegistroPassword.Text = "Contraseña:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightSeaGreen;
            panel9.Controls.Add(txtComPassword);
            panel9.Controls.Add(label2);
            panel9.Location = new Point(327, 352);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 46);
            panel9.TabIndex = 2;
            panel9.Paint += panel1_Paint;
            // 
            // txtComPassword
            // 
            txtComPassword.Cursor = Cursors.IBeam;
            txtComPassword.Location = new Point(104, 12);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.Size = new Size(134, 23);
            txtComPassword.TabIndex = 2;
            txtComPassword.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 12);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "Confirmar:";
            // 
            // buttonRegistro
            // 
            buttonRegistro.Cursor = Cursors.Hand;
            buttonRegistro.FlatStyle = FlatStyle.System;
            buttonRegistro.Font = new Font("Constantia", 16F);
            buttonRegistro.Location = new Point(404, 404);
            buttonRegistro.Name = "buttonRegistro";
            buttonRegistro.Size = new Size(123, 36);
            buttonRegistro.TabIndex = 3;
            buttonRegistro.Text = "Registrarse";
            buttonRegistro.UseVisualStyleBackColor = true;
            buttonRegistro.Click += buttonRegistro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(618, 464);
            Controls.Add(labelRegistro);
            Controls.Add(panel3);
            Controls.Add(buttonRegistro);
            Controls.Add(buttonIngresar);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login & Registro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelUsuario;
        private Panel panel1;
        private TextBox txtUsuario;
        private Panel panel2;
        private TextBox txtPassword;
        private Label labelContraseña;
        private Button buttonIngresar;
        private Panel panel3;
        private Label labelRegistro;
        private Panel panel4;
        private TextBox txtRegUsuario;
        private Label labelRegistroUsuario;
        private Panel panel5;
        private TextBox txtNombre;
        private Label labelNombre;
        private Panel panel6;
        private TextBox txtEmail;
        private Label labelEmail;
        private Panel panel7;
        private TextBox txtCedula;
        private Label labelCedula;
        private Panel panel8;
        private TextBox txtRegPassword;
        private Label labelRegistroPassword;
        private Panel panel9;
        private TextBox txtComPassword;
        private Label label2;
        private Button buttonRegistro;
    }
}
