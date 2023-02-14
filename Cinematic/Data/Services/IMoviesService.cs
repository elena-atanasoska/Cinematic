using Cinematic.Data.Base;
using Cinematic.Data.ViewModels;
using Cinematic.Models;
using System.Threading.Tasks;

namespace Cinematic.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);

        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
