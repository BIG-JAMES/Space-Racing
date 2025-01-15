using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Racing
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(130, 300, 40, 40);
        Rectangle player2 = new Rectangle(430, 300, 40, 40);
        Rectangle midline = new Rectangle(300, 0, 2, 802);


        List<Rectangle> ball = new List<Rectangle>();
        List<int> ballspeed = new List<int>();

        int ballSize = 10;



        SolidBrush WhiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        int player1Speed = 5;
        int player2Speed = 5;

        int player1Score = 0;
        int player2Score = 0;

        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;

        Random Randomgener = new Random();
        int ranValue = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;


                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
               

                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
            }
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {

            //players size & sprites
            player1sp.Location = player1.Location;
            player1.Size = player1sp.Size;

            player2sp.Location = player2.Location;
            player2.Size = player2sp.Size;

            //Move player 1
            if (wPressed == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sPressed == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }

            //Move player 2
            if (upPressed == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downPressed == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            int ranValue = Randomgener.Next(0, 90);

            if (ranValue < 40)
            {
                int size = Randomgener.Next(5, 10);
                int Y = Randomgener.Next(23, this.Width);
                Rectangle newBall = new Rectangle(0, Y, ballSize, ballSize);
                ball.Add(newBall);
                ballspeed.Add(Randomgener.Next(4, 16));
            }

            for (int i = 0; i < ball.Count; i++)
            {
                int x = ball[i].X + ballspeed[i];
                ball[i] = new Rectangle(x, ball[i].Y, ball[i].Width, ball[i].Height);
            }

            //bottom wall
            if (player1.Y > 300)
            {
                player1.Y = 299;
            }
            if (player2.Y > 300)
            {
                player2.Y = 299;
            }

            if (player1Score == 5)
            {

            }

            if (player2Score == 5)
            {

            }

            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //drawing 
            e.Graphics.FillRectangle(blackBrush, player1);
            e.Graphics.FillRectangle(blackBrush, player2);
            e.Graphics.FillRectangle(WhiteBrush, midline);

            //draw astroid 
            for (int i = 0; i < ball.Count; i++)
            {
                e.Graphics.FillRectangle(WhiteBrush, ball[i]);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
