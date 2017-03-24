using Autofac;
using FilterString;

namespace FilterStrings
{
    public class DiContainer
    {
        public static IContainer Container { get; private set; }

        static DiContainer()
        {
            var container = new ContainerBuilder();

            container.Register<IWordListRepository>(c => new WordListRepository());
            Container = container.Build();
        }
    }
}
