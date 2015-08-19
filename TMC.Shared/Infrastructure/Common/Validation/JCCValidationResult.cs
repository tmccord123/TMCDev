using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TMC.Shared 
{
    public class JCCValidationResult
    {
        public IList<JCCValidationFailure> Errors { get; private set; }

        public bool IsValid
        {
            get { return Errors == null || Errors.Count == 0; }
        }

        public JCCValidationResult(IList<JCCValidationFailure> failures)
        {
            Errors = failures;
        }

        public JCCValidationResult()
        {
            Errors = new List<JCCValidationFailure>();
        }
    }
}