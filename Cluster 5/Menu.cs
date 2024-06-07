using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cluster_5
{
    public partial class Menu : Form
    {
        List<Player> scores = new List<Player>();
        public Menu(List<Player> tempScore)
        {
            scores = tempScore;
            InitializeComponent();
            
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            Form Quiz = new Quiz(scores);
            Quiz.Show();
            this.Hide();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Quitting is uncool", "Uncool quitter", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);

            if (res == DialogResult.OK) 
            {
                Application.Exit();
            
            }
        }

    }
}
