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
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNovoUsuario
            // 
            txtNovoUsuario.Font = new Font("Segoe UI", 10.8F);
            txtNovoUsuario.Location = new Point(27, 189);
            txtNovoUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNovoUsuario.Name = "txtNovoUsuario";
            txtNovoUsuario.Size = new Size(181, 27);
            txtNovoUsuario.TabIndex = 0;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 10.8F);
            txtNovaSenha.Location = new Point(27, 244);
            txtNovaSenha.Margin = new Padding(3, 2, 3, 2);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(181, 27);
            txtNovaSenha.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 10.8F);
            btnCadastrar.Location = new Point(56, 279);
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
            label1.Location = new Point(27, 165);
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
            label2.Location = new Point(27, 221);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(45, 133);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 10;
            label5.Text = "Cadastrar Usuario";
            label5.Click += label5_Click;
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
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataUsuarios
            // 
            dataUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsuarios.Location = new Point(263, 58);
            dataUsuarios.Name = "dataUsuarios";
            dataUsuarios.ReadOnly = true;
            dataUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataUsuarios.Size = new Size(546, 342);
            dataUsuarios.TabIndex = 16;
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
            // txtBuscar
            // 
            txtBuscar.Location = new Point(328, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(444, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 436);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}