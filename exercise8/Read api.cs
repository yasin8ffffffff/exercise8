using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace exercise8
{
    public class Read_api
    {
        public static async Task Main(string[] args)
        {
            using var httpClient = new HttpClient();
            var responce = await httpClient.GetAsync("https://api.kucoin.com/api/v1/market/stats?symbol=BTC-USDT");
            var content = await responce.Content.ReadAsStringAsync();         
        }
        public int code { get; set; }
        public int data { get; set; }      
    }
}
