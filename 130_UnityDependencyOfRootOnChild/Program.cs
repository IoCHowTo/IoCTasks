using System;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityDependencyOfRootOnChild
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = new UnityContainer())
            {
                container.RegisterType<ITimeAPI, TimeAPI>(new ContainerControlledLifetimeManager());

                var factory = new TaskFactory();

                Task.WaitAll(new []
                {
                    factory.StartNew(() => ProcessOnBackGround(container, "handler1")),
                    factory.StartNew(() => ProcessOnBackGround(container, "handler2")),
                    factory.StartNew(() => ProcessOnBackGround(container, "handler3")),
                    factory.StartNew(() => ProcessOnBackGround(container, "handler4")),
                });

                Console.ReadLine();
            }
        }

        static void ProcessOnBackGround(IUnityContainer rootContainer, string handlerName)
        {
            using (var child = rootContainer.CreateChildContainer())
            {
                // register a log with explicit name which will be task execution
                // specific
                child.RegisterInstance<ILog>(new Log(handlerName + ".txt"));

                var api = child.Resolve<ITimeAPI>();
                Console.WriteLine("{0}: Now: {1}", handlerName, api.GetNow().Result);
            }
        }
    }
}
