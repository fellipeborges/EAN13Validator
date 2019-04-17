using System;
using System.Collections.Generic;
using System.Text;

namespace EANValidator.Core
{
    public interface IEanValidator
    {
        bool Validate(string code);
    }
}
