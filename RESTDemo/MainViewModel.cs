using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Text.Json;

namespace RESTDemo
{
    public class MainViewModel
    {
        HttpClient client;
        JsonSerializerOptions _serializerOptions;
        string baseUrl = "https://67d1962490e0670699babade.mockapi.io";
        public MainViewModel()
        {
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
        }

        public ICommand AddUserCommand =>
            new Command(async () =>
            {
                var url = $"{baseUrl}/users";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode){
                    var content = await response.Content.ReadAsStringAsync();
                }
            });
    }
}
