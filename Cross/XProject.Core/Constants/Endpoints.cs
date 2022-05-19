using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XProject.Core.Constants
{
    public class Endpoints
    {
        public static class HomeEndpoint
        {
            public const string Area = "";

            public const string BaseEndpoint = "~/" + Area;
            public const string create = "~/" + Area+ "/create-getLoai";
            public const string retrieve = "~/" + Area + "/retrieve-getLoai";
            public const string update = "~/" + Area + "/update-getLoai";
            public const string delete = "~/" + Area + "/delete-getLoai";
            public const string getall = "~/" + Area + "/get-getLoai";


        }
    }
}
