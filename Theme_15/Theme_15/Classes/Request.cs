using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_15.Classes
{
    class Request
    {
        private string[] requests;
        private string previousRequest;

        public Request()
        {
            this.requests = new string[3]
            {
                "eat",
                "play",
                "sleep"
            };

            this.previousRequest = string.Empty;
        }

        public string generateRequest()
        {
            Random rand = new Random();
            string currentRequest = string.Empty;

            while (true)
            {
                currentRequest = this.requests[rand.Next(0, 2)];
                if (currentRequest != this.previousRequest)
                {
                    break;
                }
            }

            this.previousRequest = currentRequest;
            return currentRequest;
        }
    }
}
