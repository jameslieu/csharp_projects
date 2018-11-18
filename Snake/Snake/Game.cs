using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Game : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle Food = new Circle();

        public Game()
        {
            InitializeComponent();

            // Set settings to default
            new Settings();

            // Set game timer
            // TODO: Set speed/difficulty in different menu
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;

            // Set settings to default
            new Settings();

            Snake.Clear();
            Circle head = new Circle
            {
                X = 10,
                Y = 5
            };

            Snake.Add(head);

            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
            
        }

        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width/Settings.Width;
            int maxYPos = pbCanvas.Size.Height/Settings.Height;

            Random random = new Random();
            Food = new Circle
            {
                X = random.Next(0, maxXPos),
                Y = random.Next(0, maxYPos)
            };
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                HandleDirection();
                ControlSnake();
            }

            pbCanvas.Invalidate();
        }

        private void HandleDirection()
        {
            if (Input.KeyPressed(Keys.Right) && Settings.Direction != global::Snake.Move.Left)
            {
                Settings.Direction = global::Snake.Move.Right;
            }
            if (Input.KeyPressed(Keys.Left) && Settings.Direction != global::Snake.Move.Right)
            {
                Settings.Direction = global::Snake.Move.Left;
            }
            if (Input.KeyPressed(Keys.Up) && Settings.Direction != global::Snake.Move.Down)
            {
                Settings.Direction = global::Snake.Move.Up;
            }
            if (Input.KeyPressed(Keys.Down) && Settings.Direction != global::Snake.Move.Up)
            {
                Settings.Direction = global::Snake.Move.Down;
            }
        }


        private void ControlSnake()
        {
            for (int i = Snake.Count -1; i >= 0; i--)
            {
                if (i == 0)
                {
                    HandleControls(i);

                    DetectBorderCollision(i);
                    DetectBodyCollision(i);
                    DetectFoodCollision();
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void HandleControls(int i)
        {
            switch (Settings.Direction)
            {
                case global::Snake.Move.Right:
                    Snake[i].X++;
                    break;
                case global::Snake.Move.Left:
                    Snake[i].X--;
                    break;
                case global::Snake.Move.Up:
                    Snake[i].Y--;
                    break;
                case global::Snake.Move.Down:
                    Snake[i].Y++;
                    break;
            }
        }

        private void DetectFoodCollision()
        {
            if (Snake[0].X == Food.X && Snake[0].Y == Food.Y)
            {
                Eat();
            }
        }

        private void DetectBodyCollision(int i)
        {
            for (int j = 1; j < Snake.Count; j++)
            {
                if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                {
                    Die();
                }
            }
        }

        private void DetectBorderCollision(int i)
        {
            int maximumXPosition = pbCanvas.Size.Width / Settings.Width;
            int maximumYPosition = pbCanvas.Size.Height / Settings.Height;
            var collisionDetected = Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maximumXPosition || Snake[i].Y >= maximumYPosition;

            if (collisionDetected)
            {
                Die();
            }
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Eat()
        {
            Circle food = new Circle();
            food.X = Snake[Snake.Count -1].X;
            food.Y = Snake[Snake.Count -1].Y;

            Snake.Add(food);

            Settings.Score += Settings.Points;
            lblScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {

            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                Brush snakeColour;

                for(int i = 0; i < Snake.Count; i++)
                {
                    if(i ==0)
                    {
                        snakeColour = Brushes.Black;
                    }
                    else
                    {
                        snakeColour = Brushes.Green;
                    }

                    // Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(
                            Snake[i].X * Settings.Width,
                            Snake[i].Y * Settings.Height,
                            Settings.Width,
                            Settings.Height
                        )
                    );

                    // Draw food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(
                            Food.X * Settings.Width,
                            Food.Y * Settings.Height,
                            Settings.Width,
                            Settings.Height
                        )
                    );

                }
            }
            else
            {
                string gameOver = "Game over \nYour final score is: " + Settings.Score + "\nPress Enter to try again.";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}
