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
            this.listBoxPratos = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTipoPrato = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSaldo = new System.Windows.Forms.Button();
            this.btnAdicionarReserva = new System.Windows.Forms.Button();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.checkedListBoxExtras = new System.Windows.Forms.CheckedListBox();
            this.labelClientes = new System.Windows.Forms.Label();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxReservas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBoxTipoPrato.SuspendLayout();
            this.groupBoxExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPratos
            // 
            this.listBoxPratos.FormattingEnabled = true;
            this.listBoxPratos.Location = new System.Drawing.Point(19, 88);
            this.listBoxPratos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPratos.Name = "listBoxPratos";
            this.listBoxPratos.Size = new System.Drawing.Size(200, 69);
            this.listBoxPratos.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(473, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 536);
            this.textBox1.TabIndex = 5;
            // 
            // groupBoxTipoPrato
            // 
            this.groupBoxTipoPrato.Controls.Add(this.label2);
            this.groupBoxTipoPrato.Controls.Add(this.btnAddSaldo);
            this.groupBoxTipoPrato.Controls.Add(this.btnAdicionarReserva);
            this.groupBoxTipoPrato.Controls.Add(this.groupBoxExtras);
            this.groupBoxTipoPrato.Controls.Add(this.labelClientes);
            this.groupBoxTipoPrato.Controls.Add(this.listBoxPratos);
            this.groupBoxTipoPrato.Controls.Add(this.listBoxClientes);
            this.groupBoxTipoPrato.Location = new System.Drawing.Point(4, 10);
            this.groupBoxTipoPrato.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTipoPrato.Name = "groupBoxTipoPrato";
            this.groupBoxTipoPrato.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTipoPrato.Size = new System.Drawing.Size(465, 515);
            this.groupBoxTipoPrato.TabIndex = 8;
            this.groupBoxTipoPrato.TabStop = false;
            this.groupBoxTipoPrato.Text = "Secção Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pratos";
            // 
            // btnAddSaldo
            // 
            this.btnAddSaldo.Location = new System.Drawing.Point(294, 468);
            this.btnAddSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSaldo.Name = "btnAddSaldo";
            this.btnAddSaldo.Size = new System.Drawing.Size(101, 35);
            this.btnAddSaldo.TabIndex = 12;
            this.btnAddSaldo.Text = "Adicionar Saldo";
            this.btnAddSaldo.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarReserva
            // 
            this.btnAdicionarReserva.Location = new System.Drawing.Point(294, 405);
            this.btnAdicionarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarReserva.Name = "btnAdicionarReserva";
            this.btnAdicionarReserva.Size = new System.Drawing.Size(101, 47);
            this.btnAdicionarReserva.TabIndex = 11;
            this.btnAdicionarReserva.Text = "Adicionar Reserva";
            this.btnAdicionarReserva.UseVisualStyleBackColor = true;
            this.btnAdicionarReserva.Click += new System.EventHandler(this.buttonAdicionarReserva_Click);
            // 
            // groupBoxExtras
            // 
            this.groupBoxExtras.Controls.Add(this.checkedListBoxExtras);
            this.groupBoxExtras.Location = new System.Drawing.Point(23, 175);
            this.groupBoxExtras.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxExtras.Size = new System.Drawing.Size(196, 286);
            this.groupBoxExtras.TabIndex = 8;
            this.groupBoxExtras.TabStop = false;
            this.groupBoxExtras.Text = "Extras: ";
            // 
            // checkedListBoxExtras
            // 
            this.checkedListBoxExtras.FormattingEnabled = true;
            this.checkedListBoxExtras.Location = new System.Drawing.Point(20, 28);
            this.checkedListBoxExtras.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxExtras.Name = "checkedListBoxExtras";
            this.checkedListBoxExtras.Size = new System.Drawing.Size(156, 229);
            this.checkedListBoxExtras.TabIndex = 0;
            this.checkedListBoxExtras.Click += new System.EventHandler(this.checkedListBoxExtras_Click);
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
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(203, 303);
            this.listBoxClientes.TabIndex = 9;
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.Location = new System.Drawing.Point(543, 134);
            this.listBoxReservas.Margin = new System.Windows.Forms.Padding(2);
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
            // btnConsumir
            // 
            this.btnConsumir.Location = new System.Drawing.Point(588, 441);
            this.btnConsumir.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(101, 30);
            this.btnConsumir.TabIndex = 12;
            this.btnConsumir.Text = "Consumir Reserva";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(696, 478);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 50);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Regressar ao Menu Principal";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(806, 536);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnConsumir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxReservas);
            this.Controls.Add(this.groupBoxTipoPrato);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReserva";
            this.Text = "FormReserva";
            this.groupBoxTipoPrato.ResumeLayout(false);
            this.groupBoxTipoPrato.PerformLayout();
            this.groupBoxExtras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPratos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxTipoPrato;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.CheckedListBox checkedListBoxExtras;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Button btnAdicionarReserva;
        private System.Windows.Forms.ListBox listBoxReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.Button btnAddSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
    }
}