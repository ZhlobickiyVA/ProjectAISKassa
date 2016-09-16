using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibARM_Buhgalter
{
    public class clARM_Buhgalter
    {
        public static void Run_ARM(string id)
        {
            ARMBuh2v buh = new ARMBuh2v(id);
            buh.Show();
        }


    }
}
