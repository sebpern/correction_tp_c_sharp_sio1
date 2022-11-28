namespace ihm_formulaire_compte
{
    partial class tableau
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
            this.btnCalcul = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnInvaincu = new System.Windows.Forms.Button();
            this.lblInvaincu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(133, 30);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(214, 67);
            this.btnCalcul.TabIndex = 0;
            this.btnCalcul.Text = "Calcul point";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(493, 66);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(73, 16);
            this.lblPoint.TabIndex = 1;
            this.lblPoint.Text = "Vos points ";
            // 
            // btnInvaincu
            // 
            this.btnInvaincu.Location = new System.Drawing.Point(141, 164);
            this.btnInvaincu.Name = "btnInvaincu";
            this.btnInvaincu.Size = new System.Drawing.Size(206, 78);
            this.btnInvaincu.TabIndex = 2;
            this.btnInvaincu.Text = "Invaincu";
            this.btnInvaincu.UseVisualStyleBackColor = true;
            this.btnInvaincu.Click += new System.EventHandler(this.btnInvaincu_Click);
            // 
            // lblInvaincu
            // 
            this.lblInvaincu.AutoSize = true;
            this.lblInvaincu.Location = new System.Drawing.Point(478, 195);
            this.lblInvaincu.Name = "lblInvaincu";
            this.lblInvaincu.Size = new System.Drawing.Size(44, 16);
            this.lblInvaincu.TabIndex = 3;
            this.lblInvaincu.Text = "label1";
            // 
            // tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInvaincu);
            this.Controls.Add(this.btnInvaincu);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.btnCalcul);
            this.Name = "tableau";
            this.Text = "tableau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnInvaincu;
        private System.Windows.Forms.Label lblInvaincu;
    }
}