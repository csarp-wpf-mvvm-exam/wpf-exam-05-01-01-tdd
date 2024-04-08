using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Desktop.Validation.ValidationRules
{
    public class NameValidationRules
    {
        private readonly string _nameToValidate;
        public NameValidationRules(string name)
        {
            _nameToValidate = name;
        }

        public bool IsNameShort => _nameToValidate.Length < 2;
        public bool IsLetterOrDashOrSpace => false;
        public bool IsFirstLetterUppercase => false; 
        public bool IsUpperLetterAfterDash => false;
        public bool IsUpperLetterAfterSpace => false;
    }
}
