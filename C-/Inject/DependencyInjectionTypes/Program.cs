using System;

namespace DependencyInjectionTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorInjection();
            FunctionInject();
            PropertyInjection();
        }

        private static void ConstructorInjection()
        {
            IRepository repository;
            if (true)
            {
                repository = new MongoDbRepository();
            }

            var serverAConstructor = new ServerAConstructor(repository);
            serverAConstructor.GetData();
        }

        private static void FunctionInject()
        {
            IRepository repository;
            if (true)
            {
                repository = new MongoDbRepository();
            }
        }


        private static void PropertyInjection()
        {
            IRepository repository;
            if (true)
            {
                repository = new MongoDbRepository();
            }
        }
    }
}
