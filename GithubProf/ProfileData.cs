using Newtonsoft.Json;

namespace GithubProf
{
    public class ProfileData
    {
        public string Login { get; set;}
        [JsonProperty("public_repos")] public string PublicRepos { get; set; }
        [JsonProperty("avatar_url")] public string AvatarUrl { get; set; }
        public string Followers { get; set; }
        public string Following { get; set; }
        
        
        
    }
}