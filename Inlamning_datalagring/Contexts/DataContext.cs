using Inlamning_datalagring.Models.Entities;
using Microsoft.EntityFrameworkCore;







namespace Inlamning_datalagring.Contexts;




internal class DataContext : DbContext
{
    #region constructors and overrides


    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {



    }

  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\skol\kod\c#\Inlamning_datalagring\Inlamning_datalagring\Contexts\inlaming_db.mdf;Integrated Security=True;Connect Timeout=30");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<CommentEntity>()
        //    .HasOne(x => x.User)
        //    .WithMany(x => x.Comments)
        //    .HasForeignKey(x => x.UserId)
        //    .OnDelete(DeleteBehavior.Restrict);
    }
    #endregion


    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<UserTypeEntity> UserTypes { get; set; }
    public DbSet<StatustypeEntity> Statustypes { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<CaseEntity> Cases { get; set; }
    public DbSet<CommentEntity> Comments { get; set; }




}
