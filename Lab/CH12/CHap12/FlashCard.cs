using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHap12
{
    public class FlashCard
    {
        private string _term;
            private string _definition;

        public FlashCard(string term, string definition) { _term = term;
            _definition = definition;

                }

        public string GetTerm() => _term;

        public string GetDefinition() => _definition;
    }
}
