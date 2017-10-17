namespace AccesBD
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
            this.btnNbChambres = new System.Windows.Forms.Button();
            this.btnReserverChambre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListeChambres
            // 
            this.btnListeChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeChambres.Location = new System.Drawing.Point(20, 24);
            this.btnListeChambres.Name = "btnListeChambres";
            this.btnListeChambres.Size = new System.Drawing.Size(241, 66);
            this.btnListeChambres.TabIndex = 0;
            this.btnListeChambres.Text = "Liste des chambres";
            this.btnListeChambres.UseVisualStyleBackColor = true;
            this.btnListeChambres.Click += new System.EventHandler(this.btnListeChambres_Click);
            // 
            // btnNbChambres
            // 
            this.btnNbChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNbChambres.Location = new System.Drawing.Point(20, 109);
            this.btnNbChambres.Name = "btnNbChambres";
            this.btnNbChambres.Size = new System.Drawing.Size(241, 66);
            this.btnNbChambres.TabIndex = 1;
            this.btnNbChambres.Text = "Nombre de chambres";
            this.btnNbChambres.UseVisualStyleBackColor = true;
            this.btnNbChambres.Click += new System.EventHandler(this.btnNbChambres_Click);
            // 
            // btnReserverChambre
            // 
            this.btnReserverChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserverChambre.Location = new System.Drawing.Point(20, 194);
            this.btnReserverChambre.Name = "btnReserverChambre";
            this.btnReserverChambre.Size = new System.Drawing.Size(241, 66);
            this.btnReserverChambre.TabIndex = 2;
            this.btnReserverChambre.Text = "Réserver chambre";
            this.btnReserverChambre.UseVisualStyleBackColor = true;
            this.btnReserverChambre.Click += new System.EventHandler(this.btnReserverChambre_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 290);
            this.Controls.Add(this.btnReserverChambre);
            this.Controls.Add(this.btnNbChambres);
            this.Controls.Add(this.btnListeChambres);
            this.Name = "MainForm";
            this.Text = "Accès BD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListeChambres;
        private System.Windows.Forms.Button btnNbChambres;
        private System.Windows.Forms.Button btnReserverChambre;
    }
}

