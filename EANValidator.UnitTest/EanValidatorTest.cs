using System;
using Xunit;

namespace EANValidator.UnitTest
{
    public class EanValidatorTest : IClassFixture<EanValidatorFixture>
    {
        readonly EanValidatorFixture _eanValidatorFixture;

        public EanValidatorTest(EanValidatorFixture fixture)
        {
            _eanValidatorFixture = fixture;
        }

        [Fact]
        public void Valid13DigitEan()
        {
            Assert.True(_eanValidatorFixture.EanValidator.Validate("0040232916847"));
        }

        [Fact]
        public void Valid12DigitEan()
        {
            Assert.True(_eanValidatorFixture.EanValidator.Validate("040232916847"));
        }

        [Fact]
        public void InvalidEan()
        {
            Assert.False(_eanValidatorFixture.EanValidator.Validate("140232916847"));
        }

        [Fact]
        public void InvalidEmptyEan()
        {
            Assert.False(_eanValidatorFixture.EanValidator.Validate(""));
        }

        [Fact]
        public void InvalidNonNumericEan()
        {
            Assert.False(_eanValidatorFixture.EanValidator.Validate("ABCDEFGHIJKLM"));
        }
    }
}
