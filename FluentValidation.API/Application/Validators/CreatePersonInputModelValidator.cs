using FluentValidation.API.Application.InputModels;

namespace FluentValidation.API.Application.Validators
{
    public class CreatePersonInputModelValidator : AbstractValidator<CreatePersonInputModel>
    {
        public CreatePersonInputModelValidator()
        {
            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome é obrigatório");

            RuleFor(p => p.Age)
                .GreaterThan(18)
                .WithMessage("Não é permitido cadastro para menores de 18 anos");
        }
    }
}
