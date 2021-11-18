using MovieProTitan.Models.Database;
using MovieProTitan.Models.TMDB;
using System.Threading.Tasks;

namespace MovieProTitan.Services.Interfaces
{
    public interface IDataMappingService
    {
        Task<Movie> MapMovieDetailAsync(MovieDetail movie);
        ActorDetail MapActorDetail(ActorDetail actor);

    }
}
