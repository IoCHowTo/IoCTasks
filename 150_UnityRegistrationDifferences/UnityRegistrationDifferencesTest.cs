using Microsoft.Practices.Unity;
using NUnit.Framework;

namespace UnityRegistrationDifferences
{
    [TestFixture]
    public class UnityRegistrationDifferencesTest
    {
        [Test]
        public void Test1()
        {
            var container = new UnityContainer();
            container.RegisterType<IService, RemoteService>();

            var instance = container.Resolve<IService>();
            var instance2 = container.Resolve<RemoteService>();

            Assert.AreNotEqual(instance, instance2);
            Assert.IsInstanceOf<RemoteService>(instance);
            Assert.IsInstanceOf<RemoteService>(instance2);
        }

        [Test]
        public void Test2()
        {
            var container = new UnityContainer();
            container.RegisterType<IService, RemoteService>(new ContainerControlledLifetimeManager());

            var instance = container.Resolve<IService>();
            var instance2 = container.Resolve<RemoteService>();

            Assert.AreEqual(instance, instance2);
            Assert.IsInstanceOf<RemoteService>(instance);
            Assert.IsInstanceOf<RemoteService>(instance2);
        }

        [Test]
        public void Test3()
        {
            var container = new UnityContainer();
            container.RegisterType<IService, RemoteService>(new ContainerControlledLifetimeManager());

            var childContainer = container.CreateChildContainer();
            childContainer.RegisterType<IService, LocalService>();

            var instance = childContainer.Resolve<IService>();
            var instance2 = childContainer.Resolve<LocalService>();

            Assert.AreNotEqual(instance, instance2);
            Assert.IsInstanceOf<LocalService>(instance);
            Assert.IsInstanceOf<LocalService>(instance2);
        }

        [Test]
        public void Test4()
        {
            var container = new UnityContainer();
            container.RegisterType<IService, RemoteService>(new ContainerControlledLifetimeManager());

            var childContainer = container.CreateChildContainer();
            childContainer.RegisterType<IService, LocalService>(new ContainerControlledLifetimeManager());

            var instance = childContainer.Resolve<IService>();
            var instance2 = childContainer.Resolve<LocalService>();

            Assert.AreEqual(instance, instance2);
            Assert.IsInstanceOf<LocalService>(instance);
            Assert.IsInstanceOf<LocalService>(instance2);
        }

        [Test]
        public void Test5()
        {
            var container = new UnityContainer();
            container.RegisterType<IService, RemoteService>(new ContainerControlledLifetimeManager());

            var childContainer = container.CreateChildContainer();
            childContainer.RegisterType<IService, LocalService>();

            var instance = childContainer.Resolve<IService>();
            var instance2 = childContainer.Resolve<IService>();

            Assert.AreNotEqual(instance, instance2);
            Assert.IsInstanceOf<LocalService>(instance);
            Assert.IsInstanceOf<LocalService>(instance2);
        }

        [Test]
        public void Test6()
        {
            var container = new UnityContainer();
            container.RegisterType<IService, RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService2, RemoteService>(new ContainerControlledLifetimeManager());

            var instance = container.Resolve<IService>();
            var instance2 = container.Resolve<IService2>();

            Assert.AreEqual(instance, instance2);
            Assert.IsInstanceOf<RemoteService>(instance);
            Assert.IsInstanceOf<RemoteService>(instance2);
        }

        [Test]
        public void Test7()
        {
            var container = new UnityContainer();
            container.RegisterType<RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService, RemoteService>();
            container.RegisterType<IService2, RemoteService>();

            var instance = container.Resolve<IService>();
            var instance2 = container.Resolve<IService2>();

            Assert.AreEqual(instance, instance2);
            Assert.IsInstanceOf<RemoteService>(instance);
            Assert.IsInstanceOf<RemoteService>(instance2);
        }

        [Test]
        public void Test8()
        {
            var container = new UnityContainer();
            container.RegisterType<RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService, RemoteService>();
            container.RegisterType<IService2, IService>();

            Assert.Throws < ResolutionFailedException>(() => container.Resolve<IService2>());
        }

        [Test]
        public void Test9()
        {
            var container = new UnityContainer();

            container.RegisterType<RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService, RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService2, RemoteService>(new ContainerControlledLifetimeManager());

            var childContainer = container.CreateChildContainer();
            childContainer.RegisterType<IService, LocalService>();

            var instance = childContainer.Resolve<IService>();
            var instance2 = childContainer.Resolve<IService2>();

            Assert.AreNotEqual(instance, instance2);
            Assert.IsInstanceOf<LocalService>(instance);
            Assert.IsInstanceOf<RemoteService>(instance2);
        }

        [Test]
        public void Test10()
        {
            var container = new UnityContainer();
            container.RegisterType<RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService, RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService2, RemoteService>(new ContainerControlledLifetimeManager());

            var instance = container.Resolve<IService>();
            var instance2 = container.Resolve<IService2>();

            Assert.AreEqual(instance, instance2);
            Assert.IsInstanceOf<RemoteService>(instance);
            Assert.IsInstanceOf<RemoteService>(instance2);
        }

        [Test]
        public void Test11()
        {
            var container = new UnityContainer();

            container.RegisterType<RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService, RemoteService>();
            container.RegisterType<IService2, RemoteService>();

            var childContainer = container.CreateChildContainer();
            childContainer.RegisterType<RemoteService>(new PerResolveLifetimeManager());

            var instance = childContainer.Resolve<IService>();
            var instance2 = childContainer.Resolve<IService2>();

            Assert.AreNotEqual(instance, instance2);
            Assert.IsInstanceOf<RemoteService>(instance);
            Assert.IsInstanceOf<RemoteService>(instance2);
        }

        [Test]
        public void Test12()
        {
            var container = new UnityContainer();
            container.RegisterType<RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService, RemoteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IService2, RemoteService>(new ContainerControlledLifetimeManager());

            container.RegisterType<IService, LocalService>();
            container.RegisterType<IService2, LocalService>();

            var instance = container.Resolve<IService>();
            var instance2 = container.Resolve<IService2>();

            Assert.AreNotEqual(instance, instance2);
            Assert.IsInstanceOf<LocalService>(instance);
            Assert.IsInstanceOf<LocalService>(instance2);
        }
    }

    public interface IService2
    {
        
    }

    public interface IService : IService2
    {
        
    }

    public class RemoteService : IService
    {
        
    }

    public class LocalService : IService
    {
        
    }
}
