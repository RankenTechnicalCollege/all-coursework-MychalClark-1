﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Letter
    {
        protected string _recipient;
        protected DateTime _sentDate;


        public Letter(string recipient, DateTime sentDate) {
            
            _recipient = recipient;
            _sentDate = sentDate;
        
        }

        public string Recipient { get => _recipient; }

        public DateTime SentDate { get => _sentDate; }

        public virtual double Price { get => .5; }

        public override string ToString()
        {
            return $"{_sentDate.ToString("dMMyyyy")}, {Recipient}, {Price}";
        }
    }
}
