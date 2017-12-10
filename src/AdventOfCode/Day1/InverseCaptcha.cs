using System.IO;
using System.Linq;

namespace AdventOfCode.Day1
{
    public class InverseCaptcha
    {
        public int Solve1(TextReader reader)
        {
            var sum = 0;
            
            var first = reader.Read();
            var current = first;
            int next;

            int CalculateValue(int a, int b)
            {
                return a == b ? (int) char.GetNumericValue((char) a) : 0;
            }

            while ((next = reader.Read()) != -1)
            {
                sum += CalculateValue(current, next);

                current = next;
            }

            sum += CalculateValue(current, first);
            
            return sum;
        }

        public int Solve2(string input)
        {
            int CalculateValue(char a, char b)
            {
                return a == b ? (int)char.GetNumericValue(a) : 0;
            }

            var sum = input.Select((c, i) => (c, input[(i + input.Length / 2) % input.Length]))
                .Sum(x => CalculateValue(x.Item1, x.Item2));

            return sum;
        }
    }
}
