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

        private void dataProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataProdutos.SelectedRows.Count > 0)
            {
                var linha = dataProdutos.SelectedRows[0];

                txtCodigo.Text = linha.Cells["Codigo"].Value.ToString();
                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtPreco.Text = linha.Cells["Preco"].Value.ToString();
                txtDescricao.Text = linha.Cells["Descricao"].Value.ToString();

                txtCodigo.Enabled = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataProdutos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string codigoSelecionado = dataProdutos.SelectedRows[0].Cells["Codigo"].Value.ToString();

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    CrudUtils.ExcluirProduto(codigoSelecionado);
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();
                string nome = txtNome.Text.Trim();
                string precoTexto = txtPreco.Text.Trim();
                string descricao = txtDescricao.Text.Trim();

                if (string.IsNullOrWhiteSpace(codigo) ||
                    string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(precoTexto) ||
                    string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(precoTexto, out float preco))
                {
                    MessageBox.Show("O preço deve ser um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CrudUtils.AtualizarProduto(codigo, nome, precoTexto, descricao);

                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a tabela e limpa os campos
                AtualizarGridProdutos();
                txtCodigo.Clear();
                txtNome.Clear();
                txtPreco.Clear();
                txtDescricao.Clear();
                txtCodigo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
