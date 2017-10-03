using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp
{
    public static class GlobalVariables
    {
        public static List<Game> Games { get; set; } = new List<Game>();
    }
}