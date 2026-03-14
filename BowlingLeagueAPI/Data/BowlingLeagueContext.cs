using Microsoft.EntityFrameworkCore;
using BowlingLeagueAPI.Models;

namespace BowlingLeagueAPI.Data;

public class BowlingLeagueContext : DbContext
{
    public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options)
        : base(options)
    {
    }

    public DbSet<Bowler> Bowlers { get; set; }
    public DbSet<Team> Teams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Team entity
        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamID);
            entity.Property(e => e.TeamName).IsRequired().HasMaxLength(50);
        });

        // Configure Bowler entity
        modelBuilder.Entity<Bowler>(entity =>
        {
            entity.HasKey(e => e.BowlerID);
            entity.Property(e => e.BowlerFirstName).IsRequired().HasMaxLength(50);
            entity.Property(e => e.BowlerLastName).IsRequired().HasMaxLength(50);
            entity.Property(e => e.BowlerMiddleInit).HasMaxLength(1);
            entity.Property(e => e.BowlerAddress).IsRequired().HasMaxLength(50);
            entity.Property(e => e.BowlerCity).IsRequired().HasMaxLength(50);
            entity.Property(e => e.BowlerState).IsRequired().HasMaxLength(2);
            entity.Property(e => e.BowlerZip).IsRequired().HasMaxLength(10);
            entity.Property(e => e.BowlerPhoneNumber).IsRequired().HasMaxLength(14);

            // Configure relationship
            entity.HasOne(b => b.Team)
                  .WithMany(t => t.Bowlers)
                  .HasForeignKey(b => b.TeamID);
        });

        // Seed data - Teams
        modelBuilder.Entity<Team>().HasData(
            new Team { TeamID = 1, TeamName = "Marlins", CaptainID = 1 },
            new Team { TeamID = 2, TeamName = "Sharks", CaptainID = 5 },
            new Team { TeamID = 3, TeamName = "Terrapins", CaptainID = 9 },
            new Team { TeamID = 4, TeamName = "Wombats", CaptainID = 13 },
            new Team { TeamID = 5, TeamName = "Barracudas", CaptainID = 17 },
            new Team { TeamID = 6, TeamName = "Dolphins", CaptainID = 21 }
        );

        // Seed data - Bowlers (based on typical Bowling League database)
        modelBuilder.Entity<Bowler>().HasData(
            // Marlins Team
            new Bowler { BowlerID = 1, BowlerFirstName = "David", BowlerMiddleInit = "M", BowlerLastName = "Fournier", BowlerAddress = "7822 Winding Way", BowlerCity = "San Diego", BowlerState = "CA", BowlerZip = "92126", BowlerPhoneNumber = "(619) 555-5511", TeamID = 1 },
            new Bowler { BowlerID = 2, BowlerFirstName = "Barbara", BowlerMiddleInit = "H", BowlerLastName = "Fournier", BowlerAddress = "7822 Winding Way", BowlerCity = "San Diego", BowlerState = "CA", BowlerZip = "92126", BowlerPhoneNumber = "(619) 555-5512", TeamID = 1 },
            new Bowler { BowlerID = 3, BowlerFirstName = "John", BowlerMiddleInit = "R", BowlerLastName = "Kennedy", BowlerAddress = "3678 West Seventh Street", BowlerCity = "San Diego", BowlerState = "CA", BowlerZip = "92126", BowlerPhoneNumber = "(619) 555-5513", TeamID = 1 },
            new Bowler { BowlerID = 4, BowlerFirstName = "Ann", BowlerMiddleInit = "W", BowlerLastName = "Patterson", BowlerAddress = "1234 Elm Street", BowlerCity = "San Diego", BowlerState = "CA", BowlerZip = "92126", BowlerPhoneNumber = "(619) 555-5514", TeamID = 1 },

            // Sharks Team
            new Bowler { BowlerID = 5, BowlerFirstName = "Michael", BowlerMiddleInit = "S", BowlerLastName = "Viescas", BowlerAddress = "15127 NE 24th #383", BowlerCity = "Redmond", BowlerState = "WA", BowlerZip = "98052", BowlerPhoneNumber = "(425) 555-9857", TeamID = 2 },
            new Bowler { BowlerID = 6, BowlerFirstName = "Carol", BowlerMiddleInit = "L", BowlerLastName = "Viescas", BowlerAddress = "15127 NE 24th #383", BowlerCity = "Redmond", BowlerState = "WA", BowlerZip = "98052", BowlerPhoneNumber = "(425) 555-9858", TeamID = 2 },
            new Bowler { BowlerID = 7, BowlerFirstName = "William", BowlerMiddleInit = "T", BowlerLastName = "Thompson", BowlerAddress = "5678 Oak Avenue", BowlerCity = "Seattle", BowlerState = "WA", BowlerZip = "98001", BowlerPhoneNumber = "(206) 555-3456", TeamID = 2 },
            new Bowler { BowlerID = 8, BowlerFirstName = "Sarah", BowlerMiddleInit = "J", BowlerLastName = "Black", BowlerAddress = "9012 Pine Road", BowlerCity = "Bellevue", BowlerState = "WA", BowlerZip = "98004", BowlerPhoneNumber = "(425) 555-7890", TeamID = 2 },

            // Terrapins Team
            new Bowler { BowlerID = 9, BowlerFirstName = "Kendra", BowlerMiddleInit = "P", BowlerLastName = "Bonnicksen", BowlerAddress = "7335 S. 50th Place", BowlerCity = "Kent", BowlerState = "WA", BowlerZip = "98032", BowlerPhoneNumber = "(206) 555-1234", TeamID = 3 },
            new Bowler { BowlerID = 10, BowlerFirstName = "Megan", BowlerMiddleInit = "J", BowlerLastName = "Patterson", BowlerAddress = "8901 Maple Street", BowlerCity = "Renton", BowlerState = "WA", BowlerZip = "98055", BowlerPhoneNumber = "(425) 555-4567", TeamID = 3 },
            new Bowler { BowlerID = 11, BowlerFirstName = "Zachary", BowlerMiddleInit = "D", BowlerLastName = "Ehrlich", BowlerAddress = "2345 Cedar Lane", BowlerCity = "Tacoma", BowlerState = "WA", BowlerZip = "98401", BowlerPhoneNumber = "(253) 555-6789", TeamID = 3 },
            new Bowler { BowlerID = 12, BowlerFirstName = "Alaina", BowlerMiddleInit = "R", BowlerLastName = "Hallmark", BowlerAddress = "3456 Birch Boulevard", BowlerCity = "Auburn", BowlerState = "WA", BowlerZip = "98002", BowlerPhoneNumber = "(253) 555-8901", TeamID = 3 }
        );
    }
}
