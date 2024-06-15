namespace PSI_DA_PL1_F.Views
{
    partial class FormVistaSemanal
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
            this.listBoxDias = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCriarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDias
            // 
            this.listBoxDias.FormattingEnabled = true;
            this.listBoxDias.Location = new System.Drawing.Point(254, 101);
            this.listBoxDias.Name = "listBoxDias";
            this.listBoxDias.Size = new System.Drawing.Size(129, 121);
            this.listBoxDias.TabIndex = 2;
            this.listBoxDias.SelectedIndexChanged += new System.EventHandler(this.listBoxDias_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(24, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(425, 101);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(233, 121);
            this.listBoxMenu.TabIndex = 9;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(696, 474);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 50);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Regressar ao Menu Principal";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(487, 248);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(98, 50);
            this.btnReservar.TabIndex = 20;
            this.btnReservar.Text = "Reservar Refeição";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCriarMenu
            // 
            this.btnCriarMenu.Location = new System.Drawing.Point(487, 331);
            this.btnCriarMenu.Name = "btnCriarMenu";
            this.btnCriarMenu.Size = new System.Drawing.Size(98, 50);
            this.btnCriarMenu.TabIndex = 21;
            this.btnCriarMenu.Text = "Criar Novo Menu";
            this.btnCriarMenu.UseVisualStyleBackColor = true;
            this.btnCriarMenu.Click += new System.EventHandler(this.btnCriarMenu_Click);
            // 
            // FormVistaSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 536);
            this.Controls.Add(this.btnCriarMenu);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.listBoxDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVistaSemanal";
            this.Text = "FormVistaSemanal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDias;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCriarMenu;
    }
}