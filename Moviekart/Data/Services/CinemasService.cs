using Moviekart.Data.Base;
using Moviekart.Models;

namespace Moviekart.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {

        }
    }
}
