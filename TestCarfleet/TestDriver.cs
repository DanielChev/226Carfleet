using NUnit.Framework;
using System.Collections.Generic;

namespace Carfleet
{
    public class TestDriver
    {
        #region private attributes
        private string _name = "Einstein";
        private string _firstname = "Albert";
        private string _phonenumber = "+41793456789";
        private string _emailaddress = "ae@relativity.org";
        private List<string> _languages = new List<string>();
        private Driver _driver;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _driver = new Driver(_name, _firstname, _phonenumber, _emailaddress, _languages);
        }

        [Test]
        public void AllProperties_AfterInstantiation_GetCorrectValues()
        {
            //given

            //when

            //then

        }
    }
}