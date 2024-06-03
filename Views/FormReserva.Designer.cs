namespace PSI_DA_PL1_F.Views
{
    partial class FormReserva
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
            this.listBoxTipo = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoPrato = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.groupBoxTipoPrato = new System.Windows.Forms.GroupBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.checkedListBoxExtras = new System.Windows.Forms.CheckedListBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.labelClientes = new System.Windows.Forms.Label();
            this.buttonAdicionarReserva = new System.Windows.Forms.Button();
            this.listBoxReservas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.groupBoxTipoPrato.SuspendLayout();
            this.groupBoxExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTipo
            // 
            this.listBoxTipo.FormattingEnabled = true;
            this.listBoxTipo.ItemHeight = 16;
            this.listBoxTipo.Location = new System.Drawing.Point(9, 21);
            this.listBoxTipo.Name = "listBoxTipo";
            this.listBoxTipo.Size = new System.Drawing.Size(266, 84);
            this.listBoxTipo.TabIndex = 1;
            this.listBoxTipo.SelectedIndexChanged += new System.EventHandler(this.listBoxTipo_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(631, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(11, 606);
            this.textBox1.TabIndex = 5;
            // 
            // textBoxDescricaoPrato
            // 
            this.textBoxDescricaoPrato.Location = new System.Drawing.Point(9, 145);
            this.textBoxDescricaoPrato.Name = "textBoxDescricaoPrato";
            this.textBoxDescricaoPrato.Size = new System.Drawing.Size(266, 22);
            this.textBoxDescricaoPrato.TabIndex = 6;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(6, 115);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(126, 16);
            this.labelDescricao.TabIndex = 7;
            this.labelDescricao.Text = "Descrição do Prato:";
            // 
            // groupBoxTipoPrato
            // 
            this.groupBoxTipoPrato.Controls.Add(this.buttonAdicionar);
            this.groupBoxTipoPrato.Controls.Add(this.buttonAdicionarReserva);
            this.groupBoxTipoPrato.Controls.Add(this.groupBoxExtras);
            this.groupBoxTipoPrato.Controls.Add(this.labelClientes);
            this.groupBoxTipoPrato.Controls.Add(this.listBoxTipo);
            this.groupBoxTipoPrato.Controls.Add(this.listBoxClientes);
            this.groupBoxTipoPrato.Controls.Add(this.labelDescricao);
            this.groupBoxTipoPrato.Controls.Add(this.textBoxDescricaoPrato);
            this.groupBoxTipoPrato.Location = new System.Drawing.Point(6, 12);
            this.groupBoxTipoPrato.Name = "groupBoxTipoPrato";
            this.groupBoxTipoPrato.Size = new System.Drawing.Size(619, 579);
            this.groupBoxTipoPrato.TabIndex = 8;
            this.groupBoxTipoPrato.TabStop = false;
            this.groupBoxTipoPrato.Text = "Tipo de prato:";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(62, 535);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(124, 31);
            this.buttonAdicionar.TabIndex = 9;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // groupBoxExtras
            // 
            this.groupBoxExtras.Controls.Add(this.checkedListBoxExtras);
            this.groupBoxExtras.Location = new System.Drawing.Point(9, 177);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Size = new System.Drawing.Size(262, 352);
            this.groupBoxExtras.TabIndex = 8;
            this.groupBoxExtras.TabStop = false;
            this.groupBoxExtras.Text = "Extras: ";
            // 
            // checkedListBoxExtras
            // 
            this.checkedListBoxExtras.FormattingEnabled = true;
            this.checkedListBoxExtras.Location = new System.Drawing.Point(26, 35);
            this.checkedListBoxExtras.Name = "checkedListBoxExtras";
            this.checkedListBoxExtras.Size = new System.Drawing.Size(206, 293);
            this.checkedListBoxExtras.TabIndex = 0;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(322, 90);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(269, 372);
            this.listBoxClientes.TabIndex = 9;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(401, 46);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(109, 29);
            this.labelClientes.TabIndex = 10;
            this.labelClientes.Text = "Clientes";
            // 
            // buttonAdicionarReserva
            // 
            this.buttonAdicionarReserva.Location = new System.Drawing.Point(388, 492);
            this.buttonAdicionarReserva.Name = "buttonAdicionarReserva";
            this.buttonAdicionarReserva.Size = new System.Drawing.Size(135, 37);
            this.buttonAdicionarReserva.TabIndex = 11;
            this.buttonAdicionarReserva.Text = "Adicionar Reserva";
            this.buttonAdicionarReserva.UseVisualStyleBackColor = true;
            this.buttonAdicionarReserva.Click += new System.EventHandler(this.buttonAdicionarReserva_Click);
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.ItemHeight = 16;
            this.listBoxReservas.Location = new System.Drawing.Point(720, 127);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(245, 340);
            this.listBoxReservas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(775, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reservas";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(780, 504);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(135, 37);
            this.button.TabIndex = 12;
            this.button.UseVisualStyleBackColor = true;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxReservas);
            this.Controls.Add(this.groupBoxTipoPrato);
            this.Controls.Add(this.textBox1);
            this.Name = "FormReserva";
            this.Text = "FormReserva";
            this.groupBoxTipoPrato.ResumeLayout(false);
            this.groupBoxTipoPrato.PerformLayout();
            this.groupBoxExtras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxDescricaoPrato;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.GroupBox groupBoxTipoPrato;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.CheckedListBox checkedListBoxExtras;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Button buttonAdicionarReserva;
        private System.Windows.Forms.ListBox listBoxReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
    }
}