using System;
using System.Linq;
namespace AdventOfCode.Day2
{
    public class CorruptionChecksumCalculator
    {
        public int Calculate(string input)
        {
            var lines = input.Split(Environment.NewLine);

            var checksum = lines.Select(x =>
            {
                var values = x.Split("\t").Select(int.Parse).ToList();

                return values.Max() - values.Min();
            }).Sum();

            return checksum;
        }

        public int GetSumOfEvenlyDivisibleValues(string input)
        {
            var lines = input.Split(Environment.NewLine);

            var numbers = lines.Select(x =>
            {
                var values = x.Split("\t").Select(int.Parse).ToList();
                var v = values.Join(values,
                                    _ => "",
                                    _ => "",
                                    (a, b) => new {A = a, B = b,Value = a / b, Remainder = a % b}).ToList();
               return v.Where(xx => xx.Remainder == 0 && xx.Value != 1)
                                    .Select(xx => xx.Value)
                                    .Single();
            }).ToList();
            
            return numbers.Sum();
        }
    }
}