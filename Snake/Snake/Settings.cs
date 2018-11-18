namespace Snake
{
    public enum Move
    {
        Up,
        Down,
        Left,
        Right
    };

    class Settings
    {
        public static Move Direction { get; set; }
        public static bool GameOver { get; set; }

        public static int Points { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }

        public static int Height { get; set; }
        public static int Width { get; set; }

        public Settings()
        {
            Direction = Move.Down;
            GameOver = false;

            Points = 100;
            Speed = 16;
            Score = 0;

            Height = 16;
            Width = 16;
        }
    }
}
