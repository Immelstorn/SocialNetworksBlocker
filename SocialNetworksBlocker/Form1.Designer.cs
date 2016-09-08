namespace SocialNetworksBlocker
{
    partial class Form1
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
            this.txtBlock = new System.Windows.Forms.Button();
            this.txtUnblock = new System.Windows.Forms.Button();
            this.txtDomains = new System.Windows.Forms.TextBox();
            this.txtLocalhost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRestoreOnClose = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(28, 347);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(102, 23);
            this.txtBlock.TabIndex = 0;
            this.txtBlock.Text = "Заблокировать";
            this.txtBlock.UseVisualStyleBackColor = true;
            this.txtBlock.Click += new System.EventHandler(this.txtBlock_Click);
            // 
            // txtUnblock
            // 
            this.txtUnblock.Location = new System.Drawing.Point(201, 347);
            this.txtUnblock.Name = "txtUnblock";
            this.txtUnblock.Size = new System.Drawing.Size(102, 23);
            this.txtUnblock.TabIndex = 1;
            this.txtUnblock.Text = "Разблокировать";
            this.txtUnblock.UseVisualStyleBackColor = true;
            this.txtUnblock.Click += new System.EventHandler(this.txtUnblock_Click);
            // 
            // txtDomains
            // 
            this.txtDomains.Location = new System.Drawing.Point(28, 39);
            this.txtDomains.Multiline = true;
            this.txtDomains.Name = "txtDomains";
            this.txtDomains.Size = new System.Drawing.Size(275, 201);
            this.txtDomains.TabIndex = 2;
            // 
            // txtLocalhost
            // 
            this.txtLocalhost.Location = new System.Drawing.Point(28, 275);
            this.txtLocalhost.Name = "txtLocalhost";
            this.txtLocalhost.Size = new System.Drawing.Size(275, 20);
            this.txtLocalhost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Домены для блокировки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Замкнуть на";
            // 
            // chkRestoreOnClose
            // 
            this.chkRestoreOnClose.AutoSize = true;
            this.chkRestoreOnClose.Checked = true;
            this.chkRestoreOnClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRestoreOnClose.Location = new System.Drawing.Point(28, 312);
            this.chkRestoreOnClose.Name = "chkRestoreOnClose";
            this.chkRestoreOnClose.Size = new System.Drawing.Size(204, 17);
            this.chkRestoreOnClose.TabIndex = 6;
            this.chkRestoreOnClose.Text = "Восстанавливать hosts при выходе";
            this.chkRestoreOnClose.UseVisualStyleBackColor = true;
            this.chkRestoreOnClose.CheckedChanged += new System.EventHandler(this.chkRestoreOnClose_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 392);
            this.Controls.Add(this.chkRestoreOnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocalhost);
            this.Controls.Add(this.txtDomains);
            this.Controls.Add(this.txtUnblock);
            this.Controls.Add(this.txtBlock);
            this.Name = "Form1";
            this.Text = "Блокировщик социальщины";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtBlock;
        private System.Windows.Forms.Button txtUnblock;
        private System.Windows.Forms.TextBox txtDomains;
        private System.Windows.Forms.TextBox txtLocalhost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRestoreOnClose;
    }
}

