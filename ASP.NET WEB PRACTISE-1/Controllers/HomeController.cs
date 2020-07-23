using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_WEB_PRACTISE_1.NewFolder
{

    public class HomeController : Controller
    {
        public string index()
        {
            return "Hello gaurav";
        }
    }
}
