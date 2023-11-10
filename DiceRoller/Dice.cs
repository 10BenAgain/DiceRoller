
namespace DiceRoller
{

    public class DiceType
    {
        public enum Types : uint
        {
            D20 = 20,
            D12 = 12,
            D10 = 10,
            D100 = 100,
            D8 = 8,
            D6 = 6,
            D4 = 4
        }
    }

    public class Dice
    {
        private DiceType.Types Selection { get; set; }
        private int Rolls { get; set; }
        private int Number { get; set; }
        private int Modifier { get; set; }
        public int RandomNumber { get; private set; }
        private int[] RollResults { get; set; }

        public Dice(DiceType.Types d, int r, int m)
        {
            Selection = d;
            Rolls = r;
            Modifier = m;
            Number = (int)d;
            RollResults = new int[r];
        }
        private int RandomRoll()
        {
            var rand = new Random();
            var value = rand.Next(1, Number);
            RandomNumber = value;
            return RandomNumber;
        }
        public int RollTheDice()
        {
            var sum = 0;
            for (int i = 0; i < Rolls; i++)
            {
                RandomRoll();
                sum += RandomNumber;
                RollResults[i] = RandomNumber;
            }
            return sum + Modifier;
        }
        public string GetAllRollResults()
        {
            string result = "";
            foreach (int i in RollResults)
            {
                result += string.Concat(i.ToString(), " + ");
            }
            if (Modifier == 0)
                return result.Trim().Trim('+');
            else if (Modifier > 0)
                return result.Trim().Trim('+') + $" ( +{Modifier})";
            else
                return result.Trim().Trim('+') + $" ( -{Math.Abs(Modifier)})";
        }

        public string RolledString()
        {
            if (Modifier == 0)
                return $"{Rolls}{Selection}";
            else if (Modifier > 0)
                return $"{Rolls}{Selection} + {Modifier}";
            else
                return $"{Rolls}{Selection} - {Math.Abs(Modifier)}";
        }
    }

}
