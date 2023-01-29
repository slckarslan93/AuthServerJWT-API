using AuthServer.Core.Dtos;
using FluentValidation;

namespace AuthServerAPI.Validation
{
    public class CreateUserDtoValidation:AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidation()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Email is wrong");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is Required");
        }
    }
}
