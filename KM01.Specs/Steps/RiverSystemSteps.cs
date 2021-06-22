
using TechTalk.SpecFlow;
using FluentAssertions;

namespace KM01
{
    [Binding]
    public class RiverSystemSteps
    {
        private readonly RiverSystem _RiverSystem = new RiverSystem();

        private double _Qs;
        private double _Cs;
        private double _Co;
        private double _Qi;

        [Given(@"Qs is (.*)")]
        public void GivenQsIs(string p0)
        {
            double.TryParse(p0, out double output);
            _RiverSystem.Qs = output;
        }

        [Given(@"Cs is (.*)")]
        public void GivenCsIs(string p0)
        {
            double.TryParse(p0, out double output);
            _RiverSystem.Cs = output;
        }

        [Given(@"Co is (.*)")]
        public void GivenCoIs(string p0)
        {
            double.TryParse(p0, out double output);
            _RiverSystem.Co = output;
        }

        [When(@"river system gets in steady state")]
        public void WhenRiverSystemGetsInSteadyState()
        {
            _RiverSystem.GetsInSteadyState();
            _Qi = _RiverSystem.Qi;
        }


        [Then(@"Qi is (.*)")]
        public void ThenQiIs(string p0)
        {
            double.TryParse(p0, out double output);
            _Qi.Should().Be(output);
        }
    }
}
