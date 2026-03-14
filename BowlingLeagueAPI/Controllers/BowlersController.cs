using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BowlingLeagueAPI.Data;
using BowlingLeagueAPI.Models;

namespace BowlingLeagueAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BowlersController : ControllerBase
{
    private readonly BowlingLeagueContext _context;

    public BowlersController(BowlingLeagueContext context)
    {
        _context = context;
    }

    // GET: api/Bowlers
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BowlerDto>>> GetBowlers()
    {
        // Get bowlers from Marlins and Sharks teams only
        var bowlers = await _context.Bowlers
            .Include(b => b.Team)
            .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
            .Select(b => new BowlerDto
            {
                BowlerID = b.BowlerID,
                BowlerFirstName = b.BowlerFirstName,
                BowlerMiddleInit = b.BowlerMiddleInit,
                BowlerLastName = b.BowlerLastName,
                TeamName = b.Team!.TeamName,
                BowlerAddress = b.BowlerAddress,
                BowlerCity = b.BowlerCity,
                BowlerState = b.BowlerState,
                BowlerZip = b.BowlerZip,
                BowlerPhoneNumber = b.BowlerPhoneNumber
            })
            .ToListAsync();

        return Ok(bowlers);
    }

    // GET: api/Bowlers/5
    [HttpGet("{id}")]
    public async Task<ActionResult<BowlerDto>> GetBowler(int id)
    {
        var bowler = await _context.Bowlers
            .Include(b => b.Team)
            .Where(b => b.BowlerID == id)
            .Select(b => new BowlerDto
            {
                BowlerID = b.BowlerID,
                BowlerFirstName = b.BowlerFirstName,
                BowlerMiddleInit = b.BowlerMiddleInit,
                BowlerLastName = b.BowlerLastName,
                TeamName = b.Team!.TeamName,
                BowlerAddress = b.BowlerAddress,
                BowlerCity = b.BowlerCity,
                BowlerState = b.BowlerState,
                BowlerZip = b.BowlerZip,
                BowlerPhoneNumber = b.BowlerPhoneNumber
            })
            .FirstOrDefaultAsync();

        if (bowler == null)
        {
            return NotFound();
        }

        return Ok(bowler);
    }
}
