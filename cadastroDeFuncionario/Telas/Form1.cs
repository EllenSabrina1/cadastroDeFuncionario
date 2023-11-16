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
    public partial class Form1 : Form
    {
        List<Cadastro> listaCadastros = new List<Cadastro>();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void msk_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        public void bt_salvar_Click(object sender, EventArgs e)
        {
            string validarCpf = msk_cpf.Text;
            bool resultadoCpf = Validacao.ValidarCpf(validarCpf);

            // Validação do E-mail
            string validarEmail = tx_email.Text;
            bool resultadoEmail = Validacao.ValidarEmail(validarEmail);

            if (resultadoCpf && resultadoEmail)
            {
                Cadastro f = new Cadastro();
                f.Nome = tx_nome.Text;
                f.Email = tx_email.Text;
                f.DataNascimento = Convert.ToDateTime(msk_dataNasc.Text);
                f.CPF = msk_cpf.Text;
                f.RG = Convert.ToInt32(msk_rg.Text);
                f.Estado = tx_estado.Text;
                f.Cidade = tx_cidade.Text;
                f.Endereco = tx_endereco.Text;
                f.EstadoCivil = cb_estCivil.Text;
                f.Telefone = msk_telefone.Text;
                f.Funcao = cb_funcao.Text;
                f.Salario = Convert.ToDouble(tx_salario.Text);

                listaCadastros.Add(f);

                Form4 v = new Form4(listaCadastros);
                v.Show();

                MessageBox.Show($"Salvo!");
                Form3 formulario1 = new Form3();
                formulario1.Show();
                this.Close();
            }

            else
            {
                string mensagemErro = "Erro ao cadastrar funcionário. Problemas encontrados:\n";

                if (!resultadoCpf)
                {
                    mensagemErro += "> CPF inválido\n";
                }

                if (!resultadoEmail)
                {
                    mensagemErro += "> E-mail inválido\n";
                }

                MessageBox.Show(mensagemErro);
            }
        }


        private void tx_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Form2 formulario1 = new Form2();
            formulario1.Show();
            this.Close();
        }
    }
}
