using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCEP
{
    public partial class btnConsultaCEP : Form
    {
        public btnConsultaCEP()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string endereco = "";
            try
            {
                var webService = new CORREIOS.AtendeClienteClient();
                var resposta = webService.consultaCEP(txtCEP.Text);
                txtRua.Text = resposta.end;
                txtBairro.Text = resposta.bairro;
                txtCidade.Text = resposta.cidade;
                txtEstado.Text = resposta.uf;

            }
            catch(Exception ex)
            {
                MessageBox.Show("CEP não localizado");
            }
        }
    }
}
