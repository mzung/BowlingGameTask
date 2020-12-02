namespace BowlingGameTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = string.Empty;
            if (args.Length > 0)
            {

                file = args[0];
            }

            var rolls = Reader.GetPins(Reader.ReadFile(file));

            BowlingGame game = new BowlingGame();
            game.Roll(rolls.ToArray());

            var score = game.Score();
            var line1 = "| f1 | f2 | f3 | f4 | f5 | f6 | f7 | f8 | f9 | f10   |";
            var line2 = game.OutputString(game.Frames);

            System.Console.WriteLine(line1);
            System.Console.WriteLine(line2.Replace('0', '-'));
            System.Console.WriteLine("score: " + score);
        }
    }
}
