

namespace NumberDifferenceCalculatorConsoleApp.Models
{
    public class NumberModel
    {
        private int number;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 5)
                {
                    number = value;
                }
            }
        }
    }
}
