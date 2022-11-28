using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihm_formulaire_compte
{
    public partial class tableau : Form
    {
       //On le déclare ici pour avoir acces à cette variable dans tous les ss pg
        int[] resultats = new int[6];

        public tableau()
        {
            InitializeComponent();
            Random r = new Random();
            for(int i = 0; i < 6; i++)
            {
                resultats[i] = r.Next(1,4);
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            int nbPoint = 0;
            for (int i = 0; i < 6; i++)
            {
                if (resultats[i] == 3)
                {
                    nbPoint = nbPoint + 1;
                }
                else if(resultats[i] == 1)
                {
                    nbPoint = nbPoint + 3;
                }
               
            }
            lblPoint.Text = nbPoint.ToString();
        }

        private void btnInvaincu_Click(object sender, EventArgs e)
        {
            Boolean defaite = false;
            int i = 0;
            while(defaite==false && i < 6)
            {
                if (resultats[i] == 2)
                {
                    defaite = true;
                }
                else
                {
                    i++;
                }
            }
            if (defaite == false)
            {
                lblInvaincu.Text = "Vous êtes invaincu";
            }
            else
            {
                lblInvaincu.Text = "Vous avez perdu le match numéro " + i ;
            }
        }
    }
}
