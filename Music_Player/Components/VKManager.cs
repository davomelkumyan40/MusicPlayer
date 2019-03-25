using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using Newtonsoft.Json;
using System.IO;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;
using VkNet.Utils;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using VkNet.AudioBypassService.Extensions;
using System.Linq;

namespace Music_Player.Components
{
    public class VKManager
    {

        private const uint appID = 6882243;
        public VKManager()
        {
            service = new ServiceCollection();
            service.AddAudioBypass();
            UserDataFile = new FileInfo(Properties.Resources.UserDataJSONPath);
            UserAccauntDataFile = new FileInfo(Properties.Resources.UserAccauntDataPath);
            SecretDataFile = new FileInfo(Properties.Resources.SecretUserJSONDataPath);
        }

        public VKManager(string login, string password)
        {

            Login = login;
            Password = password;
            service = new ServiceCollection();
            service.AddAudioBypass();
            UserDataFile = new FileInfo(Properties.Resources.UserDataJSONPath);
            UserAccauntDataFile = new FileInfo(Properties.Resources.UserAccauntDataPath);
            SecretDataFile = new FileInfo(Properties.Resources.SecretUserJSONDataPath);
        }

        private string Login { get; set; }
        private string Password { get; set; }
        public VkApi UserVk { get; set; }
        private ServiceCollection service;
        private VKAccount Account { get; set; }
        private HttpWebRequest request;
        private FileInfo UserDataFile;
        private FileInfo UserAccauntDataFile;
        private FileInfo SecretDataFile;
        public string[] FileList
        {
            get
            {
                if (Account == null)
                    Account = new VKAccount();
                if (Account.IsAuthorized)
                    return Directory.GetFiles(Properties.Resources.MusicFolderPath + Account.Name).OrderBy((c) => c).ToArray();
                else
                    return Directory.GetFiles(Properties.Resources.PublicMusicFolder).OrderBy((c) => c).ToArray();
            }
        }


        //Authentificate and returns VKAccaunt instance
        public VKAccount Authentificate(bool saveProfileToJson = false)
        {
            Account = new VKAccount(Password, Login);
            UserVk = new VkApi(service);
            try
            {
                Settings set = Settings.Audio;
                UserVk.Authorize(new ApiAuthParams
                {
                    Password = this.Password,
                    Login = this.Login,
                    ApplicationId = appID,
                    Settings = set
                });
                if (UserVk.IsAuthorized)
                {
                    GiveAllInfoToAccountObject();
                    if (saveProfileToJson)
                    {
                        SaveAs(UserDataFile.Name, JsonConvert.SerializeObject(UserVk));
                        using (JsonTextWriter writer = new JsonTextWriter(new StreamWriter(SecretDataFile.Name, true)))
                        {
                            writer.WriteStartObject();
                            writer.WritePropertyName("Name");
                            writer.WriteValue(Account.Name);
                            writer.WritePropertyName("SurName");
                            writer.WriteValue(Account.SurName);
                            writer.WritePropertyName("Password");
                            writer.WriteValue(Account.Password);
                            writer.WritePropertyName("Login");
                            writer.WriteValue(Account.Login);
                            writer.WriteEndObject();
                        }
                        SaveAs(UserAccauntDataFile.Name, JsonConvert.SerializeObject(UserVk.Account.GetInfo()));
                    }
                }
                else
                {
                    MusicMessageBox box = new MusicMessageBox();
                    box.Show();
                    box.ShowWindow(null, MessageFlags.WrongAuth);
                }
            }
            catch (Exception ex)
            {
                MusicMessageBox box = new MusicMessageBox();
                box.Show();
                box.ShowWindow(null, ex.Message);
            }
            return Account;
        }

        //Authentificate from json file and returns VKAccaunt instance
        public VKAccount AuthentificateFromFile(string jsonString, string jsonString2)
        {
            Account = new VKAccount();
            UserVk = new VkApi(service);
            try
            {
                Account = JsonConvert.DeserializeObject<VKAccount>(jsonString);
                var obj = JsonConvert.DeserializeObject<VKAccount>(jsonString2);
                Account.Password = obj.Password;
                Account.Login = obj.Login;
                Settings set = Settings.Audio;
                UserVk.Authorize(new ApiAuthParams
                {
                    AccessToken = Account.Token,
                    ApplicationId = appID,
                    Settings = set
                });
                GiveAllInfoToAccountObject();
            }
            catch (VkNet.Exception.VkApiException ex)
            {
                MusicMessageBox box = new MusicMessageBox();
                box.Show();
                box.ShowWindow(null, ex.Message);
            }
            return Account;
        }


