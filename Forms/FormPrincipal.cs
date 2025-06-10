using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2.Functions;

namespace P2
{
    public partial class FormPrincipal : Form
    {
        private string usuarioLogado;

        public FormPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();
            form.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos form = new FormPedidos();
            form.ShowDialog();
        }

        private void btnConsultarPedidos_Click(object sender, EventArgs e)
        {
            ConsultarPedidos form = new ConsultarPedidos();
            form.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnAtualizarSenha_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text.Trim();

            if (string.IsNullOrEmpty(novaSenha))
            {
                MessageBox.Show("Digite a nova senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool sucesso = CrudUtils.AtualizarSenhaDireto(usuarioLogado, novaSenha);

            if (sucesso)
            {
                MessageBox.Show("Senha atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNovaSenha.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
