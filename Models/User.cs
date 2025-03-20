namespace WebApplication3.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Badge> EarnedBadges { get; set; }
    public List<int> ProjectParticipations { get; set; }
    
    public int XP { get; set; }
    public int Level { get; set; }
}