
namespace Math
{
    public class Count
    {
        public int SumOfNumbers(int from, int to)
        {
            if (to == from)
                return to;

            return to + SumOfNumbers(from, to - 1);

        }
    }
}
