using Domain;
using Domain.Interfaces;

namespace DataAccess.TypeRepository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(DatabaseContext context) : base(context)
        {

        }        
    }
}
