namespace Hasher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndHash = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtHash
            // 
            this.txtHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtHash.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash.Location = new System.Drawing.Point(12, 40);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(385, 31);
            this.txtHash.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.lbl.Location = new System.Drawing.Point(8, 14);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(184, 23);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Wort das gehasht wird";
            // 
            // btnHash
            // 
            this.btnHash.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnHash.Location = new System.Drawing.Point(277, 91);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(120, 35);
            this.btnHash.TabIndex = 2;
            this.btnHash.Text = "Hashen";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label1.Location = new System.Drawing.Point(8, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hash des Wortes";
            // 
            // txtEndHash
            // 
            this.txtEndHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtEndHash.Location = new System.Drawing.Point(12, 142);
            this.txtEndHash.Name = "txtEndHash";
            this.txtEndHash.Size = new System.Drawing.Size(385, 32);
            this.txtEndHash.TabIndex = 5;
            this.txtEndHash.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(409, 193);
            this.Controls.Add(this.txtEndHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtHash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtEndHash;
    }
}

