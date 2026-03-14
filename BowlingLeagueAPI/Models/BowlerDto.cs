namespace BowlingLeagueAPI.Models;

public class BowlerDto
{
    public int BowlerID { get; set; }
    public string BowlerFirstName { get; set; } = string.Empty;
    public string? BowlerMiddleInit { get; set; }
    public string BowlerLastName { get; set; } = string.Empty;
    public string TeamName { get; set; } = string.Empty;
    public string BowlerAddress { get; set; } = string.Empty;
    public string BowlerCity { get; set; } = string.Empty;
    public string BowlerState { get; set; } = string.Empty;
    public string BowlerZip { get; set; } = string.Empty;
    public string BowlerPhoneNumber { get; set; } = string.Empty;
}
