using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acesso
{
    public partial class Form1 : Form
    {
        Login log = new Login();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            log.empresa = txtEmpresa.Text;
            log.usuario = txtUsuario.Text;
            log.senha = txtSenha.Text;

            int retorno  = log.validaAcesso();

            if (retorno == 3)
            {
                MessageBox.Show("Acesso permitido!");
                Close();
            }else if(retorno == 2)
            {
                MessageBox.Show("Acesso negado!\n" + "Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpresa.Focus();
            }else if(retorno == 1)
            {
                MessageBox.Show("Acesso negado!\n" + "Empresa inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpresa.Focus();
            } else
            {
                MessageBox.Show("Insira todos os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpresa.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
