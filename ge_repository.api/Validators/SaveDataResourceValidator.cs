using FluentValidation;
using ge_repository.api.resources;

namespace ge_repository.api.validations
{
    public class SaveDataResourceValidator : AbstractValidator<SaveDataResource>
    {
        public SaveDataResourceValidator()
        {
            RuleFor(m => m.filename)
                .NotEmpty()
                .MaximumLength(50);
            
            RuleFor(m => m.ProjectId)
                .NotEmpty()
                .WithMessage("'Data Id' must not be empty.");
        }
    }
}