using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaignPar
{
    internal class BillHandler100 : BillHandler
    {
        public override void HandleRequest(int amount)
        {
            coutner = 0;
            while (amount >= 100)
            {
                if (amount == 110 || amount == 130)
                    break;
                amount -= 100;
                coutner++;
            }
            if (coutner > 0)
                Console.WriteLine("Giving 100 x " + coutner);         
                if (next != null)                
                    next.HandleRequest(amount);
                
            
        }
    }
}
