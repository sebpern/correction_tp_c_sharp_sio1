using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihm_formulaire_compte
{
    public partial class frm_create : Form
    {
        public frm_create()
        {
            InitializeComponent();
        }

        private void btn_creer_Click(object sender, EventArgs e)
        {
            Boolean error = false;

            if (tbx_pseudo.Text == "")
            {
                tbx_pseudo.BackColor = Color.Red;
                lbl_error_pseudo.Visible = true;
                error = true;
            }
            if (tbx_mail.Text == "")
            {
                tbx_mail.BackColor = Color.Red;
                lbl_error_mail.Visible = true;
                error = true;
             

            }
            else
            {
                if (Regex.IsMatch(tbx_mail.Text, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$") == false)
                {
                    tbx_mail.BackColor = Color.Red;
                    lbl_error_mail.Visible = true;
                    error = true;
                }
            }
            if (tbx_password.Text == "" && tbx_password.Text.Length<=4)
            {
                tbx_password.BackColor = Color.Red;
                lbl_error_password.Visible = true;
                error = true;
            }
            if (tbx_confirm.Text != tbx_password.Text)
            {
                tbx_confirm.BackColor = Color.Red;
                lbl_error_confirm.Visible = true;
                error = true;
            }
            if (cbx_data_ok.Checked==false)
            {
                cbx_data_ok.BackColor = Color.Red;
                lbl_error_accord.Visible = true;
                error = true;
            }

            if (!error)
            {
                gbx_saisie.Visible = false;
                gbx_resume.Visible = true;
                lbl_resume.Text = tbx_pseudo.Text + " " + tbx_mail.Text + ", votre compte a été crée !";
            }
        }

        private void tbx_pseudo_Enter(object sender, EventArgs e)
        {
            tbx_pseudo.BackColor = Color.White;
            lbl_error_pseudo.Visible = false;
        }

        private void tbx_mail_Enter(object sender, EventArgs e)
        {
            tbx_mail.BackColor = Color.White;
            lbl_error_mail.Visible = false;
        }

        private void tbx_confirm_Enter(object sender, EventArgs e)
        {
            tbx_confirm.BackColor = Color.White;
            lbl_error_confirm.Visible = false;
        }

        private void tbx_password_Enter(object sender, EventArgs e)
        {
            tbx_password.BackColor = Color.White;
            lbl_error_password.Visible = false;
        }

        private void cbx_data_ok_Click(object sender, EventArgs e)
        {
            cbx_data_ok.BackColor = Color.White;
            lbl_error_accord.Visible = false;
        }

        private void btn_juste_prix_Click(object sender, EventArgs e)
        {
            JustePrix justePrix = new JustePrix();
            justePrix.Show();
        }
    }
}
