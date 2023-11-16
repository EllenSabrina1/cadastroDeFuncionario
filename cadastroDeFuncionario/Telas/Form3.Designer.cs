namespace cadastroDeFuncionario
{
    partial class Form3
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
            this.bt_sairr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_sairr
            // 
            this.bt_sairr.BackColor = System.Drawing.Color.Lavender;
            this.bt_sairr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sairr.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.bt_sairr.Location = new System.Drawing.Point(507, 440);
            this.bt_sairr.Name = "bt_sairr";
            this.bt_sairr.Size = new System.Drawing.Size(75, 23);
            this.bt_sairr.TabIndex = 0;
            this.bt_sairr.Text = "Sair";
            this.bt_sairr.UseVisualStyleBackColor = false;
            this.bt_sairr.Click += new System.EventHandler(this.bt_sairr_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cadastroDeFuncionario.Properties.Resources.Frame;
            this.ClientSize = new System.Drawing.Size(655, 488);
            this.Controls.Add(this.bt_sairr);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_sairr;
    }
}