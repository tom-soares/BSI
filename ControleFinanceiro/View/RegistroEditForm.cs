using ControleFinanceiro.Infra;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.View
{
    public partial class RegistroEditForm : Form
    {
        Dashboard db;
        Registro r;
        public RegistroEditForm(Dashboard db, int id)
        {
            this.db = db;
            RegistroDAO rDAO = new RegistroDAO();
            r = rDAO.Recupera(id);
            InitializeComponent();
            txtDesc.Text = r.Descricao;
            txtValor.Text = r.Valor.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            RegistroDAO rDAO = new RegistroDAO();
            rDAO.Atualiza(new Registro(r.id,Double.Parse(txtValor.Text),txtDesc.Text));
            db.refreshDashboard();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RegistroDAO rDAO = new RegistroDAO();
            rDAO.Exclui(r.id);
            db.refreshDashboard();
            this.Close();
        }
    }
}
