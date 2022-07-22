using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2d_Formula_Game_Project
{
    
    public partial class Form1 : Form
    {
        int line1y, line2y, line3y,lineX,coinx,coiny,coin_speed = 5;
        int line_speed = 20,car_speed=8,score=0;
        
        int player2x, player2y,turnValue=25;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && player1.Location.X<=350)
            {
                player1.Left+= turnValue;
             
           
            }
         
            if (e.KeyCode == Keys.Left && player1.Location.X >= 35)
            {
                player1.Left -= turnValue ;

            }
        }

        Random random = new Random();
        Image[] images = 
        {
            Properties.Resources.boom,
            Properties.Resources.black,
            Properties.Resources.white,
            Properties.Resources.blue,

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Start();
           
          
        }
        void Start()
        {
            score = 0;
            player1.Image = images[random.Next(1, 4)];
            player2.Image = images[random.Next(1, 4)];

            timer1.Enabled = true;
            timer1.Interval = 5;
            line1y = line1.Location.Y;
            line2y = line2.Location.Y;
            line3y = line3.Location.Y;
            lineX = line1.Location.X;


            player2y = random.Next(-3000, -100);
            player2x = random.Next(25, 370);
            player2.Location = new Point(player2x, player2y);
            lblScore.Text = "Score: " + score;

            coinx = random.Next(30, 560);
            coiny = random.Next(115, 540);
            coins.Location = new Point(coinx, coiny);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            line1y+=line_speed;
            line2y+= line_speed;
            line3y+= line_speed;
            line1.Location = new Point(lineX,line1y);
            line2.Location = new Point(lineX, line2y);
            line3.Location = new Point(lineX, line3y);

            if (line3y>=600)
            {
                line3y=-150;

            }
            if (line2y >= 600)
            {
                line2y = -150;

            }
            if (line1y >= 600)
            {
                line1y = -150;

            }

            player2y += car_speed; 
            player2.Location = new Point(player2x, player2y);
            coiny += coin_speed;
            coins.Location=new Point(coinx, coiny);

            if (coiny>540)
            {
                coiny = random.Next(-500, -215);
                coinx = random.Next(25, 370);
                
            }

            if (player2y > 670)
            {
                player2y = random.Next(-500, -215);
                player2x = random.Next(25, 370);
                player2.Image = images[random.Next(1,4)];
                 car_speed = random.Next(2, 10);
                
               

            }

            if (player1.Bounds.IntersectsWith(player2.Bounds))
            {  
                player1.Image = images[0];
                player2.Image = images[0];
                timer1.Enabled = false;
                string text1 = "Game Over \n" + lblScore.Text;
                DialogResult dialog = MessageBox.Show(text1, "Game Over",MessageBoxButtons.RetryCancel);
                if (dialog == DialogResult.Retry)
                {
                    Start();
                }
                if (dialog == DialogResult.Cancel)
                {
                    Application.Exit();
                }



            }
            if (player1.Bounds.IntersectsWith(coins.Bounds) )
            {
                score++;
                coiny = random.Next(-500, -215);
                coinx = random.Next(25, 370);
                lblScore.Text = "Score: " + score;
            }
       

        }
    }
}
