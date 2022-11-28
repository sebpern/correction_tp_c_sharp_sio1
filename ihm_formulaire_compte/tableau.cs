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
    }
}
