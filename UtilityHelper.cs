using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using hrportalNew.Models; // Make sure this is the correct namespace for EcommerceDbContext


namespace NewComplainCore.Helper
{
    public class UtilityHelper
    {
        public static string GetUserSessionData(string userSession, string data)
        {
            if (string.IsNullOrEmpty(userSession))
                return "";
            try
            {
                var user = Newtonsoft.Json.JsonConvert.DeserializeObject<hrportalNew.Models.UserHome>(userSession);
                if (user == null) return "";

                return data.ToLower() switch
                {
                    "userid" => user.userId.ToString(),
                    "username" => user.username ?? "",
                    "name" => user.name ?? "",
                    "pfp" => user.profilePic ?? "",
                    _ => ""
                };
            }
            catch
            {
                return "";
            }
        }
    }
}