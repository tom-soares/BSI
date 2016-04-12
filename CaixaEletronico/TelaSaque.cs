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
    public partial class TelaSaque : Form
    {
        private string tipodeconta { get; set; }
        private TelaConta tc { get; set; }
        private List<ClienteConta> listaClienteConta { get; set; }
        private ClienteConta clienteConta { get; set; }

        public TelaSaque(string tipodeconta, TelaConta tc, List<ClienteConta> listaClienteConta, ClienteConta clienteConta)
        {
            InitializeComponent();
            this.tipodeconta = tipodeconta;
            this.tc = tc;
            this.listaClienteConta = listaClienteConta;
            this.clienteConta = clienteConta;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            tc.Show();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            try
            {

                if (tipodeconta == "corrente")
                {
                    clienteConta.GetContaCorrente().Sacar(Convert.ToDouble(tbValor.Text));
                    tc.atualizarSaldo();
                    this.Close();
                    tc.Show();
                }
                if (tipodeconta == "poupanca")

                    clienteConta.GetContaPoupanca().Sacar(Convert.ToDouble(tbValor.Text));
                tc.atualizarSaldo();
                this.Close();
                tc.Show();
            }catch(Exception ex )
            {
                MessageBox.Show("" + ex.Message);
            } 

        }
    }
}
