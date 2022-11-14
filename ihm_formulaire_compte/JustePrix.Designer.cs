namespace ihm_formulaire_compte
{
    partial class JustePrix
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ici le but est de trouver un nombre aléatoire";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(30, 131);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(279, 124);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Demarrer";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(442, 131);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(279, 124);
            this.btn_test.TabIndex = 2;
            this.btn_test.Text = "Proposer";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Visible = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // JustePrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Name = "JustePrix";
            this.Text = "Juste Prix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_test;
    }
}