using FilterStrings;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterString
{
    public class WordListSingleton
    {
        public static string[] StringsInstance { get; private set; }

        static WordListSingleton()
        {
            using (var scope = DiContainer.Container.BeginLifetimeScope())
            {
                var stringRepository = scope.Resolve<IWordListRepository>();

                StringsInstance = stringRepository.GetAllStrings();
            }
        }
    }
}
