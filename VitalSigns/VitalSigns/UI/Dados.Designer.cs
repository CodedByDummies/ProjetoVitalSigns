namespace VitalSigns.UI
{
    partial class frmDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDados));
            this.vptcDados = new System.Windows.Forms.TabControl();
            this.pgChamado = new System.Windows.Forms.TabPage();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.lblDadosCliente = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblResidencial = new System.Windows.Forms.Label();
            this.lblDDDR = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDDDC = new System.Windows.Forms.Label();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtResidencial = new System.Windows.Forms.TextBox();
            this.txtDddRes = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtDddCel = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pgOS = new System.Windows.Forms.TabPage();
            this.lvOrdemServico = new System.Windows.Forms.ListView();
            this.txtOrdemServico = new System.Windows.Forms.TextBox();
            this.pgHistorico = new System.Windows.Forms.TabPage();
            this.pgVisitaTecnica = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.vptcDados.SuspendLayout();
            this.pgChamado.SuspendLayout();
            this.pgOS.SuspendLayout();
            this.pgHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vptcDados
            // 
            this.vptcDados.Controls.Add(this.pgChamado);
            this.vptcDados.Controls.Add(this.pgOS);
            this.vptcDados.Controls.Add(this.pgHistorico);
            this.vptcDados.Controls.Add(this.pgVisitaTecnica);
            this.vptcDados.Location = new System.Drawing.Point(12, 61);
            this.vptcDados.Name = "vptcDados";
            this.vptcDados.SelectedIndex = 0;
            this.vptcDados.Size = new System.Drawing.Size(761, 377);
            this.vptcDados.TabIndex = 2;
            // 
            // pgChamado
            // 
            this.pgChamado.Controls.Add(this.txtDescricao);
            this.pgChamado.Controls.Add(this.btnSalvarDados);
            this.pgChamado.Controls.Add(this.lblDadosCliente);
            this.pgChamado.Controls.Add(this.lblEmail);
            this.pgChamado.Controls.Add(this.lblResidencial);
            this.pgChamado.Controls.Add(this.lblDDDR);
            this.pgChamado.Controls.Add(this.lblCelular);
            this.pgChamado.Controls.Add(this.lblDDDC);
            this.pgChamado.Controls.Add(this.lblCPF_CNPJ);
            this.pgChamado.Controls.Add(this.lblNome);
            this.pgChamado.Controls.Add(this.txtEmail);
            this.pgChamado.Controls.Add(this.txtResidencial);
            this.pgChamado.Controls.Add(this.txtDddRes);
            this.pgChamado.Controls.Add(this.txtCel);
            this.pgChamado.Controls.Add(this.txtDddCel);
            this.pgChamado.Controls.Add(this.txtCpfCnpj);
            this.pgChamado.Controls.Add(this.txtNome);
            this.pgChamado.Location = new System.Drawing.Point(4, 22);
            this.pgChamado.Name = "pgChamado";
            this.pgChamado.Padding = new System.Windows.Forms.Padding(3);
            this.pgChamado.Size = new System.Drawing.Size(753, 351);
            this.pgChamado.TabIndex = 0;
            this.pgChamado.Text = "Chamado";
            this.pgChamado.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(37, 159);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(680, 154);
            this.txtDescricao.TabIndex = 17;
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Location = new System.Drawing.Point(642, 319);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarDados.TabIndex = 16;
            this.btnSalvarDados.Text = "Salvar ";
            this.btnSalvarDados.UseVisualStyleBackColor = true;
            // 
            // lblDadosCliente
            // 
            this.lblDadosCliente.AutoSize = true;
            this.lblDadosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCliente.Location = new System.Drawing.Point(7, 7);
            this.lblDadosCliente.Name = "lblDadosCliente";
            this.lblDadosCliente.Size = new System.Drawing.Size(117, 15);
            this.lblDadosCliente.TabIndex = 14;
            this.lblDadosCliente.Text = "Dados do Cliente";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(469, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblResidencial
            // 
            this.lblResidencial.AutoSize = true;
            this.lblResidencial.Location = new System.Drawing.Point(293, 73);
            this.lblResidencial.Name = "lblResidencial";
            this.lblResidencial.Size = new System.Drawing.Size(62, 13);
            this.lblResidencial.TabIndex = 12;
            this.lblResidencial.Text = "Residencial";
            // 
            // lblDDDR
            // 
            this.lblDDDR.AutoSize = true;
            this.lblDDDR.Location = new System.Drawing.Point(252, 73);
            this.lblDDDR.Name = "lblDDDR";
            this.lblDDDR.Size = new System.Drawing.Size(31, 13);
            this.lblDDDR.TabIndex = 11;
            this.lblDDDR.Text = "DDD";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(75, 73);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "Celular";
            // 
            // lblDDDC
            // 
            this.lblDDDC.AutoSize = true;
            this.lblDDDC.Location = new System.Drawing.Point(34, 73);
            this.lblDDDC.Name = "lblDDDC";
            this.lblDDDC.Size = new System.Drawing.Size(31, 13);
            this.lblDDDC.TabIndex = 9;
            this.lblDDDC.Text = "DDD";
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(528, 26);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(65, 13);
            this.lblCPF_CNPJ.TabIndex = 8;
            this.lblCPF_CNPJ.Text = "CPF/ CNPJ:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(472, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtResidencial
            // 
            this.txtResidencial.Location = new System.Drawing.Point(283, 100);
            this.txtResidencial.Name = "txtResidencial";
            this.txtResidencial.Size = new System.Drawing.Size(183, 20);
            this.txtResidencial.TabIndex = 5;
            // 
            // txtDddRes
            // 
            this.txtDddRes.Location = new System.Drawing.Point(255, 100);
            this.txtDddRes.Name = "txtDddRes";
            this.txtDddRes.Size = new System.Drawing.Size(22, 20);
            this.txtDddRes.TabIndex = 4;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(66, 100);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(183, 20);
            this.txtCel.TabIndex = 3;
            // 
            // txtDddCel
            // 
            this.txtDddCel.Location = new System.Drawing.Point(37, 100);
            this.txtDddCel.Name = "txtDddCel";
            this.txtDddCel.Size = new System.Drawing.Size(23, 20);
            this.txtDddCel.TabIndex = 2;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(531, 45);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(186, 20);
            this.txtCpfCnpj.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(488, 20);
            this.txtNome.TabIndex = 0;
            // 
            // pgOS
            // 
            this.pgOS.Controls.Add(this.lvOrdemServico);
            this.pgOS.Controls.Add(this.txtOrdemServico);
            this.pgOS.Location = new System.Drawing.Point(4, 22);
            this.pgOS.Name = "pgOS";
            this.pgOS.Padding = new System.Windows.Forms.Padding(3);
            this.pgOS.Size = new System.Drawing.Size(753, 351);
            this.pgOS.TabIndex = 2;
            this.pgOS.Text = "Ordem de Serviço";
            this.pgOS.UseVisualStyleBackColor = true;
            // 
            // lvOrdemServico
            // 
            this.lvOrdemServico.Location = new System.Drawing.Point(22, 37);
            this.lvOrdemServico.Name = "lvOrdemServico";
            this.lvOrdemServico.Size = new System.Drawing.Size(361, 270);
            this.lvOrdemServico.TabIndex = 1;
            this.lvOrdemServico.UseCompatibleStateImageBehavior = false;
            // 
            // txtOrdemServico
            // 
            this.txtOrdemServico.Location = new System.Drawing.Point(389, 37);
            this.txtOrdemServico.Multiline = true;
            this.txtOrdemServico.Name = "txtOrdemServico";
            this.txtOrdemServico.Size = new System.Drawing.Size(328, 270);
            this.txtOrdemServico.TabIndex = 0;
            // 
            // pgHistorico
            // 
            this.pgHistorico.Controls.Add(this.listView1);
            this.pgHistorico.Location = new System.Drawing.Point(4, 22);
            this.pgHistorico.Name = "pgHistorico";
            this.pgHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.pgHistorico.Size = new System.Drawing.Size(753, 351);
            this.pgHistorico.TabIndex = 3;
            this.pgHistorico.Text = "Histórico";
            this.pgHistorico.UseVisualStyleBackColor = true;
            // 
            // pgVisitaTecnica
            // 
            this.pgVisitaTecnica.Location = new System.Drawing.Point(4, 22);
            this.pgVisitaTecnica.Name = "pgVisitaTecnica";
            this.pgVisitaTecnica.Padding = new System.Windows.Forms.Padding(3);
            this.pgVisitaTecnica.Size = new System.Drawing.Size(753, 351);
            this.pgVisitaTecnica.TabIndex = 1;
            this.pgVisitaTecnica.Text = "Visita Técnica";
            this.pgVisitaTecnica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chamado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VitalSigns.Properties.Resources.New_Project;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(65, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vptcDados);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDados";
            this.Text = "Dados";
            this.vptcDados.ResumeLayout(false);
            this.pgChamado.ResumeLayout(false);
            this.pgChamado.PerformLayout();
            this.pgOS.ResumeLayout(false);
            this.pgOS.PerformLayout();
            this.pgHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl vptcDados;
        private System.Windows.Forms.TabPage pgChamado;
        private System.Windows.Forms.TabPage pgVisitaTecnica;
        private System.Windows.Forms.TabPage pgOS;
        private System.Windows.Forms.TabPage pgHistorico;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblResidencial;
        private System.Windows.Forms.Label lblDDDR;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDDDC;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtResidencial;
        private System.Windows.Forms.TextBox txtDddRes;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtDddCel;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDadosCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.ListView lvOrdemServico;
        private System.Windows.Forms.TextBox txtOrdemServico;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListView listView1;
    }
}