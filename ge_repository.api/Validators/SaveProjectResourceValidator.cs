using FluentValidation;
using ge_repository.api.resources;

namespace ge_repository.api.validations
{
    public class SaveProjectResourceValidator : AbstractValidator<SaveProjectResource>
    {
        public SaveProjectResourceValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}