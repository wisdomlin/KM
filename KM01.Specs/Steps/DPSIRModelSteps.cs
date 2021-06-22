using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace KM01
{
    [Binding]
    public class DPSIRModelSteps
    {
        static readonly Drivers _Drivers = new Drivers();
        static readonly Pressures _Pressures = new Pressures();
        static readonly States _States = new States();
        static readonly Impacts _Impacts = new Impacts();
        static readonly Responses _Responses = new Responses();

        private readonly DPSIRModel _DPSIRModel = new DPSIRModel(
            drivers: _Drivers, pressures: _Pressures, states: _States, impacts: _Impacts, responses: _Responses);

        [Given(@"Drivers, Pressures, States, Impacts, and Responses have random indicator value initially")]
        public void GivenDriversPressuresStateImpactsAndResponsesHaveRandomIndicatorValueInitially()
        {
            _Drivers.RandomInitializeIndicatorValue();
            _Pressures.RandomInitializeIndicatorValue();
            _States.RandomInitializeIndicatorValue();
            _Impacts.RandomInitializeIndicatorValue();
            _Responses.RandomInitializeIndicatorValue();
        }

        [Given(@"Drivers, Pressures, States, Impacts, and Responses have random relationships initially")]
        public void GivenDriversPressuresStateImpactsAndResponsesHaveRandomRelationshipsInitially()
        {
            _Drivers.RandomInitializeRelationship();
            _Pressures.RandomInitializeRelationship();
            _States.RandomInitializeRelationship();
            _Impacts.RandomInitializeRelationship();
            _Responses.RandomInitializeRelationship();
        }

        [When(@"Responses search and decide")]
        public void WhenResponsesSearchAndDecide()
        {
            _Responses.SearchAndDecide();
        }

        [Then(@"the overall benefit of chosen indicator value should be greater than those of others")]
        public void ThenTheOverallBenefitOfChosenIndicatorValueShouldBeGreaterThanThoseOfOthers()
        {
            int ChosenIndicatorValue = _Responses.ChosenIndicatorValue;
            int Optimal = _DPSIRModel.OverallBenefit(ChosenIndicatorValue);

            foreach (int ThoseOfOthers in _Responses.DecisionSpace)
            {
                if (ThoseOfOthers == ChosenIndicatorValue)
                    continue;
                int LessOptimal = _DPSIRModel.OverallBenefit(ThoseOfOthers);
                Optimal.Should().BeGreaterThan(LessOptimal);
            }
        }
    }
}
