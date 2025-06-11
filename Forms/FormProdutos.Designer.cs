namespace P2
{
    partial class FormProdutos
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
            dataProdutos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btncadastrar = new Button();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            txtNome = new TextBox();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            label4 = new Label();
            txtCodigo = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataProdutos
            // 
            dataProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProdutos.Location = new Point(326, 56);
            dataProdutos.Name = "dataProdutos";
            dataProdutos.Size = new Size(462, 340);
            dataProdutos.TabIndex = 0;
            dataProdutos.CellContentClick += dataProdutos_CellContentClick;
            dataProdutos.SelectionChanged += dataProdutos_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(10, 158);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(10, 122);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(10, 92);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 3;
            label3.Text = "Nome do produto ";
            // 
            // btncadastrar
            // 
            btncadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncadastrar.Location = new Point(10, 197);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(91, 35);
            btncadastrar.TabIndex = 4;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 11.25F);
            txtDescricao.Location = new Point(82, 155);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(236, 27);
            txtDescricao.TabIndex = 5;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 11.25F);
            txtPreco.Location = new Point(53, 122);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(265, 27);
            txtPreco.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F);
            txtNome.Location = new Point(138, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 27);
            txtNome.TabIndex = 7;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(326, 402);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 36);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += button2_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(107, 197);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(91, 35);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 9);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 11;
            label4.Text = "CRUD PRODUTOS";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(74, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(244, 23);
            txtCodigo.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(10, 59);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 13;
            label5.Text = "Codigo";
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(txtNome);
            Controls.Add(txtPreco);
            Controls.Add(txtDescricao);
            Controls.Add(btncadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataProdutos);
            Name = "FormProdutos";
            Text = "FormProdutos";
            Load += FormProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataProdutos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btncadastrar;
        private TextBox txtDescricao;
        private TextBox txtPreco;
        private TextBox txtNome;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Label label4;
        private TextBox txtCodigo;
        private Label label5;
    }
}