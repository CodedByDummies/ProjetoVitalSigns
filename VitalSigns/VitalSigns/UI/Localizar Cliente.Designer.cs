namespace VitalSigns.UI
{
    partial class Localizar_Cliente
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
            this.cbxEscolhasKey = new System.Windows.Forms.ComboBox();
            this.txtLocalizadorCliente = new System.Windows.Forms.TextBox();
            this.dgwViewChamados = new System.Windows.Forms.DataGridView();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEscolhasKey
            // 
            this.cbxEscolhasKey.FormattingEnabled = true;
            this.cbxEscolhasKey.Items.AddRange(new object[] {
            "CPF",
            "CNPJ",
            "Chamado"});
            this.cbxEscolhasKey.Location = new System.Drawing.Point(68, 68);
            this.cbxEscolhasKey.Name = "cbxEscolhasKey";
            this.cbxEscolhasKey.Size = new System.Drawing.Size(121, 21);
            this.cbxEscolhasKey.TabIndex = 0;
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
            // Localizar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoChamado);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.dgwViewChamados);
            this.Controls.Add(this.txtLocalizadorCliente);
            this.Controls.Add(this.cbxEscolhasKey);
            this.Name = "Localizar_Cliente";
            this.Text = "Localizar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewChamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEscolhasKey;
        private System.Windows.Forms.TextBox txtLocalizadorCliente;
        private System.Windows.Forms.DataGridView dgwViewChamados;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnNovoChamado;
    }
}