using System;

namespace KM01
{
    public class RiverSystem
    {
        public RiverSystem()
        {
            Ci = 0;
        }

        public double Qs { get; set; }
        public double Cs { get; set; }
        public double Co { get; set; }
        public double Qi { get; set; }
        public double Ci { get; set; }

        public void GetsInSteadyState()
        {
            // Mass Balance
            //double Invariant = Cs * Qs + Ci * Qi;
            GetQi();
        }

        private void GetQi()
        {
            Qi = (Cs - Co) / (Co - Ci) * Qs;
        }
    }
}