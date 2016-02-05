using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertChart
{
    public class Revert
    {
        static void Main(string[] args)
        {
            StringBuilder cad = new StringBuilder("345*rt/ty5*");
            //var tmp = RevertString(cad);
            Console.WriteLine("Cadena " +  cad);
           // Console.WriteLine("Resultado " + tmp);
            Console.ReadKey();

        }

        public StringBuilder RevertString(StringBuilder v)
        {
            int insPoss = 0;
            char[] chart = new char[] { '(', ')', '/', '*' };

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < v.Length; i++)
            {
                if (!chart.Contains(v[i]))
                    result.Insert(insPoss, v[i]);
                else
                {
                    result.Append(v[i]);
                    insPoss = i + 1;
                }
            }
            return result;
        }
    }
}
