namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Address
        {
            get;
        }
        IEmailRepository Email
        {
            get;
        }
        IPersonRepository Person
        {
            get;
        }
        int Save();
    }
}
