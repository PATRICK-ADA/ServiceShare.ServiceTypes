using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Data.ApplicationContext
{

public class ApplicationContext : DbContext
{

public DbSet<NetFlixService> Netflix {get; set;}
public DbSet<SportifyService> Sportify {get; set;}

public DbSet<UtubeService> Utube {get; set;}



public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
{


}

} 


}