using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            var webClient = new WebClient();

            var result = webClient.DownloadString(url);

            return result;

        }

    }
}
