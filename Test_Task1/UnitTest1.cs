using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Test_Task1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod, TestCategory("Task1")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Kander")]
        [DataRow(0.0, 0.0, "Gleicher Wert")]
        public void Test_InOut1(double value_1, double value_2, string result)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);


            var textReader = new StringReader(@$"{value_1}
{value_2}");

            Console.SetIn(textReader);

            // Act
            Aufgabe_1.Aufgabe1();

            // Assert

            List<string> lines_list_check = new List<string> { $"Die kleinere Zahl ist: {result}" };

            AssertTest(writer, lines_list_check);

        }

        [TestMethod, TestCategory("Task1")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Kander")]
        [DataRow(1.3, -1.2, -1.2)]
        [DataRow(-1.3, 1.2, -1.3)]
        public void Test_InOut2(double value_1, double value_2, double result)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);


            var textReader = new StringReader(@$"{value_1}
{value_2}");

            Console.SetIn(textReader);

            // Act
            Aufgabe_1.Aufgabe1();

            // Assert

            List<string> lines_list_check = new List<string> { $"Die kleinere Zahl ist: {result}" };

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

    }
}