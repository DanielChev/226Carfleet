﻿namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes

        private Vehicle _vehicle;
        private string _workZone;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string language):base(name, firstname, phonenumber, emailaddress, language)
        {
        }

        public void TakeAVehicule(Vehicle vehicle)
        {
            
        }
        #endregion public methods
    }
}
