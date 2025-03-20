using WebApplication3.Models;

namespace WebApplication3.Repository;

public class UserRepository
{
    public List<User> Users { get; set; }

    public UserRepository()
    {
        Users = new List<User>();
        SeedData();
    }
    public User GetUser(int id)
    {
        return Users.Where(usr=>usr.Id==id).FirstOrDefault();
    }

    private void SeedData()
    {
        var badges = new List<Badge>();
        badges.Add(new Badge
        {
            Name = "Beach Cleaner",
            Image = "/images/badge-0.png" ,
            Description = "Cleaned a beach"
        });
        badges.Add(new Badge
        {
            Name = "Sugar Daddy",
            Image = "/images/badge-2.png" ,
            Description = "Donated to cause"
        });
        
        Users.Add(new User
        {
            Id = 0,
            Name = "Reto Schweizmann",
            EarnedBadges = badges,
            ProjectParticipations = new List<int>{1,2,3},
            XP = 200,
            Level = 3,
        });
    }
    
    
    
}