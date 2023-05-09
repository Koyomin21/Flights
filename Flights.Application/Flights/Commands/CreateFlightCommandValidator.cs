using Flights.Application.Flights.Common;
using Flights.Domain.Enums;
using FluentValidation;
using MediatR;

namespace Flights.Application.Flights.Commands;

public class CreateFlightCommandValidator : AbstractValidator<CreateFlightCommand>
{
    public CreateFlightCommandValidator()
    {
        RuleFor(f => f.Origin).NotEmpty();
        RuleFor(f => f.Destination).NotEmpty();
        RuleFor(f => f.Departure).NotEmpty();
        RuleFor(f => f.Arrival).NotEmpty();
        RuleFor(f => f.Status)
        .NotEmpty()
        .Must(s => Enum.GetNames(typeof(FlightStatus)).Contains(s))
        .WithMessage("Invalid Status");
        
    }
}