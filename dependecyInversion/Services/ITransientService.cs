namespace dependecyInversion.Services
{
    public interface IServiceBase
    {
        string GuidId { get;  }

    }

    public interface ITransientService: IServiceBase
    {
         
    }
    public interface ISingletonService : IServiceBase
    {
        

    }
    public interface IScopedService : IServiceBase
    {
       

    }
}
