namespace VitalSigns.UI
{
    partial class frmLocalizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizarCliente));
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtLocalizadorCliente = new System.Windows.Forms.TextBox();
            this.dgwViewChamados = new System.Windows.Forms.DataGridView();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "CPF",
            "CNPJ",
            "Chamado"});
            this.cbPesquisa.Location = new System.Drawing.Point(68, 68);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cbPesquisa.TabIndex = 0;
            // 
            // txtLocalizadorCliente
            // 
            this.txtLocalizadorCliente.Location = new System.Drawing.Point(195, 69);
            this.txtLocalizadorCliente.Name = "txtLocalizadorCliente";
            this.txtLocalizadorCliente.Size = new System.Drawing.Size(447, 20);
            this.txtLocalizadorCliente.TabIndex = 1;
            // 
            // dgwViewChamados
            // 
            this.dgwViewChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwViewChamados.Location = new System.Drawing.Point(68, 117);
            this.dgwViewChamados.Name = "dgwViewChamados";
            this.dgwViewChamados.Size = new System.Drawing.Size(663, 292);
            this.dgwViewChamados.TabIndex = 2;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(648, 68);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(83, 23);
            this.btnLocalizar.TabIndex = 3;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.Location = new System.Drawing.Point(625, 415);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(106, 23);
            this.btnNovoChamado.TabIndex = 4;
            this.btnNovoChamado.Text = "Novo Chamado";
            this.btnNovoChamado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo Pesquisa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLocalizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovoChamado);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.dgwViewChamados);
            this.Controls.Add(this.txtLocalizadorCliente);
            this.Controls.Add(this.cbPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocalizarCliente";
            this.Text = "Localizar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewChamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.TextBox txtLocalizadorCliente;
        private System.Windows.Forms.DataGridView dgwViewChamados;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}