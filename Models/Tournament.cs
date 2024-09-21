namespace AristotlePrepPayton.Models;

public class Tournament
{
    public Tournament SubTournament { get; set; }
    
    public IList<Account> Participants { get; set; }
}