using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SonarCloudDemo.Infrastructure
{
    public class BadClass
    {
        public string SomeMethod()
        {
            var methodResult = ShouldBePrivate();
            return methodResult;
        }

        public string ShouldBePrivate()
        {
            var list = new List<object>();

            var url = "https://www.google.se";

            var client = new HttpClient();

            var result = client.GetAsync(url).Result;

            return result.Content.ReadAsStringAsync().Result;

        }

    }
}
