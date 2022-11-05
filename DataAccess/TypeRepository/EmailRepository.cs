using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.TypeRepository
{
    public class EmailRepository : GenericRepository<Email>, IEmailRepository
    {
        public EmailRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
