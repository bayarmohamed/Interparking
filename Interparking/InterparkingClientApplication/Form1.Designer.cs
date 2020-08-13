namespace InterparkingClientApplication
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.CboRoles = new System.Windows.Forms.ComboBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.CboFileTypes = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkUseRole = new System.Windows.Forms.CheckBox();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkEncryption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CboRoles
            // 
            this.CboRoles.FormattingEnabled = true;
            this.CboRoles.Location = new System.Drawing.Point(81, 156);
            this.CboRoles.Name = "CboRoles";
            this.CboRoles.Size = new System.Drawing.Size(138, 21);
            this.CboRoles.TabIndex = 7;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(81, 63);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(262, 20);
            this.txtPath.TabIndex = 6;
            // 
            // CboFileTypes
            // 
            this.CboFileTypes.FormattingEnabled = true;
            this.CboFileTypes.Location = new System.Drawing.Point(81, 36);
            this.CboFileTypes.Name = "CboFileTypes";
            this.CboFileTypes.Size = new System.Drawing.Size(138, 21);
            this.CboFileTypes.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(321, 96);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 32);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Role";
            // 
            // ChkUseRole
            // 
            this.ChkUseRole.AutoSize = true;
            this.ChkUseRole.Location = new System.Drawing.Point(81, 131);
            this.ChkUseRole.Name = "ChkUseRole";
            this.ChkUseRole.Size = new System.Drawing.Size(70, 17);
            this.ChkUseRole.TabIndex = 11;
            this.ChkUseRole.Text = "Use Role";
            this.ChkUseRole.UseVisualStyleBackColor = true;
            // 
            // btnFileSearch
            // 
            this.btnFileSearch.Location = new System.Drawing.Point(349, 59);
            this.btnFileSearch.Name = "btnFileSearch";
            this.btnFileSearch.Size = new System.Drawing.Size(36, 26);
            this.btnFileSearch.TabIndex = 12;
            this.btnFileSearch.Text = "...";
            this.btnFileSearch.UseVisualStyleBackColor = true;
            this.btnFileSearch.Click += new System.EventHandler(this.btnFileSearch_Click);
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(81, 191);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(429, 220);
            this.txtFileContent.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "File Content";
            // 
            // ChkEncryption
            // 
            this.ChkEncryption.AutoSize = true;
            this.ChkEncryption.Location = new System.Drawing.Point(81, 105);
            this.ChkEncryption.Name = "ChkEncryption";
            this.ChkEncryption.Size = new System.Drawing.Size(98, 17);
            this.ChkEncryption.TabIndex = 15;
            this.ChkEncryption.Text = "Use Encryption";
            this.ChkEncryption.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkEncryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.btnFileSearch);
            this.Controls.Add(this.ChkUseRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboRoles);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.CboFileTypes);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboRoles;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox CboFileTypes;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkUseRole;
        private System.Windows.Forms.Button btnFileSearch;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkEncryption;
    }
}

