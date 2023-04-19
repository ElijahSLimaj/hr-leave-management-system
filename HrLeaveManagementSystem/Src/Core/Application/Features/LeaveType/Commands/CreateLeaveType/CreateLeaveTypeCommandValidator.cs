using FluentValidation;

namespace HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommandValidator : AbstractValidator<CreateLeaveTypeCommand>
{
        public ILeaveTypeRepository _leaveTypeRepository { get; }


    public CreateLeaveTypeCommandValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        // create validation rules here
        RuleFor(p => p.Name)
            .NotEmpty()
            .WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(70)
            .WithMessage("{PopertyName} must be fewer than 70 characters");

        RuleFor(p => p.DefaultDays)
            .LessThan(100)
            .WithMessage("{PropertName} cannot exceed 100")
            .GreaterThan(1)
            .WithMessage("{PopertyName} cannot be less than 1");

        RuleFor(p => p)
            .MustAsync(LeaveTypeNameUnique)
            .WithMessage("LeaveType already exists");

        // asssign injected dependencyies to properties here
        _leaveTypeRepository = leaveTypeRepository;
    }
    private Task<bool> LeaveTypeNameUnique(CreateLeaveTypeCommand createLeaveTypeCommand, CancellationToken cancellationToken)
    {
        // tells the validator whether a type is unique or not
        return _leaveTypeRepository.IsLeaveTypeUnique(createLeaveTypeCommand.Name);
    }
}
