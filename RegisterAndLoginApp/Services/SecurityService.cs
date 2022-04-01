using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    

    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();


        public SecurityService()
        {
            knownUsers.Add(new UserModel() { Id = 0, UserName = "Michael", Password = "Scott" });
            knownUsers.Add(new UserModel() { Id = 1, UserName = "Dwight", Password = "Schrute" });
            knownUsers.Add(new UserModel() { Id = 2, UserName = "Pamela", Password = "Beesly" });
            knownUsers.Add(new UserModel() { Id = 3, UserName = "Kevin", Password = "Malone" });
            knownUsers.Add(new UserModel() { Id = 4, UserName = "Angela", Password = "Martin" });
        }

        public bool isValid(UserModel user)
        {
            return knownUsers.Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
}

    
