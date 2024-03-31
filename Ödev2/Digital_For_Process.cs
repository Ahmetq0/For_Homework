using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
    internal class Digital_For_Process
    {
        public static void For_Process()
        {
            int width = Width_and_Height_Selected.Widt_Selected();
            int height = Width_and_Height_Selected.Height_Selected();


            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write(height);

                }
                Console.WriteLine();
            }
        }
    }
}

