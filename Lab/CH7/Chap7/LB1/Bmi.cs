using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{public enum WeightCategory { 
        NORMAL = 0,
        UNDERWEIGHT = 1, 
        OVERWEIGHT = 2, 
        OBESE = 3 }
    
    public class Bmi
    {
        private float _weightInPounds;
        private float _heightInInches;
        private float _bmi;
        private WeightCategory _weightCategory;

        public Bmi(float weightInPounds, float heightInInches, float bmi, WeightCategory weightCategory) {
            _weightInPounds = weightInPounds; _heightInInches = heightInInches; _bmi = bmi; _weightCategory = weightCategory;
        }

        public float WeightInPounds { get { return _weightInPounds; } }
        public float HeightInInches { get { return _heightInInches; } }
        public float BMI { get { return _bmi; } }
        public WeightCategory Weightcategory { get { return _weightCategory; } }

    }
}
