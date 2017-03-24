using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterString
{
    public interface IWordListRepository
    {
        string[] GetAllStrings();
    }
}
