using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Form1 : Form
    {


        public List<Produto> listaProdutos { get; set; }
        public Produto Selecionado { get; set; }
        public Form1()
        {
            InitializeComponent();
            listaProdutos = new List<Produto>();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Selecionado = listaProdutos.Find(x => x.Descricao == textDesc.Text);
                if (Selecionado != null)
                {
                    atualizaCampos();

                    if (Selecionado.QtdTotal < Selecionado.QtdMin)
                    {
                        MessageBox.Show("Estoque abaixo do limite permitido!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado");
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textCadaDesc.Text.Equals("") || textCadaLocal.Text.Equals("") || textCadaQtd.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            Produto p = new Produto(
                textCadaDesc.Text,
                textCadaLocal.Text,
                Int32.Parse(textCadaQtd.Text)
                );         

            listaProdutos.Add(p);
            MessageBox.Show("Produto adicionado com Sucesso!");
         

            LimparCampos();
        }

        public void LimparCampos()
        {
            textCadaDesc.Clear();
            textCadaQtd.Clear();
            textCadaLocal.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRetirar_Click(object sender, EventArgs e)
        {
            Selecionado.QtdTotal -= Int32.Parse(textRetirar.Text);
            atualizaCampos();

            if (Selecionado.QtdTotal < Selecionado.QtdMin)
            {
                MessageBox.Show("Estoque abaixo do limite permitido!");
            }
        }

        private void buttonRepor_Click(object sender, EventArgs e)
        {
            Selecionado.QtdTotal += Int32.Parse(textRepor.Text);
            atualizaCampos();

            if (Selecionado.QtdTotal < Selecionado.QtdMin)
            {
                MessageBox.Show("Estoque abaixo do limite permitido!");
            }
       
        }
        private void atualizaCampos()
        {
            textDesc.Text = Selecionado.Descricao;
            textLocal.Text = Selecionado.Local;
            textQtd.Text = Convert.ToString(Selecionado.QtdTotal);
            textQtdm.Text = Convert.ToString(Selecionado.QtdMin);
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("mudou");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int current = (sender as TabControl).SelectedIndex;
            if (current == 2)
            {
                foreach( Produto p in listaProdutos)
                    if( p.QtdTotal < p.QtdMin )
                    listBox1.Items.Add(p.Descricao);
            }
        }


    }
}
