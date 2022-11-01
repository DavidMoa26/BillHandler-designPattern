using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaignPar
{
    public abstract class BillHandler
    {
        protected static int coutner = 0;
        protected BillHandler next;

        public void SetNext(BillHandler next)
        {
            this.next = next;
        }

        public abstract void HandleRequest(int amount);
    }
}
