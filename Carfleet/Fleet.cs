using System;
using System.Collections.Generic;

namespace Carfleet
{
    public class Fleet
    {
        #region private attributes
        private string name;
        private string street;
        private string city;
        private string phonenumber;
        private string emailaddress;
        #endregion private attributes

        #region public methods
        public Fleet(string name, string street, string city, string phonenumber, string emailaddress)
        {
        }

        public int DistanceAverageByDriver(List<Car> cars)
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
