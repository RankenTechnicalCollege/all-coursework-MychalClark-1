using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class TestStatistics
    {
        private int _count;
        private float _sum;
        private float _avg;
        private float _min = 1000;
        private float _max;

        public TestStatistics() { }

        public void Addscore(float score)
        {
            _count++;
            _sum += score;
            _avg = _sum / _count;

            if (score < _min) { _min = score; }

            if (score > _max) { _max = score; }

            
                
           

        }

        public int Count { get => _count; }
        public float Sum { get => _sum; }
        public float Average { get => _avg; }
        public float Min { get => _min; }
        public float Max { get => _max; }
    }
}
