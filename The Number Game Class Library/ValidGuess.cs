using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Number_Game_Class_Library
{
    public class ValidGuess
    {
        private float _guess;
        private string _color;

        public float Guess
        {
            get
            {
                return _guess;
            }
            set
            {
                if(value > 0 && value < 2001)
                {
                    _guess = value;
                }
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if(value == "You got it"  || value == "Too Low" || value == "Too High")
                {
                    _color = value;
                }
            }
        }
        
    }
}
