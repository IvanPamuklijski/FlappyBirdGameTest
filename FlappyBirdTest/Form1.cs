using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdTest
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

           
        public Form1() 
        {
          
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void gametimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            if (pipeBottom.Left  < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < - 160)
            {
                pipeTop.Left = 900;
                
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || 
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top <=0)
            {  
                EndGame();
            }
            if (score > 10)
            {
                pipeSpeed = 9;
            }
            
        }

        private void gamekeyisdownd(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -6;
               
            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 6;
               
            }
        }
        private void EndGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!";
        }
        private void NewGame()
        {
           
        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {

        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }
    }
}
