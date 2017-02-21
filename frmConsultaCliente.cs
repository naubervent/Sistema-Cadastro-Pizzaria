using PizzariaSys.Dominio;
using PizzariaSys.Dominio.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaSys.WindowsForm
{
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            Cliente cliente = new Cliente();

            cliente = clienteNegocios.ListarClienteTelefone(txtConsulta.Text);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não localizado", "AVIZO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmCadastro frm = new frmCadastro(AcaoNaTela.Consultar, cliente);
            frm.ShowDialog();
        }
    }
}
