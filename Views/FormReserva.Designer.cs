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
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSaldoAdd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSaldoAtual = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaldoAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaldoAtual)).BeginInit();
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
            this.groupBoxTipoPrato.Controls.Add(this.label4);
            this.groupBoxTipoPrato.Controls.Add(this.numericUpDownSaldoAdd);
            this.groupBoxTipoPrato.Controls.Add(this.label3);
            this.groupBoxTipoPrato.Controls.Add(this.numericUpDownSaldoAtual);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Saldo a Depositar:";
            // 
            // numericUpDownSaldoAdd
            // 
            this.numericUpDownSaldoAdd.DecimalPlaces = 2;
            this.numericUpDownSaldoAdd.Location = new System.Drawing.Point(33, 432);
            this.numericUpDownSaldoAdd.Name = "numericUpDownSaldoAdd";
            this.numericUpDownSaldoAdd.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownSaldoAdd.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Saldo Atual:";
            // 
            // numericUpDownSaldoAtual
            // 
            this.numericUpDownSaldoAtual.DecimalPlaces = 2;
            this.numericUpDownSaldoAtual.Enabled = false;
            this.numericUpDownSaldoAtual.Location = new System.Drawing.Point(34, 381);
            this.numericUpDownSaldoAtual.Name = "numericUpDownSaldoAtual";
            this.numericUpDownSaldoAtual.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownSaldoAtual.TabIndex = 14;
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
            this.btnAddSaldo.Location = new System.Drawing.Point(19, 457);
            this.btnAddSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSaldo.Name = "btnAddSaldo";
            this.btnAddSaldo.Size = new System.Drawing.Size(101, 35);
            this.btnAddSaldo.TabIndex = 12;
            this.btnAddSaldo.Text = "Adicionar Saldo";
            this.btnAddSaldo.UseVisualStyleBackColor = true;
            this.btnAddSaldo.Click += new System.EventHandler(this.btnAddSaldo_Click);
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
            this.groupBoxExtras.Size = new System.Drawing.Size(196, 164);
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
            this.checkedListBoxExtras.Size = new System.Drawing.Size(156, 109);
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
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(203, 303);
            this.listBoxClientes.TabIndex = 9;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
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
            this.btnConsumir.Location = new System.Drawing.Point(579, 415);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaldoAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaldoAtual)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownSaldoAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSaldoAdd;
    }
}