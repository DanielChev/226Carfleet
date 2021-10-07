using System;

namespace Carfleet{
    public class Car
    {
        #region private attributes
        private string registration;
        private string brand;
        private string model;
        private string chassisNumber;
        private int odometerInitialValue;
        private int odometerCurrentValue;
        #endregion private attributes

        #region public methods
        public Car(string registration, string brand, string model, string chassisNumber, int odometerInitialValue)
        {
            this.odometerInitialValue = odometerInitialValue;
        }

        public int Distance()
        {
            return this.odometerCurrentValue - this.odometerInitialValue;
        }

        public int OdometerCurrentValue
        {
            set
            {
                this.odometerCurrentValue = value;
            }
        }
        #endregion public methods
    }
}
