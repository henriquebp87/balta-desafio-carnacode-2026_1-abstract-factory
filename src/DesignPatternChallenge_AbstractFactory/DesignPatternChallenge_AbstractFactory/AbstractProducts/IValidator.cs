using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge_AbstractFactory.AbstractProducts
{
    internal interface IValidator
    {
        bool ValidateCard(string cardNumber);
    }
}
