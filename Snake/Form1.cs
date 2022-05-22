using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form

    {
        private List<Point> Wall = new List<Point>();
        private List<Point> Snake = new List<Point>();
        private Point food = new Point();
        private SRectangle rec = new SRectangle();
        private Circle Bonus = new Circle();
        int maxWidht;
        int maxHeight;
        int score;
        int hightScore;
        Random rand = new Random();
        bool goLeft, goRight, goDown, goUp;

        public Form1()
        {
            InitializeComponent();
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left )
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right )
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up )
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down )
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            ReastartGame();

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Directions();
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0) // the head of the snake 
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    // The end of the game boarder 
                    if (Snake[i].X < 0)  
                    {
                        Snake[i].X = maxWidht;
                    }
                    if (Snake[i].X > maxWidht)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    // Check if the head of the snake and and the food in the same position 
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    if (Snake[i].X == Bonus.X && Snake[i].Y == Bonus.Y)
                    {
                        EatBonus();
                    }

                    // check if the head hit the body 
                    for (int j = 1; j < Snake.Count; j++) // j=0 is the head
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }


                    }
                    bool check_1 = WallAndSnake(Snake[i].X , Snake[i].Y);
                    bool check_2 = RecAndSnake(Snake[i].X, Snake[i].Y);
                    if (check_1 == true || check_2 == true)
                    {
                        GameOver();
                    }

                }
                else // countinue the snake
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            PicGame.Invalidate(); // draw the game 

        }
        private bool WallAndSnake(int Xpoint , int Ypoint)
        {
            for (int w = 0; w < Wall.Count; w++)
            {

                if (Xpoint == Wall[w].X && Ypoint == Wall[w].Y)
                {
                    return true;

                }

            }
            return false;
        }

        private bool RecAndSnake(int Xpoint, int Ypoint)
        {
            for (int t = 0; t < rec.Rows1; t++)
            {
                for (int r = 0; r < rec.Cols1; r++)
                {
                    if (Xpoint == rec.X + t && Ypoint == rec.Y + r)
                    {
                        return true;

                    }


                }

            }
            return false;
        }

        private void UpdatePictureBoxGrafics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            
            Brush SnakeColor;
            Brush WallColor;
            //Brush RecColor;
            
            rec.Draw(canvas);
            Bonus.DrawCircle(canvas);
            for (int i = 0; i < Snake.Count; i++)
            {

                if (i == 0)
                {
                    SnakeColor = Brushes.Black;

                }
                else
                {
                    SnakeColor = Brushes.Green;
                }

                canvas.FillEllipse(SnakeColor, new Rectangle(
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height));
            }

            /*
            RecColor = Brushes.AliceBlue;
            for (int i = 0; i < rec.Rows1; i++)
            {
                for (int j = 0; j < rec.Cols1; j++)
                {
                   canvas.FillEllipse(RecColor, new Rectangle(
                   (rec.X+i) * Settings.Width,
                   (rec.Y+ j) * Settings.Height,
                   Settings.Width, Settings.Height));
                }
            }
            */


            for (int i = 0; i < Wall.Count; i++)
            {
                Image fence = Image.FromFile(@"C:\Users\yoavl\source\repos\Snake\Snake\ff.png");
                PointF pp = new PointF(Wall[i].X * Settings.Width,
                Wall[i].Y * Settings.Height);
                canvas.DrawImage(fence, pp);

                /*
                canvas.FillEllipse(WallColor, new Rectangle(
                Wall[i].X * Settings.Width,
                Wall[i].Y * Settings.Height,
                Settings.Width, Settings.Height));
                */
            }




            Image Burger = Image.FromFile(@"C:\Users\yoavl\source\repos\Snake\Snake\Burger.png");
            PointF BugerP = new PointF(food.X * Settings.Width,
            food.Y * Settings.Height);
            canvas.DrawImage(Burger, BugerP);

            //canvas.FillEllipse(Brushes.Red, new Rectangle(
            //food.X * Settings.Width,
            //food.Y * Settings.Height,
            //Settings.Width, Settings.Height));

        }

        private void ReastartGame()
        {
            maxWidht = PicGame.Width / Settings.Width - 1;
            maxHeight = PicGame.Height / Settings.Width - 1;

            Snake.Clear();
            Wall.Clear();
            rec = null;

            StartB.Enabled = false;


            score = 0;
            ScoreL.Text = "Score: " + score;
            Point head = new Point { X = 10, Y = 5 }; // placing the snake in the middel;
            Snake.Add(head); // adding the head of the snake in the start of the list;

            for (int i=0; i< 10; i++) // inishalize the size of the body of the snake 
            {
                Point body = new Point();
                Snake.Add(body);
            }
            // create new food point 
            CreateWall();
            CreateSRectangle();
            CreateFood();


            GameTimer.Start();
       

        }
        // Ensures that the food dot will not be on a obstacle
        private void CreateFood()
        {
            int x = rand.Next(2, maxWidht);
            int y = rand.Next(2, maxHeight);

            while (RecAndSnake(x,y) != false || WallAndSnake(x,y) != false)
            {
                x = rand.Next(2, maxWidht);
                y = rand.Next(2, maxHeight);
            }

            food = new Point { X = x, Y = y };
            

        }
        private void CreateSRectangle()
        {
            rec = new SRectangle { X = rand.Next(2, maxWidht), Y = rand.Next(2, maxHeight), Rows1 = 3, Cols1 = 3 } ;
    
        }


        // Create new Wall
        private void CreateWall()
        {
            Point first_brick = new Point { X = rand.Next(2, maxWidht), Y = rand.Next(2, maxHeight) };
            Wall.Add(first_brick);
            int j = 1;
            for (int i = 1; i < 4; i++, j++)
            {
                Point brick = new Point { X = first_brick.X + j, Y = first_brick.Y };
                Wall.Add(brick);
            }

        }
        private void EatFood()
        {
            score += 1;
            ScoreL.Text = "Score: " + score;
            Point body = new Point();
            Snake.Add(body);

            food = new Point { X = rand.Next(2, maxWidht), Y = rand.Next(2, maxHeight) };
            if (score % 2 == 0)
            {
                CreateWall();
                CreateBonus();
            }
            if (score % 2 == 0)
            {
                rec.X = rand.Next(2, maxWidht);
                rec.Y = rand.Next(2, maxHeight);
                rec.Cols1++;
                rec.Rows1++;
                
            }
  

        }
        private void EatBonus()
        {
            if (Wall.Count > 7)
                Wall.RemoveRange(0, 7);

            rec.Cols1--;
            rec.Rows1--;


            Bonus.X = 500;
            Bonus.Y = 500;
      

        }

        private void CreateBonus()
        {
            int x = rand.Next(2, maxWidht);
            int y = rand.Next(2, maxHeight);

            while (RecAndSnake(x, y) != false || WallAndSnake(x, y) != false)
            {
                x = rand.Next(2, maxWidht);
                y = rand.Next(2, maxHeight);
            }
            Bonus = new Circle(rand.Next(2, maxWidht), rand.Next(2, maxHeight),1); // defalut radius = 2 

        }
        private void GameOver()
        {
            GameTimer.Stop();
            StartB.Enabled = true;
            if (score > hightScore)
            {
                hightScore = score;
                HighScroeL.Text = "Score: " + hightScore;


            }

        }
        private void Directions()
        {
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
        }

    }
}
