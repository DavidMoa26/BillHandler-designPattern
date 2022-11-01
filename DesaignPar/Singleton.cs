using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesaignPar
{
    internal class Singleton
    {
        private static Singleton instance;
        private static readonly object key = new object();

        public static Singleton GetInstance()
        {
            lock (key)
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

      









    }
}
