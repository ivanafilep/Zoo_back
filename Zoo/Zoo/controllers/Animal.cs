using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    internal class Animal
    {

        public string healthCheck () {
            return ("OK");
        }
    }
}
