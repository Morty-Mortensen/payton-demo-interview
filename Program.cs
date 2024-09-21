using AristotlePrepPayton.Models;
using AristotlePrepPayton.Models.Enums;

namespace AristotlePrepPayton;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();
        builder.Services.AddControllers();

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();
    }

    private static Tournament _tournament = new Tournament()
    {
        SubTournament = new Tournament()
        {
            SubTournament = new Tournament()
            {
                SubTournament = new Tournament()
                {
                    SubTournament = new Tournament()
                    {
                        SubTournament = new Tournament()
                        {
                            SubTournament = null,
                            Participants = new List<Account>()
                            {
                                new Account()
                                {
                                    AccountId = 1,
                                    Winnings = 0.33m,
                                    AccountType = AccountType.Individual
                                },
                                new Account()
                                {
                                    AccountId = 2,
                                    Winnings = 0.63m,
                                    AccountType = AccountType.Commercial
                                },
                                new Account()
                                {
                                    AccountId = 3,
                                    Winnings = 6.33m,
                                    AccountType = AccountType.Individual
                                }
                            }
                        },
                        Participants = new List<Account>()
                        {
                            new Account()
                            {
                                AccountId = 4,
                                Winnings = 22.33m,
                                AccountType = AccountType.Charity
                            },
                            new Account()
                            {
                                AccountId = 5,
                                Winnings = 500.63m,
                                AccountType = AccountType.Commercial
                            },
                            new Account()
                            {
                                AccountId = 6,
                                Winnings = 132.33m,
                                AccountType = AccountType.Individual
                            },
                            new Account()
                            {
                                AccountId = 7,
                                Winnings = 96.33m,
                                AccountType = AccountType.Commercial
                            },
                            new Account()
                            {
                                AccountId = 8,
                                Winnings = 83.23m,
                                AccountType = AccountType.Charity
                            }
                        }
                    },
                    Participants = new List<Account>()
                    {
                        new Account()
                        {
                            AccountId = 9,
                            Winnings = 56.33m,
                            AccountType = AccountType.Commercial
                        },
                        new Account()
                        {
                            AccountId = 10,
                            Winnings = 678.63m,
                            AccountType = AccountType.Commercial
                        },
                        new Account()
                        {
                            AccountId = 11,
                            Winnings = 214.33m,
                            AccountType = AccountType.Individual
                        },
                        new Account()
                        {
                            AccountId = 12,
                            Winnings = 567.33m,
                            AccountType = AccountType.Individual
                        },
                        new Account()
                        {
                            AccountId = 13,
                            Winnings = 294.23m,
                            AccountType = AccountType.Charity
                        }
                    }
                },
                Participants = new List<Account>()
                {
                    new Account()
                    {
                        AccountId = 14,
                        Winnings = 999.33m,
                        AccountType = AccountType.Individual
                    },
                    new Account()
                    {
                        AccountId = 15,
                        Winnings = 43.63m,
                        AccountType = AccountType.Charity
                    },
                    new Account()
                    {
                        AccountId = 16,
                        Winnings = 65.33m,
                        AccountType = AccountType.Commercial
                    },
                    new Account()
                    {
                        AccountId = 17,
                        Winnings = 1.33m,
                        AccountType = AccountType.Charity
                    },
                    new Account()
                    {
                        AccountId = 18,
                        Winnings = 0.23m,
                        AccountType = AccountType.Individual
                    }
                }
            },
            Participants = new List<Account>()
            {
                new Account()
                {
                    AccountId = 19,
                    Winnings = 31.33m,
                    AccountType = AccountType.Charity
                },
                new Account()
                {
                    AccountId = 20,
                    Winnings = 35.63m,
                    AccountType = AccountType.Charity
                },
                new Account()
                {
                    AccountId = 21,
                    Winnings = 87.33m,
                    AccountType = AccountType.Charity
                },
                new Account()
                {
                    AccountId = 22,
                    Winnings = 6432.33m,
                    AccountType = AccountType.Charity
                },
                new Account()
                {
                    AccountId = 23,
                    Winnings = 88.23m,
                    AccountType = AccountType.Individual
                }
            }
        },
        Participants = new List<Account>()
        {
            new Account()
            {
                AccountId = 24,
                Winnings = 94.33m,
                AccountType = AccountType.Individual
            },
            new Account()
            {
                AccountId = 25,
                Winnings = 92.63m,
                AccountType = AccountType.Individual
            },
            new Account()
            {
                AccountId = 26,
                Winnings = 87.33m,
                AccountType = AccountType.Individual
            },
            new Account()
            {
                AccountId = 27,
                Winnings = 92.33m,
                AccountType = AccountType.Individual
            },
            new Account()
            {
                AccountId = 28,
                Winnings = 32.23m,
                AccountType = AccountType.Commercial
            }
        }
    };

    /// <summary>
    /// #3 Recursive fun!
    /// 1. How to get the biggest cash amount below $100.00 won out of all the commercial or individual accounts
    /// 2. Surprise last step (test your data manipulation)
    /// </summary>
    /// <returns></returns>
    private static decimal GetBiggestWinnerInTournament(Tournament tournament)
    {

        return 0m;
    }
}