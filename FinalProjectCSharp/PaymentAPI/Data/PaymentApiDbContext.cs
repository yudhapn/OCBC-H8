using PaymentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace PaymentAPI.Data
{
    public class PaymentApiDbContext : IdentityDbContext
    {
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public PaymentApiDbContext(DbContextOptions<PaymentApiDbContext> options) : base(options)
        {

        }
    }
}
