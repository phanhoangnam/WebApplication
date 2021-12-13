using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Dependency
{
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}
