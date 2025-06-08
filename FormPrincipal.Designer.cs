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
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1226, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { btnClientes, btnProdutos, btnPedidos, btnUsuarios });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1226, 33);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // btnClientes
            // 
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(164, 29);
            btnClientes.Text = "Cadastrar clientes";
            // 
            // btnProdutos
            // 
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(180, 29);
            btnProdutos.Text = "Cadastrar produtos";
            // 
            // btnPedidos
            // 
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(171, 29);
            btnPedidos.Text = "Cadastrar pedidos";
            // 
            // btnUsuarios
            // 
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(162, 29);
            btnUsuarios.Text = "Cadastrar usarios";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 652);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
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
    }
}