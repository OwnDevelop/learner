using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learner.BLL.Abstract
{
    public class UnknowException :Exception
    {
        public UnknowException()
        {

        }

        public UnknowException(string message) : base(message)
        {

        }

        public UnknowException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
