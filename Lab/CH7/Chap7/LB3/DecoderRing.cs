using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class DecoderRing
    {
        private int _shift;
        private string _innerRing;
        private string _outerRing;

        public DecoderRing() { _innerRing = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; }
        public string Decode(string text) {
            text = text.ToUpper();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    for (int j = 0; j < _innerRing.Length; j++)
                    {
                        if (text[i] == _innerRing[j])
                        {
                             sb.Append(_innerRing[(j - _shift) % 26])
                            ; break; }

                    }
                }
                else if (char.IsWhiteSpace(text[i])) { sb.Append(" "); }
                else
                {
                    throw new InvalidCharacterException();
                }
            }
            return sb.ToString();
        }
        public string Encode(string text) {

            text = text.ToUpper();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    for (int j = 0; j < _innerRing.Length; j++)
                    {if(text[i]== _innerRing[j]) { sb.Append(_innerRing[(j + _shift)% 26]); break; }

                    } }
                else if (char.IsWhiteSpace(text[i])) { sb.Append(" "); }
                else
                {
                    throw new InvalidCharacterException();
                }
            }
            return sb.ToString();
        }

        public int Shift { get => _shift;
            set => _shift = value;
        }
    }
}
