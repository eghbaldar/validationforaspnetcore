using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace test50.Domain.Commons.Validators
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class UserValidatorsAttribute : ValidationAttribute, IClientModelValidator
    {
        public string NAME { get; private set; }
        public UserValidatorsAttribute(string name)
        {
            NAME = name;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var _value = validationContext.ObjectInstance.GetType().GetProperty(NAME);
            var _valueData = _value.GetValue(validationContext.ObjectInstance, null);

            if (_valueData.ToString().ToUpper() == "IRAN" ) {
                return new ValidationResult(FormatErrorMessage("NO IRAN"));
            }
            return ValidationResult.Success;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            MergeAttribute(context.Attributes, "data-val", "true");
            var errorMessage = FormatErrorMessage(context.ModelMetadata.GetDisplayName());
            MergeAttribute(context.Attributes, "data-val-userValidators", errorMessage);
        }
        private bool MergeAttribute(IDictionary<string, string> attributes, string key, string value)
        {
            if (attributes.ContainsKey(key))
            {
                return false;
            }
            attributes.Add(key, value);
            return true;
        }
    }
}
