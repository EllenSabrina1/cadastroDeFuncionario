namespace cadastroDeFuncionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msk_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.cb_estCivil = new System.Windows.Forms.ComboBox();
            this.tx_estado = new System.Windows.Forms.TextBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.cb_funcao = new System.Windows.Forms.ComboBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.Color.Lavender;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tx_nome.Location = new System.Drawing.Point(36, 116);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(2);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(300, 16);
            this.tx_nome.TabIndex = 0;
            this.tx_nome.TextChanged += new System.EventHandler(this.tx_nome_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(455, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // msk_dataNasc
            // 
            this.msk_dataNasc.BackColor = System.Drawing.Color.Lavender;
            this.msk_dataNasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_dataNasc.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.msk_dataNasc.Location = new System.Drawing.Point(404, 184);
            this.msk_dataNasc.Margin = new System.Windows.Forms.Padding(2);
            this.msk_dataNasc.Mask = "00/00/0000";
            this.msk_dataNasc.Name = "msk_dataNasc";
            this.msk_dataNasc.Size = new System.Drawing.Size(86, 16);
            this.msk_dataNasc.TabIndex = 2;
            this.msk_dataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.Lavender;
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tx_email.Location = new System.Drawing.Point(36, 244);
            this.tx_email.Margin = new System.Windows.Forms.Padding(2);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(300, 16);
            this.tx_email.TabIndex = 3;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BackColor = System.Drawing.Color.Lavender;
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tx_endereco.Location = new System.Drawing.Point(391, 349);
            this.tx_endereco.Margin = new System.Windows.Forms.Padding(2);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(201, 16);
            this.tx_endereco.TabIndex = 4;
            this.tx_endereco.TextChanged += new System.EventHandler(this.tx_endereco_TextChanged);
            // 
            // cb_estCivil
            // 
            this.cb_estCivil.BackColor = System.Drawing.Color.Lavender;
            this.cb_estCivil.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.cb_estCivil.ForeColor = System.Drawing.Color.Black;
            this.cb_estCivil.FormattingEnabled = true;
            this.cb_estCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Viúvo(a)",
            "Divorciado(a)",
            "União estável"});
            this.cb_estCivil.Location = new System.Drawing.Point(391, 244);
            this.cb_estCivil.Margin = new System.Windows.Forms.Padding(2);
            this.cb_estCivil.Name = "cb_estCivil";
            this.cb_estCivil.Size = new System.Drawing.Size(121, 23);
            this.cb_estCivil.TabIndex = 5;
            // 
            // tx_estado
            // 
            this.tx_estado.BackColor = System.Drawing.Color.Lavender;
            this.tx_estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_estado.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tx_estado.Location = new System.Drawing.Point(35, 349);
            this.tx_estado.Margin = new System.Windows.Forms.Padding(2);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(118, 16);
            this.tx_estado.TabIndex = 7;
            this.tx_estado.TextChanged += new System.EventHandler(this.tx_estado_TextChanged);
            // 
            // tx_cidade
            // 
            this.tx_cidade.BackColor = System.Drawing.Color.Lavender;
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidade.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tx_cidade.Location = new System.Drawing.Point(220, 349);
            this.tx_cidade.Margin = new System.Windows.Forms.Padding(2);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(116, 16);
            this.tx_cidade.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Location = new System.Drawing.Point(663, 489);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox2.Mask = "(99) 00000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(79, 13);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // msk_telefone
            // 
            this.msk_telefone.BackColor = System.Drawing.Color.Lavender;
            this.msk_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_telefone.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone.Location = new System.Drawing.Point(391, 112);
            this.msk_telefone.Margin = new System.Windows.Forms.Padding(2);
            this.msk_telefone.Mask = "(99) 00000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(116, 19);
            this.msk_telefone.TabIndex = 10;
            this.msk_telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(578, 518);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "SALVAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // msk_cpf
            // 
            this.msk_cpf.BackColor = System.Drawing.Color.Lavender;
            this.msk_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_cpf.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.msk_cpf.Location = new System.Drawing.Point(35, 184);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(119, 16);
            this.msk_cpf.TabIndex = 12;
            this.msk_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_cpf_MaskInputRejected);
            // 
            // msk_rg
            // 
            this.msk_rg.BackColor = System.Drawing.Color.Lavender;
            this.msk_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_rg.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.msk_rg.Location = new System.Drawing.Point(220, 184);
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.Size = new System.Drawing.Size(100, 16);
            this.msk_rg.TabIndex = 13;
            // 
            // tx_salario
            // 
            this.tx_salario.BackColor = System.Drawing.Color.Lavender;
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salario.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tx_salario.Location = new System.Drawing.Point(220, 454);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(91, 16);
            this.tx_salario.TabIndex = 14;
            this.tx_salario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cb_funcao
            // 
            this.cb_funcao.BackColor = System.Drawing.Color.Lavender;
            this.cb_funcao.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.cb_funcao.FormattingEnabled = true;
            this.cb_funcao.Items.AddRange(new object[] {
            "Professor",
            "Coordenador",
            "Diretor",
            "Secretario",
            "Piscólogo",
            "Orientador",
            "Técnico",
            "Bibliotecário",
            "Auxiliar"});
            this.cb_funcao.Location = new System.Drawing.Point(35, 451);
            this.cb_funcao.Name = "cb_funcao";
            this.cb_funcao.Size = new System.Drawing.Size(121, 23);
            this.cb_funcao.TabIndex = 15;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Black;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.bt_cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_cancelar.Location = new System.Drawing.Point(490, 443);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(72, 25);
            this.bt_cancelar.TabIndex = 16;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.Black;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.bt_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_salvar.Location = new System.Drawing.Point(568, 443);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 25);
            this.bt_salvar.TabIndex = 17;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // tx_id
            // 
            this.tx_id.BackColor = System.Drawing.Color.Lavender;
            this.tx_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_id.Location = new System.Drawing.Point(379, 454);
            this.tx_id.Margin = new System.Windows.Forms.Padding(2);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(81, 13);
            this.tx_id.TabIndex = 18;
            this.tx_id.TextChanged += new System.EventHandler(this.tx_id_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cadastroDeFuncionario.Properties.Resources.Cadastro_Funcionario__1_2;
            this.ClientSize = new System.Drawing.Size(655, 488);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.cb_funcao);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.cb_estCivil);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.msk_dataNasc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_nome);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox msk_dataNasc;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.ComboBox cb_estCivil;
        private System.Windows.Forms.TextBox tx_estado;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox msk_telefone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.ComboBox cb_funcao;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.TextBox tx_id;
    }
}

