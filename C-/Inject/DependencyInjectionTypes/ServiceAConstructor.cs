
namespace DependencyInjectionTypes
{
    public class ServerAConstructor
    {
        public IRepository repository;

        public ServerAConstructor(IRepository repository)
        {
            this.repository = repository;
        }

        public string GetData()
        {
            return this.repository.GetData();
        }
    }
}
