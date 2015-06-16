namespace Aselmaslar
{
    partial class FrmVeriAktar
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
            this.cmbHedef = new System.Windows.Forms.ComboBox();
            this.btnVeriAktar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbHedef
            // 
            this.cmbHedef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHedef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHedef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHedef.FormattingEnabled = true;
            this.cmbHedef.Location = new System.Drawing.Point(17, 59);
            this.cmbHedef.Name = "cmbHedef";
            this.cmbHedef.Size = new System.Drawing.Size(154, 21);
            this.cmbHedef.TabIndex = 0;
            // 
            // btnVeriAktar
            // 
            this.btnVeriAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriAktar.Location = new System.Drawing.Point(17, 108);
            this.btnVeriAktar.Name = "btnVeriAktar";
            this.btnVeriAktar.Size = new System.Drawing.Size(154, 36);
            this.btnVeriAktar.TabIndex = 1;
            this.btnVeriAktar.Text = "Veriyi Aktar";
            this.btnVeriAktar.UseVisualStyleBackColor = true;
            this.btnVeriAktar.Click += new System.EventHandler(this.btnVeriAktar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hedef Seçiniz!!!";
            // 
            // FrmVeriAktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVeriAktar);
            this.Controls.Add(this.cmbHedef);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVeriAktar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Aktar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVeriAktar_FormClosed);
            this.Load += new System.EventHandler(this.FrmVeriAktar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHedef;
        private System.Windows.Forms.Button btnVeriAktar;
        private System.Windows.Forms.Label label1;
    }
}