namespace negsmcprojeto
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
            button1 = new Button();
            button2 = new Button();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblDigiteSuaSenha = new Label();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(45, 348);
            button1.Name = "button1";
            button1.Size = new Size(156, 51);
            button1.TabIndex = 0;
            button1.Text = "Fazer login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(473, 348);
            button2.Name = "button2";
            button2.Size = new Size(166, 51);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(70, 90);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(56, 120);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 6;
            // 
            // lblDigiteSuaSenha
            // 
            lblDigiteSuaSenha.AutoSize = true;
            lblDigiteSuaSenha.Location = new Point(56, 228);
            lblDigiteSuaSenha.Name = "lblDigiteSuaSenha";
            lblDigiteSuaSenha.Size = new Size(93, 15);
            lblDigiteSuaSenha.TabIndex = 5;
            lblDigiteSuaSenha.Text = "Digite sua senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(56, 246);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 19);
            label1.Name = "label1";
            label1.Size = new Size(451, 50);
            label1.TabIndex = 8;
            label1.Text = "ENTRE COM SUA CONTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(388, 246);
            label2.Name = "label2";
            label2.Size = new Size(358, 36);
            label2.TabIndex = 9;
            label2.Text = "Não tem ainda? Cadastre-se!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblDigiteSuaSenha);
            Controls.Add(txtSenha);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblDigiteSuaSenha;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
    }
}
