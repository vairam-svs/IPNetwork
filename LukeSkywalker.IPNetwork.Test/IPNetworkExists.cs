using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LukeSkywalker.IPNetwork;
using System.Net;

namespace LukeSkywalker.IPNetwork.Test
{
    [TestClass]
    public class IPNetworkExists
    {
        [TestMethod()]
        public void ParseTest()
        {
            //http://www.subnet-calculator.com/cidr.php
            //IPNetwork mynetwork = new IPNetwork();
            IPNetwork ipnetwork = IPNetwork.Parse("198.169.76.64/26");
            IPAddress ipaddress = IPAddress.Parse("198.169.76.75");
            //198.238.108.200

            bool result = IPNetwork.Contains(ipnetwork, ipaddress);
            bool expected = true;

            Assert.AreEqual(expected, result, "contains");

        }
    }
}
