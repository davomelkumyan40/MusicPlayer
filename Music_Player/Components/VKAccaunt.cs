using Newtonsoft.Json;
using System.Drawing;

namespace Music_Player.Components
{
    [JsonObject("response")]
    public class VKAccount
    {
        public VKAccount()
        {
            Token = default(string);
            UserId = default(long);
            IsAuthorized = false;
            Password = default(string);
            Login = default(string);
            UserImage = default(Image);
            UserImgUrl = default(string);
        }

        public VKAccount(string password, string login)
        {
            this.Password = password;
            this.Login = login;
        }

        [JsonProperty("first_name")]
        public string Name { get; set; }

        [JsonProperty("last_name")]
        public string SurName { get; set; }


        public string Token { get; set; }
        public long UserId { get; set; }
        public bool IsAuthorized { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public Image UserImage { get; set; }

        [JsonProperty("photo_200")]
        public string UserImgUrl { get; set; }
    }
}
