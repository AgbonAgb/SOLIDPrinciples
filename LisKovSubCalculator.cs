using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public abstract class LisKovSubCalculator
    {
        protected readonly int[] _numbers;
        public LisKovSubCalculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calculate();//abstract deon not have body        
    }
    public class SumCalculator : LisKovSubCalculator
    {
        public SumCalculator(int[] numbers): base(numbers)
        {
        }
        public override int Calculate() => _numbers.Sum();
    }
    public class EvenNumbersSumCalculator : LisKovSubCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
