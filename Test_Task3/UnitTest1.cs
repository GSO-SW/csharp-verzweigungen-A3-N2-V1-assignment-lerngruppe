using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Test_Task3
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod, TestCategory("Task3")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(2,     5,      1, "7")]
        [DataRow(-2,    5,      1, "3")]
        [DataRow(-1,    -5,     2, "4")]
        [DataRow(-1.5,  4,      3, "-6")]
        [DataRow(-1,    -5,     3, "5")]
        [DataRow(0,     10.23,  4, "0")]
        [DataRow(0,     0,      4, "NaN")]
        [DataRow(10,    2.5,    4, "4")]
        [DataRow(2,     2,      5, "4")]
        [DataRow(-1,    0,      5, "1")]



        public void TestMethod1(double value_1, double value_2, int choice, string result)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);


            var textReader = new StringReader(@$"{value_1}
{value_2}
{choice}");

            Console.SetIn(textReader);

            // Act
            Aufgabe_3.Aufgabe3();

            // Assert

            List<string> lines_list_check = new List<string> { $"Ihr Ergebnis ist: {result}" };

            AssertTest(writer, lines_list_check);

        }


        public static void AssertTest(StringWriter writer, List<string> lines_list_check)
        {

            // Assert

            var sb = writer.GetStringBuilder();
            var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

            List<string> lines_list = new List<string>();

            //Bedingung nötig da 'Enviroment.NewLine' in Git Actions nicht funktioniert.
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    lines_list.Add(lines[i]);
                    Debug.WriteLine($"{lines[i]}");
                }
            }





            lines_list = lines_list.Intersect(lines_list_check).ToList();


            for (int i = 0; i < lines_list_check.Count; i++)
            {

                try
                {
                    if (lines_list[i] != lines_list_check[i]) Trace.WriteLine($"\nFehler: '{lines_list_check[i]}' nicht gefunden");
                    Assert.AreEqual(lines_list[i], lines_list_check[i]);
                }
                catch
                {
                    Trace.WriteLine($"Fehler: Zeile fehlt");
                    Trace.WriteLine($"{lines_list_check[i]}");
                    Assert.Fail(); ;

                }

            }
        }





        [TestMethod, TestCategory("Task3")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(-12, 0, 4)]
        [DataRow(2.2, 0, 4)]
        [DataRow(1.5, 2, 5)]
        [DataRow(-1.5, 3.5, 3)]
        public void TestMethod2(double value_1, double value_2, int choice)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);


            var textReader = new StringReader(@$"{value_1}
{value_2}
{choice}");

            Console.SetIn(textReader);

            // Act
            Aufgabe_3.Aufgabe3();

            // Assert

            string result;
            if(choice==4)result= (value_1/value_2).ToString();   
            else if(choice==3)result=(value_1*value_2).ToString();
            else result= Math.Pow(value_1,value_2).ToString();  

            List<string> lines_list_check = new List<string> { $"Ihr Ergebnis ist: {result}" };

            var sb = writer.GetStringBuilder();
            var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

            List<string> lines_list = new List<string>();

            //Bedingung nötig da 'Enviroment.NewLine' in Git Actions nicht funktioniert.
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    lines_list.Add(lines[i]);
                    Debug.WriteLine($"{lines[i]}");
                }
            }





            lines_list = lines_list.Intersect(lines_list_check).ToList();


            for (int i = 0; i < lines_list_check.Count; i++)
            {

                try
                {
                    if (lines_list[i] != lines_list_check[i]) Trace.WriteLine($"\nFehler: '{lines_list_check[i]}' nicht gefunden");
                    Assert.AreEqual(lines_list[i], lines_list_check[i]);
                }
                catch
                {
                    Trace.WriteLine($"Fehler: Zeile fehlt");
                    Trace.WriteLine($"{lines_list_check[i]}");
                    Assert.Fail(); ;

                }

            }
        }

    }
}