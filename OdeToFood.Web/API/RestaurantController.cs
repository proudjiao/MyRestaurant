﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToFood.Web.API
{
    public class RestaurantController : ApiController
    {
        public string Get()
        {
            return "Hellow World";  //https://localhost:44391/api/restaurant would render this message
        }
    }
}
