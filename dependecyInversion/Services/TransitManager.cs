namespace dependecyInversion.Services
{

    public class TransitManager : ITransientService
    {
        private  string _guidId;
        public TransitManager()
        {
            _guidId = Guid.NewGuid().ToString();
        }
 

        public string GuidId => _guidId;
    }
    public class ScopedManager : IScopedService
    {

        private string _guidId;
        public ScopedManager()
        {
            _guidId = Guid.NewGuid().ToString();
        }
        public string GuidId { get => _guidId;  }
    }
    public class SingletonManager : ISingletonService
    {

        private string _guidId;
        public SingletonManager()
        {
            _guidId = Guid.NewGuid().ToString();
        }
        public string GuidId { get => _guidId;  }
    }
}
