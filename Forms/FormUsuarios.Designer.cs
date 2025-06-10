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
            label5 = new Label();
            btnExcluir = new Button();
            dataUsuarios = new DataGridView();
            usuario = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnAtualizarSenha = new Button();
            txtSenhaAtualizar = new TextBox();
            txtUsuarioAtualizar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNovoUsuario
            // 
            txtNovoUsuario.Font = new Font("Segoe UI", 10.8F);
            txtNovoUsuario.Location = new Point(40, 122);
            txtNovoUsuario.Name = "txtNovoUsuario";
            txtNovoUsuario.Size = new Size(206, 31);
            txtNovoUsuario.TabIndex = 0;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 10.8F);
            txtNovaSenha.Location = new Point(40, 195);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(206, 31);
            txtNovaSenha.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 10.8F);
            btnCadastrar.Location = new Point(73, 242);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 47);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(40, 90);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(40, 165);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(60, 47);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 10;
            label5.Text = "Cadastrar Usuario";
            label5.Click += label5_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(301, 541);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(114, 35);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataUsuarios
            // 
            dataUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsuarios.Location = new Point(301, 77);
            dataUsuarios.Margin = new Padding(3, 4, 3, 4);
            dataUsuarios.Name = "dataUsuarios";
            dataUsuarios.ReadOnly = true;
            dataUsuarios.RowHeadersWidth = 51;
            dataUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataUsuarios.Size = new Size(624, 456);
            dataUsuarios.TabIndex = 16;
            dataUsuarios.CellClick += dataUsuarios_CellClick;
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuario.Location = new Point(301, 35);
            usuario.Name = "usuario";
            usuario.Size = new Size(77, 25);
            usuario.TabIndex = 17;
            usuario.Text = "Usuario";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(375, 31);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(114, 27);
            txtBuscar.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(507, 31);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(60, 312);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 25;
            label3.Text = "Atualizar senha ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(40, 430);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 24;
            label4.Text = "Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(40, 355);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 23;
            label6.Text = "Usuario";
            // 
            // btnAtualizarSenha
            // 
            btnAtualizarSenha.Font = new Font("Segoe UI", 10.8F);
            btnAtualizarSenha.Location = new Point(60, 507);
            btnAtualizarSenha.Name = "btnAtualizarSenha";
            btnAtualizarSenha.Size = new Size(162, 47);
            btnAtualizarSenha.TabIndex = 22;
            btnAtualizarSenha.Text = "Atualizar senha";
            btnAtualizarSenha.UseVisualStyleBackColor = true;
            btnAtualizarSenha.Click += btnAtualizarSenha_Click;
            // 
            // txtSenhaAtualizar
            // 
            txtSenhaAtualizar.Font = new Font("Segoe UI", 10.8F);
            txtSenhaAtualizar.Location = new Point(40, 460);
            txtSenhaAtualizar.Name = "txtSenhaAtualizar";
            txtSenhaAtualizar.Size = new Size(206, 31);
            txtSenhaAtualizar.TabIndex = 21;
            // 
            // txtUsuarioAtualizar
            // 
            txtUsuarioAtualizar.Font = new Font("Segoe UI", 10.8F);
            txtUsuarioAtualizar.Location = new Point(40, 387);
            txtUsuarioAtualizar.Name = "txtUsuarioAtualizar";
            txtUsuarioAtualizar.ReadOnly = true;
            txtUsuarioAtualizar.Size = new Size(206, 31);
            txtUsuarioAtualizar.TabIndex = 20;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 581);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(btnAtualizarSenha);
            Controls.Add(txtSenhaAtualizar);
            Controls.Add(txtUsuarioAtualizar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(usuario);
            Controls.Add(dataUsuarios);
            Controls.Add(btnExcluir);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtNovoUsuario);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNovoUsuario;
        private TextBox txtNovaSenha;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label5;
        private Button btnExcluir;
        private DataGridView dataUsuarios;
        private Label usuario;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnAtualizarSenha;
        private TextBox txtSenhaAtualizar;
        private TextBox txtUsuarioAtualizar;
    }
}