using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
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
    }
}

