using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskLibrary
{
    public class Muskify
    {
        public static string MaskCreditCard(string creditCardData)
        {
            if (creditCardData.Length < 4)
                return creditCardData;
            var maskLengthLimit = creditCardData.Length - 4;
            var maskedData = default(string);
            var loopController = 0;
            creditCardData.ToList().ForEach(l =>
            {
                if(loopController < maskLengthLimit)
                {
                    creditCardData += "#";
                }
                loopController++;
            });

            return maskedData += creditCardData.Substring(maskLengthLimit, 4);
        }
    }
}
