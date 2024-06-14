namespace PSI_DA_PL1_F.Views
{
    partial class FormExtras
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoverExtra = new System.Windows.Forms.Button();
            this.checkBoxAtivarExtra = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPreco = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionarExtra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxExtras = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPrecoEdit = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescricaoEdit = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateExtra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoverExtra);
            this.groupBox2.Controls.Add(this.checkBoxAtivarExtra);
            this.groupBox2.Location = new System.Drawing.Point(526, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 203);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de Tratamento do Extra";
            // 
            // btnRemoverExtra
            // 
            this.btnRemoverExtra.Location = new System.Drawing.Point(55, 102);
            this.btnRemoverExtra.Name = "btnRemoverExtra";
            this.btnRemoverExtra.Size = new System.Drawing.Size(98, 50);
            this.btnRemoverExtra.TabIndex = 6;
            this.btnRemoverExtra.Text = "Remover Extra";
            this.btnRemoverExtra.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtivarExtra
            // 
            this.checkBoxAtivarExtra.AutoSize = true;
            this.checkBoxAtivarExtra.Location = new System.Drawing.Point(55, 46);
            this.checkBoxAtivarExtra.Name = "checkBoxAtivarExtra";
            this.checkBoxAtivarExtra.Size = new System.Drawing.Size(77, 17);
            this.checkBoxAtivarExtra.TabIndex = 8;
            this.checkBoxAtivarExtra.Text = "Extra Ativo";
            this.checkBoxAtivarExtra.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPreco);
            this.groupBox1.Controls.Add(this.textBoxDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdicionarExtra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 257);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de Criação do Extra";
            // 
            // numericUpDownPreco
            // 
            this.numericUpDownPreco.Location = new System.Drawing.Point(35, 150);
            this.numericUpDownPreco.Name = "numericUpDownPreco";
            this.numericUpDownPreco.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPreco.TabIndex = 6;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(35, 69);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(308, 47);
            this.textBoxDescricao.TabIndex = 2;
            this.textBoxDescricao.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição do Extra:";
            // 
            // btnAdicionarExtra
            // 
            this.btnAdicionarExtra.Location = new System.Drawing.Point(35, 192);
            this.btnAdicionarExtra.Name = "btnAdicionarExtra";
            this.btnAdicionarExtra.Size = new System.Drawing.Size(156, 23);
            this.btnAdicionarExtra.TabIndex = 0;
            this.btnAdicionarExtra.Text = "Adicionar Extra";
            this.btnAdicionarExtra.UseVisualStyleBackColor = true;
            this.btnAdicionarExtra.Click += new System.EventHandler(this.btnAdicionarExtra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preço do Extra:";
            // 
            // listBoxExtras
            // 
            this.listBoxExtras.FormattingEnabled = true;
            this.listBoxExtras.Location = new System.Drawing.Point(437, 12);
            this.listBoxExtras.Name = "listBoxExtras";
            this.listBoxExtras.Size = new System.Drawing.Size(347, 225);
            this.listBoxExtras.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownPrecoEdit);
            this.groupBox3.Controls.Add(this.textBoxDescricaoEdit);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnUpdateExtra);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(13, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 237);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Área de Atualização do Extra";
            // 
            // numericUpDownPrecoEdit
            // 
            this.numericUpDownPrecoEdit.Location = new System.Drawing.Point(35, 151);
            this.numericUpDownPrecoEdit.Name = "numericUpDownPrecoEdit";
            this.numericUpDownPrecoEdit.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrecoEdit.TabIndex = 6;
            // 
            // textBoxDescricaoEdit
            // 
            this.textBoxDescricaoEdit.Location = new System.Drawing.Point(35, 70);
            this.textBoxDescricaoEdit.Name = "textBoxDescricaoEdit";
            this.textBoxDescricaoEdit.Size = new System.Drawing.Size(308, 47);
            this.textBoxDescricaoEdit.TabIndex = 2;
            this.textBoxDescricaoEdit.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição do Extra:";
            // 
            // btnUpdateExtra
            // 
            this.btnUpdateExtra.Location = new System.Drawing.Point(35, 193);
            this.btnUpdateExtra.Name = "btnUpdateExtra";
            this.btnUpdateExtra.Size = new System.Drawing.Size(156, 23);
            this.btnUpdateExtra.TabIndex = 0;
            this.btnUpdateExtra.Text = "Atualizar Extra";
            this.btnUpdateExtra.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço do Extra:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(696, 474);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 50);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Regressar ao Menu Principal";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 536);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxExtras);
            this.Name = "FormExtras";
            this.Text = "FormExtras";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoverExtra;
        private System.Windows.Forms.CheckBox checkBoxAtivarExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox textBoxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionarExtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxExtras;
        private System.Windows.Forms.NumericUpDown numericUpDownPreco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecoEdit;
        private System.Windows.Forms.RichTextBox textBoxDescricaoEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateExtra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturn;
    }
}