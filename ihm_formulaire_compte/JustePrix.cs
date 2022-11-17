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
    public partial class JustePrix : Form
    {
        //On déclare le nombre à trouver ici
        //Pour qu'il soit accessible dans tous les sous programmes
        int nombre;
        public JustePrix()
        {
            InitializeComponent();
         }


        private void btn_start_Click(object sender, EventArgs e)
        {
        
            nombre =15;
            btn_test.Visible=true;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nombre.ToString());
        }
    }
}
