using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutReqemlerinCemi
{
    class Program
    {
        static void Main(string[] args)
        {
            //birinci listnendi ikinci arraynan eyni weydi prosta ilk olaraq listnen eledm sora gordumki massiv kimi yazmaliyiq 


            //List<int> regemler = new List<int> { 5, 6, 6, 7, 9, 8, 4, 2 };
            //int count = 0;
            //foreach(int r in regemler)
            //{
            //    if (r % 2 == 0)
            //    {
            //        count = count+ r;
            //    }
            //}
            //Console.WriteLine(count);
            int[] regemler = { 2, 3, 4, 5, 6 };
            int count = 0;
            for (int i = 0; i < regemler.Length; i++)
            {
                if (regemler[i] % 2 == 0)
                {
                    count += regemler[i];
                }
            }
            Console.WriteLine(count);
        }
    }
}
