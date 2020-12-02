namespace BowlingGameTask
{
    public class BowlingGame
    {
        private int[] rolls = new int[21];
        public string[] Frames { get; set; }
        int currentRoll = 0;
        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        private bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        public string OutputString(string[] frames)
        {
            return string.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|",
                  frames[0], frames[1], frames[2], frames[3], frames[4], frames[5], frames[6], frames[7], frames[8], frames[9]);
        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public void Roll(int[] pins)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                rolls[currentRoll++] = pins[i];
            }
        }

        public int Score()
        {
            int score = 0;
            int rollNumber = 0;
            Frames = new string[10];
            for (int i = 0; i < 10; i++)
            {
                if (isStrike(rollNumber))
                {
                    score += 10 + rolls[rollNumber + 1] + rolls[rollNumber + 2];
                    if (i == 9)
                    {
                        Frames[i] = string.Format("X, {0}, {1}", rolls[rollNumber + 1], rolls[rollNumber + 2]);
                    }
                    else
                    {
                        Frames[i] = "X   ";
                    }

                    rollNumber++;
                }
                else if (isSpare(rollNumber))
                {
                    score += 10 + rolls[rollNumber + 2];
                    Frames[i] = rolls[rollNumber].ToString() + ", /";
                    if (i == 9)
                        Frames[i] += string.Format(", {0}", rolls[rollNumber + 2]);
                    rollNumber += 2;
                }
                else
                {
                    score += rolls[rollNumber] + rolls[rollNumber + 1];
                    Frames[i] = rolls[rollNumber].ToString() + ", " + rolls[rollNumber + 1].ToString();
                    if (i == 9)
                        Frames[i] += "   ";
                    rollNumber += 2;
                }
            }
            return score;
        }
    }
}
