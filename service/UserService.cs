
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WpfApp1.models;
using WpfApp1.tool;

namespace WpfApp1.service
{
    
    public class UserService
    {
        private ClientHttp _clientHttp;

        public UserService(ClientHttp clientHttp)
        {
            _clientHttp = clientHttp;
        }

        public async Task<bool> CheckAuth(string account,string password)
        {
            Dictionary<string, string> param = new Dictionary<string, string>
            {
                { "email", account },
                { "password", password }
            };
            var response = await _clientHttp.SetRequestJsonData(param).GetResult(Request.post,"login");
            var res = JObject.Parse(response);
            if ((bool)res["success"])
            {
                Storage.Token = (string)res["access_token"];
                return true;
            }
            return false;
        }
    }
}
