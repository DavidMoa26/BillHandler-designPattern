using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaignPar
{
    internal class BillHandler50 : BillHandler
    {
        public override void HandleRequest(int amount)
        {
            coutner = 0;
            while (amount >= 50)
            {
                if (amount == 60 || amount == 80)
                    break;              
                amount -= 50;
                coutner++;
            }
            if (coutner > 0)
                Console.WriteLine("Giving 50 x " + coutner);
            if (next != null)
                next.HandleRequest(amount);
        }
    }
}
