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
            this.buttonAdicionarReserva = new System.Windows.Forms.Button();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.checkedListBoxExtras = new System.Windows.Forms.CheckedListBox();
            this.labelClientes = new System.Windows.Forms.Label();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
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
            this.listBoxTipo.Location = new System.Drawing.Point(23, 29);
            this.listBoxTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxTipo.Name = "listBoxTipo";
            this.listBoxTipo.Size = new System.Drawing.Size(200, 69);
            this.listBoxTipo.TabIndex = 1;
            this.listBoxTipo.SelectedIndexChanged += new System.EventHandler(this.listBoxTipo_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(473, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 536);
            this.textBox1.TabIndex = 5;
            // 
            // textBoxDescricaoPrato
            // 
            this.textBoxDescricaoPrato.Location = new System.Drawing.Point(23, 130);
            this.textBoxDescricaoPrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescricaoPrato.Name = "textBoxDescricaoPrato";
            this.textBoxDescricaoPrato.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescricaoPrato.TabIndex = 6;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(20, 105);
            this.labelDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(101, 13);
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
            this.groupBoxTipoPrato.Location = new System.Drawing.Point(4, 10);
            this.groupBoxTipoPrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTipoPrato.Name = "groupBoxTipoPrato";
            this.groupBoxTipoPrato.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTipoPrato.Size = new System.Drawing.Size(465, 515);
            this.groupBoxTipoPrato.TabIndex = 8;
            this.groupBoxTipoPrato.TabStop = false;
            this.groupBoxTipoPrato.Text = "Tipo de prato:";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(62, 447);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(93, 25);
            this.buttonAdicionar.TabIndex = 9;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAdicionarReserva
            // 
            this.buttonAdicionarReserva.Location = new System.Drawing.Point(291, 425);
            this.buttonAdicionarReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarReserva.Name = "buttonAdicionarReserva";
            this.buttonAdicionarReserva.Size = new System.Drawing.Size(101, 30);
            this.buttonAdicionarReserva.TabIndex = 11;
            this.buttonAdicionarReserva.Text = "Adicionar Reserva";
            this.buttonAdicionarReserva.UseVisualStyleBackColor = true;
            this.buttonAdicionarReserva.Click += new System.EventHandler(this.buttonAdicionarReserva_Click);
            // 
            // groupBoxExtras
            // 
            this.groupBoxExtras.Controls.Add(this.checkedListBoxExtras);
            this.groupBoxExtras.Location = new System.Drawing.Point(23, 156);
            this.groupBoxExtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxExtras.Size = new System.Drawing.Size(196, 286);
            this.groupBoxExtras.TabIndex = 8;
            this.groupBoxExtras.TabStop = false;
            this.groupBoxExtras.Text = "Extras: ";
            // 
            // checkedListBoxExtras
            // 
            this.checkedListBoxExtras.FormattingEnabled = true;
            this.checkedListBoxExtras.Location = new System.Drawing.Point(20, 28);
            this.checkedListBoxExtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBoxExtras.Name = "checkedListBoxExtras";
            this.checkedListBoxExtras.Size = new System.Drawing.Size(156, 229);
            this.checkedListBoxExtras.TabIndex = 0;
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(301, 62);
            this.labelClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(85, 24);
            this.labelClientes.TabIndex = 10;
            this.labelClientes.Text = "Clientes";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(242, 98);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(203, 303);
            this.listBoxClientes.TabIndex = 9;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.Location = new System.Drawing.Point(543, 134);
            this.listBoxReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(185, 277);
            this.listBoxReservas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reservas";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(588, 441);
            this.button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(101, 30);
            this.button.TabIndex = 12;
            this.button.UseVisualStyleBackColor = true;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(806, 536);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxReservas);
            this.Controls.Add(this.groupBoxTipoPrato);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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