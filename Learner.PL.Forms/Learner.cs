using Leaner.BLL;
using Learner.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learner.PL.Forms
{
    public static class Learner
    {
        public static ILearnerBLL bll;

        public static void Initialize()
        {
            bll = new LearnerBLL();
        }
    }
}
