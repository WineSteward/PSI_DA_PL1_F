namespace PSI_DA_PL1_F.Views
{
    partial class FormPratos
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
            this.btnAdicionarPrato = new System.Windows.Forms.Button();
            this.listBoxPratos = new System.Windows.Forms.ListBox();
            this.textBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.listBoxTipoPrato = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoverPrato = new System.Windows.Forms.Button();
            this.checkBoxAtivarPrato = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDescricaoEdit = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdatePrato = new System.Windows.Forms.Button();
            this.listBoxTipoPratoEdit = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarPrato
            // 
            this.btnAdicionarPrato.Location = new System.Drawing.Point(6, 181);
            this.btnAdicionarPrato.Name = "btnAdicionarPrato";
            this.btnAdicionarPrato.Size = new System.Drawing.Size(156, 23);
            this.btnAdicionarPrato.TabIndex = 0;
            this.btnAdicionarPrato.Text = "Adicionar Prato";
            this.btnAdicionarPrato.UseVisualStyleBackColor = true;
            // 
            // listBoxPratos
            // 
            this.listBoxPratos.FormattingEnabled = true;
            this.listBoxPratos.Location = new System.Drawing.Point(441, 10);
            this.listBoxPratos.Name = "listBoxPratos";
            this.listBoxPratos.Size = new System.Drawing.Size(347, 225);
            this.listBoxPratos.TabIndex = 1;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(6, 31);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(308, 47);
            this.textBoxDescricao.TabIndex = 2;
            this.textBoxDescricao.Text = "";
            // 
            // listBoxTipoPrato
            // 
            this.listBoxTipoPrato.FormattingEnabled = true;
            this.listBoxTipoPrato.Location = new System.Drawing.Point(6, 105);
            this.listBoxTipoPrato.Name = "listBoxTipoPrato";
            this.listBoxTipoPrato.Size = new System.Drawing.Size(83, 56);
            this.listBoxTipoPrato.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Prato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição do Prato:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdicionarPrato);
            this.groupBox1.Controls.Add(this.listBoxTipoPrato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 223);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de Criação do Prato";
            // 
            // btnRemoverPrato
            // 
            this.btnRemoverPrato.Location = new System.Drawing.Point(45, 114);
            this.btnRemoverPrato.Name = "btnRemoverPrato";
            this.btnRemoverPrato.Size = new System.Drawing.Size(98, 50);
            this.btnRemoverPrato.TabIndex = 6;
            this.btnRemoverPrato.Text = "Remover Prato";
            this.btnRemoverPrato.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtivarPrato
            // 
            this.checkBoxAtivarPrato.AutoSize = true;
            this.checkBoxAtivarPrato.Location = new System.Drawing.Point(55, 46);
            this.checkBoxAtivarPrato.Name = "checkBoxAtivarPrato";
            this.checkBoxAtivarPrato.Size = new System.Drawing.Size(78, 17);
            this.checkBoxAtivarPrato.TabIndex = 8;
            this.checkBoxAtivarPrato.Text = "Prato Ativo";
            this.checkBoxAtivarPrato.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoverPrato);
            this.groupBox2.Controls.Add(this.checkBoxAtivarPrato);
            this.groupBox2.Location = new System.Drawing.Point(521, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 179);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de Tratamento do Prato";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDescricaoEdit);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnUpdatePrato);
            this.groupBox3.Controls.Add(this.listBoxTipoPratoEdit);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(14, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 204);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Área de Edição do Prato";
            // 
            // textBoxDescricaoEdit
            // 
            this.textBoxDescricaoEdit.Location = new System.Drawing.Point(6, 31);
            this.textBoxDescricaoEdit.Name = "textBoxDescricaoEdit";
            this.textBoxDescricaoEdit.Size = new System.Drawing.Size(308, 47);
            this.textBoxDescricaoEdit.TabIndex = 2;
            this.textBoxDescricaoEdit.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição do Prato:";
            // 
            // btnUpdatePrato
            // 
            this.btnUpdatePrato.Location = new System.Drawing.Point(6, 175);
            this.btnUpdatePrato.Name = "btnUpdatePrato";
            this.btnUpdatePrato.Size = new System.Drawing.Size(156, 23);
            this.btnUpdatePrato.TabIndex = 0;
            this.btnUpdatePrato.Text = "Update Prato";
            this.btnUpdatePrato.UseVisualStyleBackColor = true;
            // 
            // listBoxTipoPratoEdit
            // 
            this.listBoxTipoPratoEdit.FormattingEnabled = true;
            this.listBoxTipoPratoEdit.Location = new System.Drawing.Point(6, 105);
            this.listBoxTipoPratoEdit.Name = "listBoxTipoPratoEdit";
            this.listBoxTipoPratoEdit.Size = new System.Drawing.Size(83, 56);
            this.listBoxTipoPratoEdit.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Prato:";
            // 
            // FormPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxPratos);
            this.Name = "FormPratos";
            this.Text = "FormPratos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarPrato;
        private System.Windows.Forms.ListBox listBoxPratos;
        private System.Windows.Forms.RichTextBox textBoxDescricao;
        private System.Windows.Forms.ListBox listBoxTipoPrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoverPrato;
        private System.Windows.Forms.CheckBox checkBoxAtivarPrato;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox textBoxDescricaoEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdatePrato;
        private System.Windows.Forms.ListBox listBoxTipoPratoEdit;
        private System.Windows.Forms.Label label4;
    }
}