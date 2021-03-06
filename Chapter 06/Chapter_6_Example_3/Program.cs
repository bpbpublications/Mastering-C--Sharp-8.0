﻿using System;
using System.Xml.Linq;

namespace Chapter_6_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlData = @"<Authors>
                       <Author>Joydip Kanjilal</Author>
                       <Author>Steve Smith</Author>
                       <Author>Anand Naraswamy</Author>
                       <Author>Yeshwant Kanetkar</Author>
                       </Authors>";

            XDocument xDocument = new XDocument();
            xDocument = XDocument.Parse(xmlData);

            var result = xDocument.Element("Authors").Descendants();

            foreach (XElement element in result)
            {
                Console.WriteLine(element.Value);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
