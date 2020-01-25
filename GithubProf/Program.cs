using System;
using System.IO;
using System.Net;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace GithubProf
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.github.com/users/Katlintthk?client_id=3ced984202aa0b699560&client_secret=c6d88c5ab9ea45cfa6e319347e4ef3e1baf487e0";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";

            request.UserAgent = "Foo";
            request.Accept = "*/*";
            
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                Console.WriteLine(response);
                ProfileData profileData = JsonConvert.DeserializeObject<ProfileData>(response);
                Console.WriteLine($"Login:{profileData.Login}");
                Console.WriteLine($"Public repos:{profileData.PublicRepos}");
                Console.WriteLine($"Avatar url:{profileData.AvatarUrl}");
                Console.WriteLine($"Followers:{profileData.Followers}");
                Console.WriteLine($"Following:{profileData.Following}");
                
                
                              

            }
            
        }
    }
}