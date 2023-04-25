using FluentValidation;
using iTicketAz.BLL.DTOs.UserDTOs;

namespace iTicketAz.BLL.DTOs.Validators.User
{
    public class AddValidator : AbstractValidator<UserToAddDto>
    {
        public AddValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Please provide a name.");
            RuleFor(x => x.Surname)
                .NotEmpty()
                .WithMessage("Please provide a surname.");
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Please provide an email address.")
                .EmailAddress()
                .WithMessage("Please provide a valid email address.")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|org|edu|net)$")
                .WithMessage("Email must has '@' caharacter and ends with .com, .org, .edu, or .net");
            RuleFor(x => x.Phone)
            .NotEmpty()
            .WithMessage("Please provide a phone number.")
            .Matches(@"^\+\d{3}[\s.-]?\d{2}[\s.-]?\d{3}[\s.-]?\d{2}[\s.-]?\d{2}$")
            .WithMessage("Please provide a valid phone number.");
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Please provide a password.")
                .MinimumLength(8)
                .WithMessage("Your password must be at least 8 characters long.")
                .MaximumLength(50)
                .WithMessage("Your password must be less than 50 characters long.")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")
                .WithMessage("Your password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.");
        }
    }
}
