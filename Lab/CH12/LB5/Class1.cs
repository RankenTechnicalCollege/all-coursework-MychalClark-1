using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
   public class Job
    {
        private string _description;
        private float _hoursToComplete;
        private float _hourlyFee;
        private float _totalFee;
        private const double TRIP_FEE = 35;

        public double TRIPFEE() => TRIP_FEE;
        

       public Job(string description, float HoursToComplete, float HourlyFee) {
            _description = description;
            
            _hoursToComplete = HoursToComplete;

            _hourlyFee = HourlyFee;
            
        
        }
        
        public string Description {
            get { return _description; }
            set { _description = value; }
        }
        public float HoursToComplete
        {
            get { return _hoursToComplete; }
            set { _hoursToComplete = value; }
        }
            public float HourlyFee
        {
            get { return _hourlyFee; }
            set { _hourlyFee = value; }
        }
            public double TotalFee
        {
            
            get {
                _totalFee = HoursToComplete * HourlyFee;
                
                return _totalFee; }
        }
        }
    }

    
