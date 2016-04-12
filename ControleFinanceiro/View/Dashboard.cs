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
using ControleFinanceiro.View;

namespace ControleFinanceiro
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeiroDataSet1.Registros' table. You can move, or remove it, as needed.
            refreshDashboard();   
        }
        string DecimalPlaceNoRounding(double d, int decimalPlaces = 2)
        {
            d = d * Math.Pow(10, decimalPlaces);
            d = Math.Truncate(d);
            d = d / Math.Pow(10, decimalPlaces);
            return string.Format("{0:N" + Math.Abs(decimalPlaces) + "}", d);
        }

        public void refreshDashboard()
        {
            RegistroDAO rDAO = new RegistroDAO();

            double entrada = rDAO.Acumulo(1);
            double saida = rDAO.Acumulo(0);

            tbox_resumo.Text = DecimalPlaceNoRounding(entrada + saida);
            tbox_rendas.Text = DecimalPlaceNoRounding(entrada);
            tbox_despesas.Text = DecimalPlaceNoRounding(saida);
            this.registrosTableAdapter.Fill(this.financeiroDataSet1.Registros);
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_adicionar_Click_1(object sender, EventArgs e)
        {
            RegistroForm rf = new RegistroForm(this);
            rf.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            int id = Int32.Parse(row.Cells[0].Value.ToString());
            RegistroEditForm regEdit = new RegistroEditForm(this,id);
            regEdit.Show();
        }
    }
}
