using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3ex5
{
    public class WhichButtonPressed
    {
        public ButtonIdentifier WhichButton(string obj)
        {
            ButtonIdentifier button;
            switch (obj)
            {
                case "-One":
                    button = ButtonIdentifier.DecreementOne;
                    break;
                case "+One":
                    button = ButtonIdentifier.IncreementOne;
                    break;
                case "-Two":
                    button = ButtonIdentifier.DecreementTwo;
                    break;
                case "+Two":
                    button = ButtonIdentifier.IncreementTwo;
                    break;
                case "-Three":
                    button = ButtonIdentifier.DecreementThree;
                    break;
                default:
                    button = ButtonIdentifier.IncreementThree;
                    break;
            }
            return button;
        }
    }
}
