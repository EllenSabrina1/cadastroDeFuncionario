namespace cadastroDeFuncionario
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_sairMenu = new System.Windows.Forms.Button();
            this.bt_CadFunc = new System.Windows.Forms.Button();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_sairMenu
            // 
            this.bt_sairMenu.BackColor = System.Drawing.Color.Black;
            this.bt_sairMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sairMenu.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.bt_sairMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_sairMenu.Location = new System.Drawing.Point(547, 409);
            this.bt_sairMenu.Name = "bt_sairMenu";
            this.bt_sairMenu.Size = new System.Drawing.Size(75, 23);
            this.bt_sairMenu.TabIndex = 0;
            this.bt_sairMenu.Text = "Sair";
            this.bt_sairMenu.UseVisualStyleBackColor = false;
            this.bt_sairMenu.Click += new System.EventHandler(this.bt_sairMenu_Click);
            // 
            // bt_CadFunc
            // 
            this.bt_CadFunc.BackColor = System.Drawing.Color.Lavender;
            this.bt_CadFunc.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_CadFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CadFunc.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadFunc.Location = new System.Drawing.Point(231, 193);
            this.bt_CadFunc.Name = "bt_CadFunc";
            this.bt_CadFunc.Size = new System.Drawing.Size(210, 38);
            this.bt_CadFunc.TabIndex = 1;
            this.bt_CadFunc.Text = "Cadastrar novo funcionário";
            this.bt_CadFunc.UseVisualStyleBackColor = false;
            this.bt_CadFunc.Click += new System.EventHandler(this.bt_CadFunc_Click);
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.BackColor = System.Drawing.Color.Lavender;
            this.bt_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_visualizar.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.bt_visualizar.Location = new System.Drawing.Point(231, 259);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(210, 38);
            this.bt_visualizar.TabIndex = 2;
            this.bt_visualizar.Text = "Visualizar funcionários";
            this.bt_visualizar.UseVisualStyleBackColor = false;
            this.bt_visualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cadastroDeFuncionario.Properties.Resources.Menu__1_;
            this.ClientSize = new System.Drawing.Size(655, 488);
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.bt_CadFunc);
            this.Controls.Add(this.bt_sairMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_sairMenu;
        private System.Windows.Forms.Button bt_CadFunc;
        private System.Windows.Forms.Button bt_visualizar;
    }
}