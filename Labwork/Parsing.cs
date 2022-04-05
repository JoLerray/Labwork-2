using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork
{
    interface BaseParsing<T,Result>
    {
      List<Result> Parsing(T data);
    }
}
