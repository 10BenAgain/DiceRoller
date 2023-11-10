using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Roller : Form
    {
        public Roller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }
        private void SetDefaults()
        {
            DiceTypeSelection.SelectedIndex = 0;
            Rolls.Value = 1;
            ModifierBox.Value = 0;
        }

        private DiceType.Types SelectedDie(int index)
        {
            return index switch
            {
                0 => DiceType.Types.D20,
                1 => DiceType.Types.D12,
                2 => DiceType.Types.D10,
                3 => DiceType.Types.D100,
                4 => DiceType.Types.D8,
                5 => DiceType.Types.D6,
                6 => DiceType.Types.D4,
                _ => DiceType.Types.D20,
            };
        }

        private void CalculateRoll_Click(object sender, EventArgs e)
        {
            var selectedDice = new Dice(SelectedDie(DiceTypeSelection.SelectedIndex), (int)Rolls.Value, (int)ModifierBox.Value);
            RollCalcTextBox.Text = selectedDice.RolledString();
            TotalRollBox.Text = selectedDice.RollTheDice().ToString();

            ArrayResultsBox.Text = selectedDice.GetAllRollResults();
        }
    }
}
