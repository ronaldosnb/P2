namespace P2
{
    partial class ConsultarPedidos
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
            listItens = new ListView();
            colProduto = new ColumnHeader();
            colQuantidade = new ColumnHeader();
            colSubtotal = new ColumnHeader();
            listPedidos = new ListView();
            colCodigo = new ColumnHeader();
            colValorTotal = new ColumnHeader();
            label1 = new Label();
            btnBuscar = new Button();
            mskCpf = new MaskedTextBox();
            lblNome = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listItens
            // 
            listItens.Columns.AddRange(new ColumnHeader[] { colProduto, colQuantidade, colSubtotal });
            listItens.FullRowSelect = true;
            listItens.GridLines = true;
            listItens.Location = new Point(411, 16);
            listItens.Margin = new Padding(3, 4, 3, 4);
            listItens.MultiSelect = false;
            listItens.Name = "listItens";
            listItens.Size = new Size(489, 571);
            listItens.TabIndex = 0;
            listItens.UseCompatibleStateImageBehavior = false;
            listItens.View = View.Details;
            // 
            // colProduto
            // 
            colProduto.Text = "Produto";
            colProduto.Width = 150;
            // 
            // colQuantidade
            // 
            colQuantidade.Text = "Quantidade";
            colQuantidade.Width = 115;
            // 
            // colSubtotal
            // 
            colSubtotal.Text = "Subtotal";
            colSubtotal.Width = 100;
            // 
            // listPedidos
            // 
            listPedidos.Columns.AddRange(new ColumnHeader[] { colCodigo, colValorTotal });
            listPedidos.FullRowSelect = true;
            listPedidos.GridLines = true;
            listPedidos.Location = new Point(12, 161);
            listPedidos.Margin = new Padding(3, 4, 3, 4);
            listPedidos.MultiSelect = false;
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(350, 421);
            listPedidos.TabIndex = 1;
            listPedidos.UseCompatibleStateImageBehavior = false;
            listPedidos.View = View.Details;
            listPedidos.SelectedIndexChanged += listPedidos_SelectedIndexChanged;
            // 
            // colCodigo
            // 
            colCodigo.Text = "Código";
            colCodigo.Width = 80;
            // 
            // colValorTotal
            // 
            colValorTotal.Text = "Valor Total";
            colValorTotal.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(69, 73);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 36);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(69, 34);
            mskCpf.Mask = "000000000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(168, 32);
            mskCpf.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(90, 132);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(124, 25);
            lblNome.TabIndex = 6;
            lblNome.Text = "--------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 7;
            label2.Text = "cliente:";
            // 
            // ConsultarPedidos
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(lblNome);
            Controls.Add(mskCpf);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(listPedidos);
            Controls.Add(listItens);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultarPedidos";
            Text = "ConsultarPedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listItens;
        private ListView listPedidos;
        private Label label1;
        private Button btnBuscar;
        private MaskedTextBox mskCpf;
        private Label lblNome;
        private Label label2;
        private ColumnHeader colCodigo;
        private ColumnHeader colValorTotal;
        private ColumnHeader colProduto;
        private ColumnHeader colQuantidade;
        private ColumnHeader colSubtotal;
    }
}