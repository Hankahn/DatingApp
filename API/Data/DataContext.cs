using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data {

    /// <summary>l</summary>
    public class DataContext : DbContext {

        #region Public Properties

        public DbSet<AppUser> Users { get; set; }

        #endregion // Public Properties

        #region Constructors

        public DataContext(DbContextOptions options) : base(options) { 
            
        }

        #endregion // Constructors

    }

}