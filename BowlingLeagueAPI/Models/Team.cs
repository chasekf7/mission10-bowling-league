namespace BowlingLeagueAPI.Models;

public class Team
{
    public int TeamID { get; set; }
    public string TeamName { get; set; } = string.Empty;
    public int CaptainID { get; set; }

    // Navigation property
    public ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();
}
