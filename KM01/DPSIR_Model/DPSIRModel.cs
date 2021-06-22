using System;

namespace KM01
{
    public class DPSIRModel
    {
        private Drivers drivers;
        private Pressures pressures;
        private States states;
        private Impacts impacts;
        private Responses responses;

        public DPSIRModel(Drivers drivers, Pressures pressures, States states, Impacts impacts, Responses responses)
        {
            this.drivers = drivers;
            this.pressures = pressures;
            this.states = states;
            this.impacts = impacts;
            this.responses = responses;
        }

        public int OverallBenefit(int chosenIndicatorValue)
        {
            throw new NotImplementedException();
        }
    }
}
