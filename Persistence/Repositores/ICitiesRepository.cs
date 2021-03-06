using System.Collections.Generic;
using System.Threading.Tasks;
using Ectotec.Model;

namespace Ectotec.Persistence
{
    public interface ICitiesRepository
    {
        public Task<Page<City>> GetCities(string searchTerm, int maxResults);
        public Task<City> GetCity(int ciudadId);
    }
}