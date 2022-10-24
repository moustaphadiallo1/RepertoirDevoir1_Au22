namespace Wf_Devoir
{
    partial class Frm_DE
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
            this.txt_DEcourant = new System.Windows.Forms.TextBox();
            this.lbl_nomFRM = new System.Windows.Forms.Label();
            this.btn_brasser = new System.Windows.Forms.Button();
            this.txt_valDEcourant = new System.Windows.Forms.TextBox();
            this.txt_toatalPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_DEcourant
            // 
            this.txt_DEcourant.Enabled = false;
            this.txt_DEcourant.Location = new System.Drawing.Point(369, 87);
            this.txt_DEcourant.Name = "txt_DEcourant";
            this.txt_DEcourant.Size = new System.Drawing.Size(100, 22);
            this.txt_DEcourant.TabIndex = 0;
            // 
            // lbl_nomFRM
            // 
            this.lbl_nomFRM.AutoSize = true;
            this.lbl_nomFRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomFRM.Location = new System.Drawing.Point(12, 9);
            this.lbl_nomFRM.Name = "lbl_nomFRM";
            this.lbl_nomFRM.Size = new System.Drawing.Size(231, 51);
            this.lbl_nomFRM.TabIndex = 1;
            this.lbl_nomFRM.Text = "Jeu de DE";
            // 
            // btn_brasser
            // 
            this.btn_brasser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brasser.Location = new System.Drawing.Point(39, 227);
            this.btn_brasser.Name = "btn_brasser";
            this.btn_brasser.Size = new System.Drawing.Size(148, 47);
            this.btn_brasser.TabIndex = 2;
            this.btn_brasser.Text = "Brasser";
            this.btn_brasser.UseVisualStyleBackColor = true;
            this.btn_brasser.Click += new System.EventHandler(this.btn_brasser_Click);
            // 
            // txt_valDEcourant
            // 
            this.txt_valDEcourant.Enabled = false;
            this.txt_valDEcourant.Location = new System.Drawing.Point(369, 135);
            this.txt_valDEcourant.Name = "txt_valDEcourant";
            this.txt_valDEcourant.Size = new System.Drawing.Size(100, 22);
            this.txt_valDEcourant.TabIndex = 3;
            // 
            // txt_toatalPoints
            // 
            this.txt_toatalPoints.Enabled = false;
            this.txt_toatalPoints.Location = new System.Drawing.Point(369, 171);
            this.txt_toatalPoints.Name = "txt_toatalPoints";
            this.txt_toatalPoints.Size = new System.Drawing.Size(100, 22);
            this.txt_toatalPoints.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type de DE courant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "La valeur du DE courant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total points";
            // 
            // Frm_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_toatalPoints);
            this.Controls.Add(this.txt_valDEcourant);
            this.Controls.Add(this.btn_brasser);
            this.Controls.Add(this.lbl_nomFRM);
            this.Controls.Add(this.txt_DEcourant);
            this.Name = "Frm_DE";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_DE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DEcourant;
        private System.Windows.Forms.Label lbl_nomFRM;
        private System.Windows.Forms.Button btn_brasser;
        private System.Windows.Forms.TextBox txt_valDEcourant;
        private System.Windows.Forms.TextBox txt_toatalPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

