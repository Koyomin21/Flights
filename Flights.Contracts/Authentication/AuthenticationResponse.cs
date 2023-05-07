using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights.Contracts.Authentication;

public record AuthenticationResponse
(
    int Id,
    string Username,
    string Password,
    String Token
);
