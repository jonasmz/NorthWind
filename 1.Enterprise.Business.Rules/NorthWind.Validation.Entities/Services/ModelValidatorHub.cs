namespace NorthWind.Validation.Entities.Services
{
    internal class ModelValidatorHub<ModelType>(
        IEnumerable<IModelValidator<ModelType>> validators
    ) : IModelValidatorHub<ModelType>
    {
        public IEnumerable<ValidationError> Errors { get; private set; }

        public async Task<bool> Validate(ModelType model)
        {
            List<ValidationError> CurrentErrors = new();

            var Validators = validators.Where(v => v.Constraint == ValidationConstraint.AlwaysValidate).ToList();
            Validators.AddRange(Validators.Where(v => v.Constraint == ValidationConstraint.ValidateIfThereAraNoPreviousErrors));

            foreach(var Validator in Validators){
                if(Validator.Constraint == ValidationConstraint.AlwaysValidate || !CurrentErrors.Any()){
                    if(!await Validator.Validate(model)){
                        CurrentErrors.AddRange(Validator.Errors);
                    }
                }
            }

            Errors = CurrentErrors;
            return !Errors.Any();
        }
    }
}