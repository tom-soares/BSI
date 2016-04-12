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
    public partial class TelaConta : Form
    {
        private string tipodeconta { get; set; }
        private TelaInicial ti { get; set; }
        private List<ClienteConta> listaClienteConta { get; set; }
        private ClienteConta clienteConta { get; set; }
        public TelaConta(String tipodeconta, TelaInicial ti, List<ClienteConta> listaClienteConta, ClienteConta clienteConta )
        {
            InitializeComponent();
            this.ti = ti;
            this.listaClienteConta = listaClienteConta;
            this.clienteConta = clienteConta;
            this.tipodeconta = tipodeconta;
            Console.WriteLine("tostring: " + this.ToString());
        }

        private void TelaConta_Load(object sender, EventArgs e)
        {
            if (tipodeconta == "corrente")
           
                tb_saldo.Text = clienteConta.GetContaCorrente().GetSaldo().ToString();
            
            if(tipodeconta == "poupanca")

                tb_saldo.Text = clienteConta.GetContaPoupanca().GetSaldo().ToString();
        }

        public override string ToString()
        {
            return tipodeconta ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ti.Show();
        }

        private void btTelaSaque_Click(object sender, EventArgs e)
        {
            if(tipodeconta == "corrente")
            {
                TelaSaque tscc = new TelaSaque("corrente", this, listaClienteConta, clienteConta);
                    this.Hide();
                    tscc.Show();
            }
            if(tipodeconta == "poupanca")
            {
                TelaSaque tscp = new TelaSaque("poupanca", this, listaClienteConta, clienteConta);
                this.Hide();
                tscp.Show();
            }
        }

        public void atualizarSaldo()
        {
            if (tipodeconta == "corrente")

                this.tb_saldo.Font = new Font(tb_saldo.Font, FontStyle.Bold);
                this.tb_saldo.Text = clienteConta.GetContaCorrente().GetSaldo().ToString();

            if (tipodeconta == "poupanca")

                tb_saldo.Text = clienteConta.GetContaPoupanca().GetSaldo().ToString();
        }

        private void btDeposito_Click(object sender, EventArgs e)
        {           
                TelaDeposito tdcc = new TelaDeposito(this, listaClienteConta, clienteConta);
                this.Hide();
                tdcc.Show();                  
            }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            if (tipodeconta == "corrente")
            {
                this.Hide();
                TelaTransferencia ttcc = new TelaTransferencia(this, listaClienteConta, clienteConta);
                ttcc.Show();
            }
            if(tipodeconta == "poupanca")
            {
                this.Hide();
                TelaTransferencia ttcp = new TelaTransferencia(this, listaClienteConta, clienteConta);
                ttcp.Show();
            }
        }
    }
        
}
