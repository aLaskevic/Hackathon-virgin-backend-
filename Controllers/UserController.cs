using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Repository;

namespace WebApplication3.Controllers;

[ApiController]
[EnableCors("CorsPolicy")]
public class UserController
{
    UserRepository _userRepository;
    ProjectRepository _projectRepository;

    public UserController(UserRepository userRepository, ProjectRepository projectRepository)
    {
        _userRepository = userRepository;
        _projectRepository = projectRepository;
    }
    
    [HttpGet]
    [Route("/api/users/{userId}")]
    public IActionResult GetUser(int userId)
    {
        return new OkObjectResult(_userRepository.GetUser(userId));
    }
    
        
    [HttpGet]
    [Route("/api/users/{userId}/redeem/{qrCode}")]
    public IActionResult RedeemQrCode(int userId, string qrCode)
    {
        var reward = _projectRepository.GetReward(qrCode);
        if (reward == null)
        {
            return new NotFoundObjectResult("Reward not found");
        }

        var user =_userRepository.GetUser(userId);
        if (reward.EarnedBadge != null)
        {
            if (!user.EarnedBadges.Contains(reward.EarnedBadge))
            {
                user.EarnedBadges.Add(reward.EarnedBadge);
            }
        }

        user.XP += reward.EarnedXPAmount;
        
        // todo adding virgin points to external api goes here
        
        return new OkObjectResult(reward);
    }
}