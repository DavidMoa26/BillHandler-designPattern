using System;

namespace DesaignPar 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BillHandler bill200 = new BillHandler200();
            BillHandler bill100 = new BillHandler100();
            BillHandler bill50 = new BillHandler50();
            BillHandler bill20 = new BillHandler20();

            bill200.SetNext(bill100);
            bill100.SetNext(bill50);
            bill50.SetNext(bill20);
            bill20.SetNext(null);


        }
    }
}