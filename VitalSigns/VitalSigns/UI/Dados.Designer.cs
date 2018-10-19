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
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.lblDadosCliente = new System.Windows.Forms.Label();
            this.lblDDDC = new System.Windows.Forms.Label();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblResidencial = new System.Windows.Forms.Label();
            this.lblDDDR = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtResidencial = new System.Windows.Forms.TextBox();
            this.txtDddRes = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtDddCel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pgOS = new System.Windows.Forms.TabPage();
            this.lvOrdemServico = new System.Windows.Forms.ListView();
            this.txtOrdemServico = new System.Windows.Forms.TextBox();
            this.pgHistorico = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pgVisitaTecnica = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vptcDados.SuspendLayout();
            this.pgChamado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pgOS.SuspendLayout();
            this.pgHistorico.SuspendLayout();
            this.pgVisitaTecnica.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pgChamado.Controls.Add(this.btnSalvarDados);
            this.pgChamado.Controls.Add(this.lblDadosCliente);
            this.pgChamado.Controls.Add(this.panel2);
            this.pgChamado.Location = new System.Drawing.Point(4, 22);
            this.pgChamado.Name = "pgChamado";
            this.pgChamado.Padding = new System.Windows.Forms.Padding(3);
            this.pgChamado.Size = new System.Drawing.Size(753, 351);
            this.pgChamado.TabIndex = 0;
            this.pgChamado.Text = "Chamado";
            this.pgChamado.UseVisualStyleBackColor = true;
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Location = new System.Drawing.Point(642, 322);
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
            // lblDDDC
            // 
            this.lblDDDC.AutoSize = true;
            this.lblDDDC.Location = new System.Drawing.Point(5, 48);
            this.lblDDDC.Name = "lblDDDC";
            this.lblDDDC.Size = new System.Drawing.Size(31, 13);
            this.lblDDDC.TabIndex = 9;
            this.lblDDDC.Text = "DDD";
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(499, 6);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(65, 13);
            this.lblCPF_CNPJ.TabIndex = 8;
            this.lblCPF_CNPJ.Text = "CPF/ CNPJ:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(2, 6);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(440, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblCPF_CNPJ);
            this.panel2.Controls.Add(this.lblDDDC);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.lblResidencial);
            this.panel2.Controls.Add(this.lblDDDR);
            this.panel2.Controls.Add(this.lblCelular);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtResidencial);
            this.panel2.Controls.Add(this.txtDddRes);
            this.panel2.Controls.Add(this.txtCel);
            this.panel2.Controls.Add(this.txtCpfCnpj);
            this.panel2.Controls.Add(this.txtDddCel);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Location = new System.Drawing.Point(32, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 273);
            this.panel2.TabIndex = 18;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(5, 116);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(680, 154);
            this.txtDescricao.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(440, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblResidencial
            // 
            this.lblResidencial.AutoSize = true;
            this.lblResidencial.Location = new System.Drawing.Point(260, 48);
            this.lblResidencial.Name = "lblResidencial";
            this.lblResidencial.Size = new System.Drawing.Size(62, 13);
            this.lblResidencial.TabIndex = 12;
            this.lblResidencial.Text = "Residencial";
            // 
            // lblDDDR
            // 
            this.lblDDDR.AutoSize = true;
            this.lblDDDR.Location = new System.Drawing.Point(223, 48);
            this.lblDDDR.Name = "lblDDDR";
            this.lblDDDR.Size = new System.Drawing.Size(31, 13);
            this.lblDDDR.TabIndex = 11;
            this.lblDDDR.Text = "DDD";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(42, 48);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "Celular";
            // 
            // txtResidencial
            // 
            this.txtResidencial.Location = new System.Drawing.Point(260, 75);
            this.txtResidencial.Name = "txtResidencial";
            this.txtResidencial.Size = new System.Drawing.Size(174, 20);
            this.txtResidencial.TabIndex = 5;
            // 
            // txtDddRes
            // 
            this.txtDddRes.Location = new System.Drawing.Point(219, 75);
            this.txtDddRes.Name = "txtDddRes";
            this.txtDddRes.Size = new System.Drawing.Size(35, 20);
            this.txtDddRes.TabIndex = 4;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(46, 75);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(167, 20);
            this.txtCel.TabIndex = 3;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(499, 22);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(186, 20);
            this.txtCpfCnpj.TabIndex = 1;
            // 
            // txtDddCel
            // 
            this.txtDddCel.Location = new System.Drawing.Point(5, 75);
            this.txtDddCel.Name = "txtDddCel";
            this.txtDddCel.Size = new System.Drawing.Size(35, 20);
            this.txtDddCel.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(5, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(483, 20);
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(65, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pgVisitaTecnica
            // 
            this.pgVisitaTecnica.Controls.Add(this.panel1);
            this.pgVisitaTecnica.Controls.Add(this.textBox6);
            this.pgVisitaTecnica.Controls.Add(this.textBox5);
            this.pgVisitaTecnica.Location = new System.Drawing.Point(4, 22);
            this.pgVisitaTecnica.Name = "pgVisitaTecnica";
            this.pgVisitaTecnica.Padding = new System.Windows.Forms.Padding(3);
            this.pgVisitaTecnica.Size = new System.Drawing.Size(753, 351);
            this.pgVisitaTecnica.TabIndex = 1;
            this.pgVisitaTecnica.Text = "Visita Técnica";
            this.pgVisitaTecnica.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(51, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 278);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "label1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(220, 262);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(220, 236);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pgOS.ResumeLayout(false);
            this.pgOS.PerformLayout();
            this.pgHistorico.ResumeLayout(false);
            this.pgVisitaTecnica.ResumeLayout(false);
            this.pgVisitaTecnica.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
    }
}