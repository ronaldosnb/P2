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
            listPedido = new ListView();
            listPedidos = new ListView();
            label1 = new Label();
            btnConsultar = new Button();
            mskCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // listPedido
            // 
            listPedido.Location = new Point(355, 16);
            listPedido.Margin = new Padding(3, 4, 3, 4);
            listPedido.Name = "listPedido";
            listPedido.Size = new Size(545, 131);
            listPedido.TabIndex = 0;
            listPedido.UseCompatibleStateImageBehavior = false;
            // 
            // listPedidos
            // 
            listPedidos.Location = new Point(12, 161);
            listPedidos.Margin = new Padding(3, 4, 3, 4);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(888, 421);
            listPedidos.TabIndex = 1;
            listPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(30, 68);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(93, 36);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Buscar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(69, 34);
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(168, 27);
            mskCpf.TabIndex = 5;
            // 
            // ConsultarPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(mskCpf);
            Controls.Add(btnConsultar);
            Controls.Add(label1);
            Controls.Add(listPedidos);
            Controls.Add(listPedido);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultarPedidos";
            Text = "ConsultarPedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listPedido;
        private ListView listPedidos;
        private Label label1;
        private Button btnConsultar;
        private MaskedTextBox mskCpf;
    }
}