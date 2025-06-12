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
            mskCpf = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            lblNomeCliente = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnBuscarCliente = new Button();
            label7 = new Label();
            btnAdicionarProduto = new Button();
            btnSalvarPedido = new Button();
            lblTotalPedido = new Label();
            label8 = new Label();
            txtCodigoPedido = new TextBox();
            label3 = new Label();
            dataGridItens = new DataGridView();
            txtCodigoProduto = new TextBox();
            dataProdutos = new DataGridView();
            pedido = new Label();
            label10 = new Label();
            label11 = new Label();
            dataPedidos = new DataGridView();
            btnExcluir = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataPedidos).BeginInit();
            SuspendLayout();
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(175, 323);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(146, 27);
            txtQuantidade.TabIndex = 0;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(175, 121);
            mskCpf.Margin = new Padding(3, 4, 3, 4);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(146, 27);
            mskCpf.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 2;
            label1.Text = "Montar pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 326);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Quantidade:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(179, 157);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(141, 20);
            lblNomeCliente.TabIndex = 4;
            lblNomeCliente.Text = "----------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 153);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 290);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 6;
            label5.Text = "Cod. produto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 120);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 7;
            label6.Text = "CPF cliente:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(183, 190);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(138, 37);
            btnBuscarCliente.TabIndex = 8;
            btnBuscarCliente.Text = "Buscar cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(162, 88);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 10;
            label7.Text = "Dados do cliente";
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(175, 357);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(146, 34);
            btnAdicionarProduto.TabIndex = 13;
            btnAdicionarProduto.Text = "Adicionar produto";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.Location = new Point(415, 232);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.Size = new Size(140, 38);
            btnSalvarPedido.TabIndex = 14;
            btnSalvarPedido.Text = "Gravar pedido";
            btnSalvarPedido.UseVisualStyleBackColor = true;
            btnSalvarPedido.Click += btnGravarPedido_Click;
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Location = new Point(612, 235);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(111, 20);
            lblTotalPedido.TabIndex = 15;
            lblTotalPedido.Text = "-----------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(561, 235);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 16;
            label8.Text = "Total:";
            // 
            // txtCodigoPedido
            // 
            txtCodigoPedido.Location = new Point(175, 47);
            txtCodigoPedido.Name = "txtCodigoPedido";
            txtCodigoPedido.Size = new Size(146, 27);
            txtCodigoPedido.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 50);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 20;
            label3.Text = "Código pedido:";
            // 
            // dataGridItens
            // 
            dataGridItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItens.Location = new Point(415, 47);
            dataGridItens.Name = "dataGridItens";
            dataGridItens.RowHeadersWidth = 51;
            dataGridItens.Size = new Size(512, 179);
            dataGridItens.TabIndex = 21;
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Location = new Point(175, 291);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(146, 27);
            txtCodigoProduto.TabIndex = 22;
            // 
            // dataProdutos
            // 
            dataProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProdutos.Location = new Point(11, 429);
            dataProdutos.Name = "dataProdutos";
            dataProdutos.RowHeadersWidth = 51;
            dataProdutos.Size = new Size(350, 183);
            dataProdutos.TabIndex = 23;
            // 
            // pedido
            // 
            pedido.AutoSize = true;
            pedido.Location = new Point(597, 24);
            pedido.Name = "pedido";
            pedido.Size = new Size(121, 20);
            pedido.TabIndex = 24;
            pedido.Text = "Pedido na sacola";
            pedido.Click += pedido_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(154, 406);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 25;
            label10.Text = "Produtos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(162, 253);
            label11.Name = "label11";
            label11.Size = new Size(137, 20);
            label11.TabIndex = 26;
            label11.Text = "Adicionar produtos";
            // 
            // dataPedidos
            // 
            dataPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPedidos.Location = new Point(415, 357);
            dataPedidos.Name = "dataPedidos";
            dataPedidos.RowHeadersWidth = 51;
            dataPedidos.Size = new Size(512, 219);
            dataPedidos.TabIndex = 27;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(415, 582);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(123, 30);
            btnExcluir.TabIndex = 28;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(597, 334);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 29;
            label9.Text = "Pedidos gravados";
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 637);
            Controls.Add(label9);
            Controls.Add(btnExcluir);
            Controls.Add(dataPedidos);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pedido);
            Controls.Add(dataProdutos);
            Controls.Add(txtCodigoProduto);
            Controls.Add(dataGridItens);
            Controls.Add(label3);
            Controls.Add(txtCodigoPedido);
            Controls.Add(label8);
            Controls.Add(lblTotalPedido);
            Controls.Add(btnSalvarPedido);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(label7);
            Controls.Add(btnBuscarCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblNomeCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mskCpf);
            Controls.Add(txtQuantidade);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormPedidos";
            Text = " ";
            Load += FormPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuantidade;
        private MaskedTextBox mskCpf;
        private Label label1;
        private Label label2;
        private Label lblNomeCliente;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnBuscarCliente;
        private Label label7;
        private Button btnAdicionarProduto;
        private Button btnSalvarPedido;
        private Label lblTotalPedido;
        private Label label8;
        private TextBox txtCodigoPedido;
        private Label label3;
        private DataGridView dataGridItens;
        private TextBox txtCodigoProduto;
        private DataGridView dataProdutos;
        private Label pedido;
        private Label label10;
        private Label label11;
        private DataGridView dataPedidos;
        private Button btnExcluir;
        private Label label9;
    }
}