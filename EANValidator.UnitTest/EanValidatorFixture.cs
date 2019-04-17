using EANValidator.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EANValidator.UnitTest
{
    public class EanValidatorFixture : IDisposable
    {
        public IEanValidator EanValidator { get; private set; }

        public EanValidatorFixture()
        {
            EanValidator = new EanValidator();
        }

        public void Dispose()
        {
            EanValidator = null;
        }
    }
}
