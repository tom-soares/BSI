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
    public partial class TelaLogin : Form
    {
               
        private List<ClienteConta> ListaClienteConta { get; set; }
        private ClienteConta ClienteConta { get; set; }
        private double Valor { get; set; }

        public TelaLogin()
        {
            InitializeComponent();

            Cliente c1 = new Cliente(1, "Carlos Eduardo");
            Cliente c2 = new Cliente(2, "Walter Galvão");
            Cliente c3 = new Cliente(3, "Diego Pereira");

            ContaCorrente cc1 = new ContaCorrente(1, 1000, c1);
            ContaCorrente cc2 = new ContaCorrente(2, 500, c2);
            ContaCorrente cc3 = new ContaCorrente(3, 150, c3);

            ContaPoupanca cp1 = new ContaPoupanca(10, 1500, c1);
            ContaPoupanca cp2 = new ContaPoupanca(20, 500, c2);
            ContaPoupanca cp3 = new ContaPoupanca(30, 180, c3);

            ClienteConta cliconta1 = new ClienteConta(c1, cc1, cp1);
            ClienteConta cliconta2 = new ClienteConta(c2, cc2, cp2);
            ClienteConta cliconta3 = new ClienteConta(c3, cc3, cp3);

            ListaClienteConta = new List<ClienteConta>();
            ListaClienteConta.Add(cliconta1);
            ListaClienteConta.Add(cliconta2);
            ListaClienteConta.Add(cliconta3);

            //var teste = cliconta1.GetContaCorrente().GetSaldo();
            //Console.WriteLine("objeto teste: " + teste);
         
        }

        int pass;
        private void btLogin_Click(object sender, EventArgs e)
        {
            var user = tb_user.Text;
            try {
                pass = Convert.ToInt32(tb_pass.Text);
                var ClienteConta = ListaClienteConta.Find(x => x.GetCliente().ToString() == user);
                if (ClienteConta != null)
                {
                    if (ClienteConta.GetCliente().getId(pass) == true)
                    {
                        Console.WriteLine("Logado");
                        TelaInicial ti = new TelaInicial(this, ListaClienteConta, ClienteConta);
                        this.Hide();
                        ti.Show();                       
                    }
                    else
                        MessageBox.Show("Usuário ou Senha Inválido!");
                }
                else
                    MessageBox.Show("Usuário ou Senha Inválido!");
            }
            catch (Exception)
            {
                MessageBox.Show("Usuário ou Senha Inválido!");
            }

            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            tb_user.Text.DefaultIfEmpty();
            tb_pass.Text.DefaultIfEmpty();
        }

        public void limparCampos()
        {
            tb_user.Text = string.Empty;
            tb_pass.Text = string.Empty;
        }
    }
}
