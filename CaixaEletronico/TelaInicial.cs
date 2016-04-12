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
    public partial class TelaInicial : Form
    {
        private TelaLogin tl { get; set; }
        private List<ClienteConta> listaClienteConta { get; set; }
        private ClienteConta clienteConta { get; set; }
        public TelaInicial(TelaLogin ti, List<ClienteConta> listaClienteConta, ClienteConta clienteConta)
        {
            InitializeComponent();
            this.tl = ti;
            this.listaClienteConta = listaClienteConta;
            this.clienteConta = clienteConta;

        }

        private void btTelaContaCorrente_Click(object sender, EventArgs e)
        {           
            this.Hide();
            TelaConta Tcc = new TelaConta("corrente", this, listaClienteConta, clienteConta);
            Tcc.Show();
        }
       
        private void btTelaContaPoupanca_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaConta tcp = new TelaConta("poupanca", this, listaClienteConta, clienteConta);
            tcp.Show();
        }
              
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
        }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tl.limparCampos();
            this.Close();
            tl.Show();
        }

        //private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        //{
            
        //}
    }
}
