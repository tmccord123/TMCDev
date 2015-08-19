using System;
using System.ComponentModel.DataAnnotations;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Class which puts length attribute provided some conditions.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property, Inherited = true)]
    public sealed class StringLengthIfAttribute : StringLengthAttribute
    {

        public String PropertyName { get; private set; }
        public Object DesiredValue { get; private set; }

        public StringLengthIfAttribute(String propertyName, Object desiredvalue, int maxlength)
            :base(maxlength)
        {
            PropertyName = propertyName;
            DesiredValue = desiredvalue;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult retVal = ValidationResult.Success;

            Type type = validationContext.ObjectInstance.GetType();
            Object propertyValue = type.GetProperty(PropertyName).GetValue(validationContext.ObjectInstance, null);

            if (propertyValue.ToString() == DesiredValue.ToString())
            {
                retVal = base.IsValid(value, validationContext);
            }

            return retVal;
        }
    }
}
