using Cinematic.Data.Base;
using Cinematic.Models;

namespace Cinematic.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
        

    }
}
