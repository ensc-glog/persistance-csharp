namespace GestionFichiers
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
            this.saveBinBtn = new System.Windows.Forms.Button();
            this.loadBinBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveXmlBtn = new System.Windows.Forms.Button();
            this.loadXmlBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveJsonBtn = new System.Windows.Forms.Button();
            this.loadJsonBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBinBtn
            // 
            this.saveBinBtn.Location = new System.Drawing.Point(47, 47);
            this.saveBinBtn.Name = "saveBinBtn";
            this.saveBinBtn.Size = new System.Drawing.Size(105, 27);
            this.saveBinBtn.TabIndex = 0;
            this.saveBinBtn.Text = "Sauvegarder";
            this.saveBinBtn.UseVisualStyleBackColor = true;
            this.saveBinBtn.Click += new System.EventHandler(this.saveBinBtn_Click);
            // 
            // loadBinBtn
            // 
            this.loadBinBtn.Location = new System.Drawing.Point(25, 67);
            this.loadBinBtn.Name = "loadBinBtn";
            this.loadBinBtn.Size = new System.Drawing.Size(105, 27);
            this.loadBinBtn.TabIndex = 1;
            this.loadBinBtn.Text = "Charger";
            this.loadBinBtn.UseVisualStyleBackColor = true;
            this.loadBinBtn.Click += new System.EventHandler(this.loadBinBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadBinBtn);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binaire";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveXmlBtn);
            this.groupBox2.Controls.Add(this.loadXmlBtn);
            this.groupBox2.Location = new System.Drawing.Point(213, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XML";
            // 
            // saveXmlBtn
            // 
            this.saveXmlBtn.Location = new System.Drawing.Point(25, 23);
            this.saveXmlBtn.Name = "saveXmlBtn";
            this.saveXmlBtn.Size = new System.Drawing.Size(105, 27);
            this.saveXmlBtn.TabIndex = 2;
            this.saveXmlBtn.Text = "Sauvegarder";
            this.saveXmlBtn.UseVisualStyleBackColor = true;
            this.saveXmlBtn.Click += new System.EventHandler(this.saveXmlBtn_Click);
            // 
            // loadXmlBtn
            // 
            this.loadXmlBtn.Location = new System.Drawing.Point(25, 67);
            this.loadXmlBtn.Name = "loadXmlBtn";
            this.loadXmlBtn.Size = new System.Drawing.Size(105, 27);
            this.loadXmlBtn.TabIndex = 1;
            this.loadXmlBtn.Text = "Charger";
            this.loadXmlBtn.UseVisualStyleBackColor = true;
            this.loadXmlBtn.Click += new System.EventHandler(this.loadXmlBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveJsonBtn);
            this.groupBox3.Controls.Add(this.loadJsonBtn);
            this.groupBox3.Location = new System.Drawing.Point(404, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 107);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "JSON";
            // 
            // saveJsonBtn
            // 
            this.saveJsonBtn.Location = new System.Drawing.Point(25, 23);
            this.saveJsonBtn.Name = "saveJsonBtn";
            this.saveJsonBtn.Size = new System.Drawing.Size(105, 27);
            this.saveJsonBtn.TabIndex = 2;
            this.saveJsonBtn.Text = "Sauvegarder";
            this.saveJsonBtn.UseVisualStyleBackColor = true;
            this.saveJsonBtn.Click += new System.EventHandler(this.saveJsonBtn_Click);
            // 
            // loadJsonBtn
            // 
            this.loadJsonBtn.Location = new System.Drawing.Point(25, 67);
            this.loadJsonBtn.Name = "loadJsonBtn";
            this.loadJsonBtn.Size = new System.Drawing.Size(105, 27);
            this.loadJsonBtn.TabIndex = 1;
            this.loadJsonBtn.Text = "Charger";
            this.loadJsonBtn.UseVisualStyleBackColor = true;
            this.loadJsonBtn.Click += new System.EventHandler(this.loadJsonBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 155);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveBinBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Gestion des fichiers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBinBtn;
        private System.Windows.Forms.Button loadBinBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveXmlBtn;
        private System.Windows.Forms.Button loadXmlBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveJsonBtn;
        private System.Windows.Forms.Button loadJsonBtn;
    }
}

