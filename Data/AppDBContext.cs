using Microsoft.EntityFrameworkCore;
using ShippingServices.Model;
namespace ShippingServices.Data


{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { }
        public DbSet<ShippingItem> ShippingItems { get; set; }  
    }
}
