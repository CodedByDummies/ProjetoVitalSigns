namespace VitalSigns.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.picVitalSigns = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lnkEsqSenha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picVitalSigns)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(194, 263);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(254, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(194, 289);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(254, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(139, 266);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(139, 292);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Location = new System.Drawing.Point(194, 236);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(254, 21);
            this.cbxPerfil.TabIndex = 5;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(139, 239);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil:";
            // 
            // picVitalSigns
            // 
            this.picVitalSigns.Image = global::VitalSigns.Properties.Resources.New_Project;
            this.picVitalSigns.Location = new System.Drawing.Point(208, 95);
            this.picVitalSigns.Name = "picVitalSigns";
            this.picVitalSigns.Size = new System.Drawing.Size(213, 135);
            this.picVitalSigns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVitalSigns.TabIndex = 7;
            this.picVitalSigns.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(194, 315);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lnkEsqSenha
            // 
            this.lnkEsqSenha.AutoSize = true;
            this.lnkEsqSenha.Location = new System.Drawing.Point(346, 325);
            this.lnkEsqSenha.Name = "lnkEsqSenha";
            this.lnkEsqSenha.Size = new System.Drawing.Size(102, 13);
            this.lnkEsqSenha.TabIndex = 9;
            this.lnkEsqSenha.TabStop = true;
            this.lnkEsqSenha.Text = "Esqueceu a senha?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.lnkEsqSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.picVitalSigns);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.cbxPerfil);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picVitalSigns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.PictureBox picVitalSigns;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lnkEsqSenha;
    }
}