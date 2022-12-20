using NetTools;     // Use third party library
using System;
using System.Collections.Generic;

namespace IPFiltering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPAddressRange> ipList = new List<IPAddressRange>();

            ipList.Add(IPAddressRange.Parse("192.168.0.1 - 192.168.0.10"));
            ipList.Add(IPAddressRange.Parse("192.168.0.30"));
            ipList.Add(IPAddressRange.Parse("192.168.0.50/10"));

            Console.WriteLine("Please enter a valid Ipv4 address:");
            var ipToFind = Console.ReadLine();

            bool ipFound = false;
            foreach (IPAddressRange item in ipList)
            {
                if (item.Contains(IPAddressRange.Parse(ipToFind)))
                {
                    Console.WriteLine("IP is in the List!");
                    ipFound = true;
                    break;
                }
            }

            if (!ipFound)
            {
                Console.WriteLine("IP is not in the list!");
            }
        }
    }
}
