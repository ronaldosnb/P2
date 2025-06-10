namespace P2
{
    partial class FormUsuarios
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
            txtNovoUsuario = new TextBox();
            txtNovaSenha = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAtualizar = new Button();
            txtSenhaAtualizar = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnExcluir = new Button();
            txtUsuarioAtualizar = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            usuario = new Label();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNovoUsuario
            // 
            txtNovoUsuario.Font = new Font("Segoe UI", 10.8F);
            txtNovoUsuario.Location = new Point(29, 82);
            txtNovoUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNovoUsuario.Name = "txtNovoUsuario";
            txtNovoUsuario.Size = new Size(181, 27);
            txtNovoUsuario.TabIndex = 0;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 10.8F);
            txtNovaSenha.Location = new Point(29, 137);
            txtNovaSenha.Margin = new Padding(3, 2, 3, 2);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(181, 27);
            txtNovaSenha.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 10.8F);
            btnCadastrar.Location = new Point(58, 172);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 35);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(29, 58);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(29, 114);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(29, 321);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 10.8F);
            btnAtualizar.Location = new Point(58, 379);
            btnAtualizar.Margin = new Padding(3, 2, 3, 2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(112, 35);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtSenhaAtualizar
            // 
            txtSenhaAtualizar.Font = new Font("Segoe UI", 10.8F);
            txtSenhaAtualizar.Location = new Point(29, 344);
            txtSenhaAtualizar.Margin = new Padding(3, 2, 3, 2);
            txtSenhaAtualizar.Name = "txtSenhaAtualizar";
            txtSenhaAtualizar.Size = new Size(181, 27);
            txtSenhaAtualizar.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(47, 26);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 10;
            label5.Text = "Cadastrar Usuario";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(58, 243);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 11;
            label6.Text = "Atualizar senha";
            label6.Click += label6_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(263, 406);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 26);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioAtualizar
            // 
            txtUsuarioAtualizar.Location = new Point(29, 295);
            txtUsuarioAtualizar.Name = "txtUsuarioAtualizar";
            txtUsuarioAtualizar.Size = new Size(181, 23);
            txtUsuarioAtualizar.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 272);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 15;
            label4.Text = "Usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(263, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 342);
            dataGridView1.TabIndex = 16;
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuario.Location = new Point(263, 26);
            usuario.Name = "usuario";
            usuario.Size = new Size(59, 20);
            usuario.TabIndex = 17;
            usuario.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(444, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 436);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(usuario);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(txtUsuarioAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnAtualizar);
            Controls.Add(txtSenhaAtualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtNovoUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNovoUsuario;
        private TextBox txtNovaSenha;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAtualizar;
        private TextBox txtSenhaAtualizar;
        private Label label5;
        private Label label6;
        private Button btnExcluir;
        private TextBox txtUsuarioAtualizar;
        private Label label4;
        private DataGridView dataGridView1;
        private Label usuario;
        private TextBox textBox1;
        private Button btnBuscar;
    }
}