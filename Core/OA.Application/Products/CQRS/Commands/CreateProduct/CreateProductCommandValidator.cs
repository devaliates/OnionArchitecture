using FluentValidation;

namespace OA.Application.Products.CQRS.Commands.CreateProduct;

public class CreateProductCommandValidator
    : AbstractValidator<CreateProductCommandRequest>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotNull()
            .WithMessage("Name boş olamaz!")
            .MaximumLength(20)
            .MinimumLength(3)
            .WithMessage("Name değeri 3 ile 20 karakter arasında olmalıdır!");
    }
}
