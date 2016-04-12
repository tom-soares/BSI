using ControleFinanceiro.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace ControleFinanceiro
{
    public partial class RegistroForm : Form
    {
        Dashboard db;
        public RegistroForm(Dashboard db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void Despesas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            RegistroDAO rDAO = new RegistroDAO();
            rDAO.Insere(new Registro(Double.Parse(txtValor.Text),txtDesc.Text));
            db.refreshDashboard();
            this.Close();
        }
    }
}
