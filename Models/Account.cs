using AristotlePrepPayton.Models.Enums;

namespace AristotlePrepPayton.Models;

public class Account
{
    public int AccountId { get; set; }
    
    public decimal Winnings { get; set; }
    
    public AccountType AccountType { get; set; }
}