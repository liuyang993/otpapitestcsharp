using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otpapitestcsharpnew
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://otpapi.worldhubcom.com/api/mcotp/send");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Basic writeyourauthcodehere");
            var body = @"{
                " + "\n" +
                            @"  ""to"": ""62967888000"",
                " + "\n" +
                            @"  ""length"": 6,
                " + "\n" +
                            @"  ""tag"": ""compaign1"",
                " + "\n" +
                            @"  ""timeout"": 300,
                " + "\n" +
                            @"  ""notifyurl"": """"
                " + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);




        }
    }
}
