namespace WebApplication3.Models;

public class Reward
{
    public string Name { get; set; }
    public Badge EarnedBadge { get; set; }
    public int EarnedXPAmount { get; set; }
    public int EarnedVirginPoints { get; set; }

    public string Description { get; set; }
}