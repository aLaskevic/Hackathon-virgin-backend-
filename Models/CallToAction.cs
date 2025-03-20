using System.Text.Json.Serialization;
using Bogus;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Models;

public class CallToAction
{
    public string Name { get; set; }
    public Reward Reward { get; set; }
    public string Category { get; set; }
    
    [JsonIgnore]
    public string QrCode { get; set; }

    public string RewardCode {
        get;
        set;
    }
    
    private string[] badgeNames = {"badge-0.png","badge-1.png","badge-2.png","badge-3.png"};
    public CallToAction(string name, string rewardCode=null)
    {
        
        
        var faker = new Faker();
        Name = name;
        QrCode = rewardCode != null? rewardCode : faker.Random.AlphaNumeric(10);
        Reward = new Reward
        {
            Name = null,
            EarnedBadge = new Badge
            {
                Name = "Cool Guy",
                Image = "/images/" + badgeNames[faker.Random.Number(0,badgeNames.Length-1)],
                Description = "This person cared.."
            },
            EarnedXPAmount = 10,
            EarnedVirginPoints = 20,
            Description = faker.Lorem.Sentence(),
            
        };
    }
}