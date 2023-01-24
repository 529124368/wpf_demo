using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.tool
{
    public enum Request
    {
        get,post,put,delete
    }
    public class ClientHttp
    {
        private string _apiUrl = "http://127.0.0.1/api/";
        private string _jsonData = "";
        private HttpClient _httpClient;

        public string ApiUrl { get => _apiUrl; set => _apiUrl = value; }
        public string JsonData { get => _jsonData; set => _jsonData = value; }

        public ClientHttp()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ApiUrl);
        }

        public ClientHttp SetRequestJsonData(Dictionary<string,string> data)
        {
            JsonData = JsonConvert.SerializeObject(data);
            return this;
        }

        public ClientHttp SetRequestHeader(string key,string value)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add(key,value);
            return this;
        }

        public async Task<string> GetResult(Request type,string uri)
        {
            HttpResponseMessage res = null;
            switch (type)
            {
                case Request.get:
                    res =  await _httpClient.GetAsync(uri);
                    break;
                case Request.post:
                    res = await _httpClient.PostAsync(uri, new StringContent(JsonData, Encoding.UTF8, "application/json"));
                    break;
                case Request.put:
                    res = await  _httpClient.PutAsync(uri, new StringContent(JsonData, Encoding.UTF8, "application/json"));
                    break;
                case Request.delete:
                    res = await  _httpClient.DeleteAsync(uri);
                    break;
            }
            if(res != null)
            {
                return await res.Content.ReadAsStringAsync();
            }
            return "";
        }

    }
}
