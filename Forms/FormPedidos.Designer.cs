namespace P2
{
    partial class FormPedidos
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
            txtQuantidade = new TextBox();
            txtCpfCliente = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            lblNomeCliente = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnBuscarCliente = new Button();
            cmbProdutos = new ComboBox();
            label7 = new Label();
            btnAdicionarProduto = new Button();
            btnGravarPedido = new Button();
            lblTotalPedido = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            txtCodigo = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(392, 157);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(142, 27);
            txtQuantidade.TabIndex = 0;
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Location = new Point(99, 142);
            txtCpfCliente.Margin = new Padding(3, 4, 3, 4);
            txtCpfCliente.Mask = "000.000.000-00";
            txtCpfCliente.Name = "txtCpfCliente";
            txtCpfCliente.Size = new Size(141, 27);
            txtCpfCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 2;
            label1.Text = "Montar pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 164);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Quantidade:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(99, 178);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(141, 20);
            lblNomeCliente.TabIndex = 4;
            lblNomeCliente.Text = "----------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 178);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 125);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 6;
            label5.Text = "Produtos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 145);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 7;
            label6.Text = "CPF cliente:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(103, 211);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(138, 27);
            btnBuscarCliente.TabIndex = 8;
            btnBuscarCliente.Text = "Buscar cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(392, 122);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(142, 28);
            cmbProdutos.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 83);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 10;
            label7.Text = "Dados do cliente";
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(392, 191);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(142, 28);
            btnAdicionarProduto.TabIndex = 13;
            btnAdicionarProduto.Text = "Adicionar produto";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // btnGravarPedido
            // 
            btnGravarPedido.Location = new Point(392, 277);
            btnGravarPedido.Name = "btnGravarPedido";
            btnGravarPedido.Size = new Size(142, 27);
            btnGravarPedido.TabIndex = 14;
            btnGravarPedido.Text = "Gravar pedido";
            btnGravarPedido.UseVisualStyleBackColor = true;
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Location = new Point(392, 235);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(147, 20);
            lblTotalPedido.TabIndex = 15;
            lblTotalPedido.Text = "-----------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 235);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 16;
            label8.Text = "Total:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(341, 350);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 84);
            listBox1.TabIndex = 18;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(99, 108);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(142, 27);
            txtCodigo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 112);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 20;
            label3.Text = "Código:";
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 547);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(lblTotalPedido);
            Controls.Add(btnGravarPedido);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(label7);
            Controls.Add(cmbProdutos);
            Controls.Add(btnBuscarCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblNomeCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCpfCliente);
            Controls.Add(txtQuantidade);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormPedidos";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuantidade;
        private MaskedTextBox txtCpfCliente;
        private Label label1;
        private Label label2;
        private Label lblNomeCliente;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnBuscarCliente;
        private ComboBox cmbProdutos;
        private Label label7;
        private Button btnAdicionarProduto;
        private Button btnGravarPedido;
        private Label lblTotalPedido;
        private Label label8;
        private ListBox listBox1;
        private TextBox txtCodigo;
        private Label label3;
    }
}