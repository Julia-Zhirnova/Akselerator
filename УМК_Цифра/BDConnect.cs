using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УМК_Цифра
{
    class BDConnect
    {
        public static Models.YMK_ZhifraEntities modelOdb = new Models.YMK_ZhifraEntities();
        public static Models.Students CurrentStudents = null;
    }
}
