﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form4 visualizador = new Form4(Form1.listaCadastros);
            //visualizador.Show();
        }

        private void bt_CadFunc_Click(object sender, EventArgs e)
        {
            Form1 formulario2 = new Form1();
            formulario2.Show();
        }

        private void bt_sairMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
