namespace DynamicHangarMod
{
    partial class HangarMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangarMemory));
            this.DeplaceButton = new System.Windows.Forms.Button();
            this.ClosingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeplaceButton
            // 
            this.DeplaceButton.Location = new System.Drawing.Point(195, 264);
            this.DeplaceButton.Name = "DeplaceButton";
            this.DeplaceButton.Size = new System.Drawing.Size(162, 32);
            this.DeplaceButton.TabIndex = 0;
            this.DeplaceButton.UseVisualStyleBackColor = true;
            this.DeplaceButton.Click += new System.EventHandler(this.DeplaceButton_Click);
            // 
            // ClosingButton
            // 
            this.ClosingButton.BackColor = System.Drawing.Color.Red;
            this.ClosingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClosingButton.Location = new System.Drawing.Point(507, 12);
            this.ClosingButton.Name = "ClosingButton";
            this.ClosingButton.Size = new System.Drawing.Size(41, 23);
            this.ClosingButton.TabIndex = 1;
            this.ClosingButton.Text = "close";
            this.ClosingButton.UseVisualStyleBackColor = false;
            this.ClosingButton.Click += new System.EventHandler(this.ClosingButton_Click);
            // 
            // HangarMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 315);
            this.Controls.Add(this.ClosingButton);
            this.Controls.Add(this.DeplaceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HangarMemory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HangarMemory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeplaceButton;
        private System.Windows.Forms.Button ClosingButton;
    }
}

