using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MoviesApi.Models;

namespace MoviesApi.Data
{
    public class MovieDbContext : IdentityDbContext
    {
        public virtual DbSet<MovieItem> Movies { get; set; }

        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }
    }
}