using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flights.Domain.Common.Models;

namespace Flights.Domain.Entities;

public class Role : Entity
{
    public string? Code { get; set; }
}
