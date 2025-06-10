namespace P2
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            btnClientes = new ToolStripMenuItem();
            btnProdutos = new ToolStripMenuItem();
            btnPedidos = new ToolStripMenuItem();
            btnUsuarios = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            btnConsultarPedidos = new ToolStripMenuItem();
            label1 = new Label();
            txtNovaSenha = new TextBox();
            btnAtualizarSenha = new Button();
            label2 = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(821, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { btnUsuarios, btnClientes, btnProdutos, btnPedidos, toolStripMenuItem1, btnConsultarPedidos });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(5, 2, 0, 2);
            menuStrip2.Size = new Size(821, 28);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // btnClientes
            // 
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(138, 24);
            btnClientes.Text = "Cadastrar clientes";
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(148, 24);
            btnProdutos.Text = "Cadastrar produtos";
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(142, 24);
            btnPedidos.Text = "Cadastrar pedidos";
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(134, 24);
            btnUsuarios.Text = "Cadastrar usarios";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 24);
            // 
            // btnConsultarPedidos
            // 
            btnConsultarPedidos.Name = "btnConsultarPedidos";
            btnConsultarPedidos.Size = new Size(141, 24);
            btnConsultarPedidos.Text = "Consultar pedidos";
            btnConsultarPedidos.Click += btnConsultarPedidos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(18, 66);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 6;
            label1.Text = "Atualizar minha senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 12F);
            txtNovaSenha.Location = new Point(18, 132);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(200, 29);
            txtNovaSenha.TabIndex = 7;
            // 
            // btnAtualizarSenha
            // 
            btnAtualizarSenha.Font = new Font("Segoe UI", 12F);
            btnAtualizarSenha.Location = new Point(18, 167);
            btnAtualizarSenha.Name = "btnAtualizarSenha";
            btnAtualizarSenha.Size = new Size(105, 33);
            btnAtualizarSenha.TabIndex = 8;
            btnAtualizarSenha.Text = "Atualizar";
            btnAtualizarSenha.UseVisualStyleBackColor = true;
            btnAtualizarSenha.Click += btnAtualizarSenha_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 108);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 9;
            label2.Text = "Nova senha:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 322);
            Controls.Add(label2);
            Controls.Add(btnAtualizarSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem btnClientes;
        private ToolStripMenuItem btnProdutos;
        private ToolStripMenuItem btnPedidos;
        private ToolStripMenuItem btnUsuarios;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnConsultarPedidos;
        private Label label1;
        private TextBox txtNovaSenha;
        private Button btnAtualizarSenha;
        private Label label2;
    }
}