        //downloading and returning like Image the user avatar TUPLE<T1, T2, T3>
        public void GiveAllInfoToAccountObject()
        {
            request = WebRequest.Create($@"https://api.vk.com/method/users.get?owner_id={UserVk.UserId}&fields=photo_200&access_token={UserVk.Token}{Properties.Resources.VkAPIVersion}") as HttpWebRequest;
            HttpWebResponse respons = request.GetResponse() as HttpWebResponse;
            Stream jsonStream = respons.GetResponseStream();
            StreamReader r = new StreamReader(jsonStream);
            string jsonStr = r.ReadToEnd();
            r.Dispose();
            var obj = JsonConvert.DeserializeObject<RootVKAccount>(jsonStr);
            obj.response[0].Password = Account.Password;
            obj.response[0].Login = Account.Login;
            obj.response[0].IsAuthorized = true;
            obj.response[0].Token = UserVk.Token;
            obj.response[0].UserId = UserVk.UserId.Value;
            Account = obj.response[0];
            if (!new DirectoryInfo(Properties.Resources.UserSourceFolderPath + Account.Name).Exists)
                Directory.CreateDirectory(Properties.Resources.UserSourceFolderPath + Account.Name);
            string avatarFullPAth = $@"{Properties.Resources.UserSourceFolderPath}{Account.Name}/{Properties.Resources.CurrentUserAvatarFileNAme}";
            if (!new FileInfo(avatarFullPAth).Exists)
            {
                new WebClient().DownloadFile(Account.UserImgUrl, avatarFullPAth);
            }
            Account.UserImage = System.Drawing.Image.FromFile(avatarFullPAth);
        }


        public VkCollection<Audio> AudioList { get; set; }
        public void SaveAs(string fileName, string json)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter write = new StreamWriter(stream))
                {
                    write.WriteLine(json);
                }
            }
        }

        public VkCollection<Audio> GetAllAudio()
        {
            VkCollection<Audio> list = null;
            try
            {
                list = UserVk.Audio.Get(new AudioGetParams { OwnerId = UserVk.UserId.Value });
            }
            catch (Exception ex)
            {
                MusicMessageBox box = new MusicMessageBox();
                box.ShowWindow(null, ex.Message);
            }
            return list;
        }

        public IEnumerable<string> GetAllAudioTitles()
        {
            if (AudioList != null)
                foreach (var audio in AudioList)
                {
                    yield return audio.Title;
                }
        }

        public IEnumerable<string> GetAllAudioArtistNames()
        {
            if (AudioList != null)
                foreach (var audio in AudioList)
                {
                    yield return audio.Artist;
                }
        }

        public IEnumerable<Uri> GetAllAudioUrl()
        {
            if (AudioList != null)
                foreach (var audio in AudioList)
                {
                    yield return audio.Url;
                }
        }

        public void DownloadAllMusic()
        {
            AudioList = GetAllAudio();
            if (AudioList != null || AudioList.Count != 0)
            {
                using (WebClient client = new WebClient())
                {
                    foreach (var audio in AudioList)
                    {
                        string path = $@"{Properties.Resources.MusicFolderPath}{Account.Name}\{audio.Title} - {audio.Artist}.mp3";
                        FileInfo file = new FileInfo(path);
                        if (Directory.Exists(Properties.Resources.MusicFolderPath + Account.Name))
                        {
                            if (!file.Exists)
                            {
                                client.DownloadFile(audio.Url, path);
                            }
                        }
                        else
                        {
                            Directory.CreateDirectory(Properties.Resources.MusicFolderPath + Account.Name);
                        }
                    }
                }
            }
            else
            {
                MusicMessageBox box = new MusicMessageBox();
                box.Show();
                box.ShowWindow(null, Properties.Resources.NoMusicToDownloadText + "\n\rThanks form using our product.");
            }
        }

        public Audio GetAudioByID(long id)
        {
            Audio currentAudio = null;
            if (AudioList != null)
                foreach (var audio in AudioList)
                {
                    if (audio.Id.Value == id)
                    {
                        currentAudio = audio;
                        break;
                    }
                }
            return currentAudio;
        }

        public void DownloadAudioByID(long id)
        {
            Audio audio = GetAudioByID(id);
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(audio.Url, $@"{Properties.Resources.MusicFolderPath}{Account.Name}\{audio.Title}.mp3");
            }
        }
    }
}
