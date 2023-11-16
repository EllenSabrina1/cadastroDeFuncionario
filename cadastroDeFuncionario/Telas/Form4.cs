using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroDeFuncionario
{
    public partial class Form4 : Form
    {

        private List<Cadastro> listaFuncionarios;
        public Form4(List<Cadastro> listaFuncionarios)
        {
            InitializeComponent();
            this.listaFuncionarios = listaFuncionarios;
            PreencherDataGridView();
        }

        public void PreencherDataGridView()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = listaFuncionarios;
            dataGrid.Refresh();
        }

        private void bt_fecharVisualizador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
