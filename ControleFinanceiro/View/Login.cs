using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinanceiro.Infra;


namespace ControleFinanceiro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Cadastro cadastro = new Cadastro();
            //cadastro.Visible = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            UsuarioDAO userDAO = new Infra.UsuarioDAO();
            if(userDAO.login(tboxUser.Text, tbox_pass.Text) == 1)
            {
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Dispose();
            }
        }

        private void link_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
