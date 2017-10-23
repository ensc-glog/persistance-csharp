namespace Repository
{
    partial class MainForm
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
            this.btnListeChambres = new System.Windows.Forms.Button();
            this.btnListeHotels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListeChambres
            // 
            this.btnListeChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeChambres.Location = new System.Drawing.Point(21, 23);
            this.btnListeChambres.Name = "btnListeChambres";
            this.btnListeChambres.Size = new System.Drawing.Size(241, 66);
            this.btnListeChambres.TabIndex = 1;
            this.btnListeChambres.Text = "Liste des chambres";
            this.btnListeChambres.UseVisualStyleBackColor = true;
            this.btnListeChambres.Click += new System.EventHandler(this.btnListeChambres_Click);
            // 
            // btnListeHotels
            // 
            this.btnListeHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeHotels.Location = new System.Drawing.Point(21, 110);
            this.btnListeHotels.Name = "btnListeHotels";
            this.btnListeHotels.Size = new System.Drawing.Size(241, 66);
            this.btnListeHotels.TabIndex = 2;
            this.btnListeHotels.Text = "Liste des hôtels";
            this.btnListeHotels.UseVisualStyleBackColor = true;
            this.btnListeHotels.Click += new System.EventHandler(this.btnListeHotels_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.btnListeHotels);
            this.Controls.Add(this.btnListeChambres);
            this.Name = "MainForm";
            this.Text = "Repository";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListeChambres;
        private System.Windows.Forms.Button btnListeHotels;
    }
}

