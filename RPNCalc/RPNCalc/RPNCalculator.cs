namespace RPNCalc
{
    internal class RPNCalculator
    {
        public int calculate(string expr)
        {
            string[] inputval = expr.Split(',');

            return int.Parse(inputval[0])+int.Parse(inputval[1]);

        }
    }
}