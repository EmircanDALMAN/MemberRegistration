using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Utilities.Results;

namespace Shared.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            return logics.FirstOrDefault(logic => !logic.Success);
        }
    }
}
