namespace ihm_formulaire_compte
{
    partial class frm_create
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
            this.lbl_pseudo = new System.Windows.Forms.Label();
            this.tbx_pseudo = new System.Windows.Forms.TextBox();
            this.tbx_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_confirm = new System.Windows.Forms.TextBox();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.cbx_data_ok = new System.Windows.Forms.CheckBox();
            this.lbl_error_pseudo = new System.Windows.Forms.Label();
            this.lbl_error_mail = new System.Windows.Forms.Label();
            this.lbl_error_confirm = new System.Windows.Forms.Label();
            this.lbl_error_password = new System.Windows.Forms.Label();
            this.btn_creer = new System.Windows.Forms.Button();
            this.gbx_saisie = new System.Windows.Forms.GroupBox();
            this.lbl_error_accord = new System.Windows.Forms.Label();
            this.lbl_resume = new System.Windows.Forms.Label();
            this.gbx_resume = new System.Windows.Forms.GroupBox();
            this.btn_juste_prix = new System.Windows.Forms.Button();
            this.gbx_saisie.SuspendLayout();
            this.gbx_resume.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pseudo
            // 
            this.lbl_pseudo.AutoSize = true;
            this.lbl_pseudo.Location = new System.Drawing.Point(13, 42);
            this.lbl_pseudo.Name = "lbl_pseudo";
            this.lbl_pseudo.Size = new System.Drawing.Size(54, 16);
            this.lbl_pseudo.TabIndex = 0;
            this.lbl_pseudo.Text = "Pseudo";
            // 
            // tbx_pseudo
            // 
            this.tbx_pseudo.Location = new System.Drawing.Point(122, 36);
            this.tbx_pseudo.Name = "tbx_pseudo";
            this.tbx_pseudo.Size = new System.Drawing.Size(203, 22);
            this.tbx_pseudo.TabIndex = 1;
            this.tbx_pseudo.Enter += new System.EventHandler(this.tbx_pseudo_Enter);
            // 
            // tbx_mail
            // 
            this.tbx_mail.Location = new System.Drawing.Point(122, 82);
            this.tbx_mail.Name = "tbx_mail";
            this.tbx_mail.Size = new System.Drawing.Size(203, 22);
            this.tbx_mail.TabIndex = 3;
            this.tbx_mail.Enter += new System.EventHandler(this.tbx_mail_Enter);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(13, 85);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(32, 16);
            this.lbl_mail.TabIndex = 2;
            this.lbl_mail.Text = "Mail";
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(122, 127);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = 'o';
            this.tbx_password.Size = new System.Drawing.Size(203, 22);
            this.tbx_password.TabIndex = 5;
            this.tbx_password.Enter += new System.EventHandler(this.tbx_password_Enter);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(13, 130);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(89, 16);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Mot de passe";
            // 
            // tbx_confirm
            // 
            this.tbx_confirm.Location = new System.Drawing.Point(122, 171);
            this.tbx_confirm.Name = "tbx_confirm";
            this.tbx_confirm.PasswordChar = 'o';
            this.tbx_confirm.Size = new System.Drawing.Size(203, 22);
            this.tbx_confirm.TabIndex = 7;
            this.tbx_confirm.Enter += new System.EventHandler(this.tbx_confirm_Enter);
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Location = new System.Drawing.Point(13, 174);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(81, 16);
            this.lbl_confirm.TabIndex = 6;
            this.lbl_confirm.Text = "Confirmation";
            // 
            // cbx_data_ok
            // 
            this.cbx_data_ok.AutoSize = true;
            this.cbx_data_ok.Location = new System.Drawing.Point(38, 216);
            this.cbx_data_ok.Name = "cbx_data_ok";
            this.cbx_data_ok.Size = new System.Drawing.Size(187, 20);
            this.cbx_data_ok.TabIndex = 8;
            this.cbx_data_ok.Text = "Accord stockage données";
            this.cbx_data_ok.UseVisualStyleBackColor = true;
            this.cbx_data_ok.Click += new System.EventHandler(this.cbx_data_ok_Click);
            // 
            // lbl_error_pseudo
            // 
            this.lbl_error_pseudo.AutoSize = true;
            this.lbl_error_pseudo.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_pseudo.Location = new System.Drawing.Point(349, 44);
            this.lbl_error_pseudo.Name = "lbl_error_pseudo";
            this.lbl_error_pseudo.Size = new System.Drawing.Size(120, 16);
            this.lbl_error_pseudo.TabIndex = 9;
            this.lbl_error_pseudo.Text = "pseudo obligatoire";
            // 
            // lbl_error_mail
            // 
            this.lbl_error_mail.AutoSize = true;
            this.lbl_error_mail.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_mail.Location = new System.Drawing.Point(349, 88);
            this.lbl_error_mail.Name = "lbl_error_mail";
            this.lbl_error_mail.Size = new System.Drawing.Size(153, 16);
            this.lbl_error_mail.TabIndex = 10;
            this.lbl_error_mail.Text = "mail obligatoire et valide";
            this.lbl_error_mail.Visible = false;
            // 
            // lbl_error_confirm
            // 
            this.lbl_error_confirm.AutoSize = true;
            this.lbl_error_confirm.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_confirm.Location = new System.Drawing.Point(351, 177);
            this.lbl_error_confirm.Name = "lbl_error_confirm";
            this.lbl_error_confirm.Size = new System.Drawing.Size(240, 16);
            this.lbl_error_confirm.TabIndex = 11;
            this.lbl_error_confirm.Text = "confirmation différente du mot de passe";
            this.lbl_error_confirm.Visible = false;
            // 
            // lbl_error_password
            // 
            this.lbl_error_password.AutoSize = true;
            this.lbl_error_password.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_password.Location = new System.Drawing.Point(349, 133);
            this.lbl_error_password.Name = "lbl_error_password";
            this.lbl_error_password.Size = new System.Drawing.Size(156, 16);
            this.lbl_error_password.TabIndex = 12;
            this.lbl_error_password.Text = "mot de passe obligatoire";
            this.lbl_error_password.Visible = false;
            // 
            // btn_creer
            // 
            this.btn_creer.Location = new System.Drawing.Point(122, 282);
            this.btn_creer.Name = "btn_creer";
            this.btn_creer.Size = new System.Drawing.Size(119, 40);
            this.btn_creer.TabIndex = 13;
            this.btn_creer.Text = "Créer";
            this.btn_creer.UseVisualStyleBackColor = true;
            this.btn_creer.Click += new System.EventHandler(this.btn_creer_Click);
            // 
            // gbx_saisie
            // 
            this.gbx_saisie.Controls.Add(this.lbl_error_accord);
            this.gbx_saisie.Controls.Add(this.lbl_error_pseudo);
            this.gbx_saisie.Controls.Add(this.btn_creer);
            this.gbx_saisie.Controls.Add(this.lbl_pseudo);
            this.gbx_saisie.Controls.Add(this.lbl_error_password);
            this.gbx_saisie.Controls.Add(this.tbx_pseudo);
            this.gbx_saisie.Controls.Add(this.lbl_error_confirm);
            this.gbx_saisie.Controls.Add(this.lbl_mail);
            this.gbx_saisie.Controls.Add(this.lbl_error_mail);
            this.gbx_saisie.Controls.Add(this.tbx_mail);
            this.gbx_saisie.Controls.Add(this.lbl_password);
            this.gbx_saisie.Controls.Add(this.cbx_data_ok);
            this.gbx_saisie.Controls.Add(this.tbx_password);
            this.gbx_saisie.Controls.Add(this.tbx_confirm);
            this.gbx_saisie.Controls.Add(this.lbl_confirm);
            this.gbx_saisie.Location = new System.Drawing.Point(73, 24);
            this.gbx_saisie.Name = "gbx_saisie";
            this.gbx_saisie.Size = new System.Drawing.Size(639, 340);
            this.gbx_saisie.TabIndex = 14;
            this.gbx_saisie.TabStop = false;
            this.gbx_saisie.Text = "Formulaire de création";
            // 
            // lbl_error_accord
            // 
            this.lbl_error_accord.AutoSize = true;
            this.lbl_error_accord.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_accord.Location = new System.Drawing.Point(351, 217);
            this.lbl_error_accord.Name = "lbl_error_accord";
            this.lbl_error_accord.Size = new System.Drawing.Size(116, 16);
            this.lbl_error_accord.TabIndex = 14;
            this.lbl_error_accord.Text = "accord obligatoire";
            this.lbl_error_accord.Visible = false;
            // 
            // lbl_resume
            // 
            this.lbl_resume.AutoSize = true;
            this.lbl_resume.Location = new System.Drawing.Point(7, 42);
            this.lbl_resume.Name = "lbl_resume";
            this.lbl_resume.Size = new System.Drawing.Size(0, 16);
            this.lbl_resume.TabIndex = 15;
            // 
            // gbx_resume
            // 
            this.gbx_resume.Controls.Add(this.btn_juste_prix);
            this.gbx_resume.Controls.Add(this.lbl_resume);
            this.gbx_resume.Location = new System.Drawing.Point(73, 109);
            this.gbx_resume.Name = "gbx_resume";
            this.gbx_resume.Size = new System.Drawing.Size(330, 204);
            this.gbx_resume.TabIndex = 16;
            this.gbx_resume.TabStop = false;
            this.gbx_resume.Text = "Résumé";
            this.gbx_resume.Visible = false;
            // 
            // btn_juste_prix
            // 
            this.btn_juste_prix.Location = new System.Drawing.Point(34, 134);
            this.btn_juste_prix.Name = "btn_juste_prix";
            this.btn_juste_prix.Size = new System.Drawing.Size(104, 43);
            this.btn_juste_prix.TabIndex = 16;
            this.btn_juste_prix.Text = "Juste Prix";
            this.btn_juste_prix.UseVisualStyleBackColor = true;
            this.btn_juste_prix.Click += new System.EventHandler(this.btn_juste_prix_Click);
            // 
            // frm_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_resume);
            this.Controls.Add(this.gbx_saisie);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_create";
            this.Text = "Création de compte";
            this.gbx_saisie.ResumeLayout(false);
            this.gbx_saisie.PerformLayout();
            this.gbx_resume.ResumeLayout(false);
            this.gbx_resume.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_pseudo;
        private System.Windows.Forms.TextBox tbx_pseudo;
        private System.Windows.Forms.TextBox tbx_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_confirm;
        private System.Windows.Forms.Label lbl_confirm;
        private System.Windows.Forms.CheckBox cbx_data_ok;
        private System.Windows.Forms.Label lbl_error_pseudo;
        private System.Windows.Forms.Label lbl_error_mail;
        private System.Windows.Forms.Label lbl_error_confirm;
        private System.Windows.Forms.Label lbl_error_password;
        private System.Windows.Forms.Button btn_creer;
        private System.Windows.Forms.GroupBox gbx_saisie;
        private System.Windows.Forms.Label lbl_error_accord;
        private System.Windows.Forms.GroupBox gbx_resume;
        private System.Windows.Forms.Label lbl_resume;
        private System.Windows.Forms.Button btn_juste_prix;
    }
}

