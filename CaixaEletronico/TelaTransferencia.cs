using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class TelaTransferencia : Form
    {
        private TelaConta tc { get; set; }
        private List<ClienteConta> listaClienteConta { get; set; }
        private ClienteConta clienteConta { get; set; }
        public TelaTransferencia(TelaConta tc, List<ClienteConta> listaClienteConta, ClienteConta clienteConta)
        {
            InitializeComponent();
            this.tc = tc;
            this.listaClienteConta = listaClienteConta;
            this.clienteConta = clienteConta;
        }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                var ContaDestino = Convert.ToInt32(tbContaDestino.Text);
                var valor = Convert.ToDouble(tbValor.Text);
                var clienteDeposito = listaClienteConta.Find(x => (x.GetContaCorrente().GetNumero() == ContaDestino) || (x.GetContaPoupanca().GetNumero() == ContaDestino));
                if (clienteDeposito.GetContaCorrente().GetNumero() == ContaDestino)
                {
                    clienteConta.GetContaCorrente().Transferir(valor, clienteDeposito.GetContaCorrente());
                    this.Close();
                    tc.atualizarSaldo();
                    tc.Show();
                }
                if (clienteDeposito.GetContaPoupanca().GetNumero() == ContaDestino)
                {
                    clienteConta.GetContaPoupanca().Transferir(valor, clienteDeposito.GetContaPoupanca());
                    this.Close();
                    tc.atualizarSaldo();
                    tc.Show();
                }
                Console.WriteLine("Transferência Efetuada com sucesso!");
                Console.WriteLine("Cliente: " + clienteDeposito);
                Console.WriteLine("Valor do Transferido: " + valor);

            }
            catch (Exception)
            {
                MessageBox.Show("Número de Conta ou valor inválido");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            tc.Show();
        }

        private void TelaTransferencia_Load(object sender, EventArgs e)
        {

        }
    }
}
