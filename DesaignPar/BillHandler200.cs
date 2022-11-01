using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaignPar
{
    internal class BillHandler200 : BillHandler
    {
        public override void HandleRequest(int amount)
        {
            while (amount >= 200)
            {
                if(amount == 210||amount == 230)              
                    break;                
                amount -= 200;
                coutner++;             
            }
            if(coutner>0)
            Console.WriteLine("Giving 200 x " + coutner);

            if (next != null)          
                next.HandleRequest(amount);
            
        }
    }
}
