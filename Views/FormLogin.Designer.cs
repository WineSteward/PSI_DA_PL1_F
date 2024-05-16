namespace PSI_DA_PL1_F.Views
{
    partial class FormLogin
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
            this.btnDirecionarRegisto = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirecionarRegisto
            // 
            this.btnDirecionarRegisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnDirecionarRegisto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDirecionarRegisto.Location = new System.Drawing.Point(649, 549);
            this.btnDirecionarRegisto.Name = "btnDirecionarRegisto";
            this.btnDirecionarRegisto.Size = new System.Drawing.Size(171, 37);
            this.btnDirecionarRegisto.TabIndex = 42;
            this.btnDirecionarRegisto.Text = "Adicionar Funcionario";
            this.btnDirecionarRegisto.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrar.Location = new System.Drawing.Point(649, 476);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(171, 38);
            this.btnEntrar.TabIndex = 41;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(117, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 47);
            this.label1.TabIndex = 35;
            this.label1.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSI_DA_PL1_F.Properties.Resources.Imagem1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.ItemHeight = 16;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(586, 125);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(302, 324);
            this.listBoxFuncionarios.TabIndex = 43;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(644, 42);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(190, 32);
            this.labelTitulo.TabIndex = 44;
            this.labelTitulo.Text = "Funcionários";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.listBoxFuncionarios);
            this.Controls.Add(this.btnDirecionarRegisto);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirecionarRegisto;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.Label labelTitulo;
    }
}