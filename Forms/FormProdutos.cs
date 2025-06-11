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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }
        private void AtualizarGridProdutos()
        {
            try
            {
                dataProdutos.DataSource = CrudUtils.CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGridProdutos();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoTexto = txtCodigo.Text.Trim();
                string nome = txtNome.Text.Trim();
                string precoTexto = txtPreco.Text.Trim();
                string descricao = txtDescricao.Text.Trim();

                if (string.IsNullOrWhiteSpace(codigoTexto) ||
                    string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(precoTexto) ||
                    string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(codigoTexto, out int codigo))
                {
                    MessageBox.Show("O código deve ser um número inteiro válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CrudUtils.ProdutoJaExiste(codigoTexto))
                {
                    MessageBox.Show("Já existe um produto com esse código!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!float.TryParse(precoTexto, out float preco))
                {
                    MessageBox.Show("O preço deve ser um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CrudUtils.CadastrarProduto(codigoTexto, nome, precoTexto, descricao);

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigo.Clear();
                txtNome.Clear();
                txtPreco.Clear();
                txtDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarGridProdutos();
        }


    }
}
