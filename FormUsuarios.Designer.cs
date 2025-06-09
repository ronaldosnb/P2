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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAtualizar = new Button();
            txtAtualizar = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10.8F);
            txtUsuario.Location = new Point(29, 82);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(181, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 10.8F);
            txtSenha.Location = new Point(29, 137);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(181, 27);
            txtSenha.TabIndex = 1;
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
            label3.Location = new Point(29, 308);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 10.8F);
            btnAtualizar.Location = new Point(58, 366);
            btnAtualizar.Margin = new Padding(3, 2, 3, 2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(112, 35);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtAtualizar
            // 
            txtAtualizar.Font = new Font("Segoe UI", 10.8F);
            txtAtualizar.Location = new Point(29, 331);
            txtAtualizar.Margin = new Padding(3, 2, 3, 2);
            txtAtualizar.Name = "txtAtualizar";
            txtAtualizar.Size = new Size(181, 27);
            txtAtualizar.TabIndex = 6;
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
            label6.Location = new Point(58, 278);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 11;
            label6.Text = "Atualizar senha";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(263, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(546, 392);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(263, 406);
            button1.Name = "button1";
            button1.Size = new Size(100, 26);
            button1.TabIndex = 13;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 436);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnAtualizar);
            Controls.Add(txtAtualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAtualizar;
        private TextBox txtAtualizar;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button1;
    }
}