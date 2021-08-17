
using Microsoft.AspNetCore.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermercadoWeb.Data
{
    public class NameIdRouteConstraint:RegexRouteConstraint
    {
        public NameIdRouteConstraint() : base(@"([A-Za-z]{3})([0-9]{3})$")
        {
        }
    }
}
