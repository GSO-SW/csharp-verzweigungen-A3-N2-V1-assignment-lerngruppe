using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Test_Task2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod, TestCategory("Task2")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Kander")]
        [DataRow(false, false, 5)]
        [DataRow(false, true, 15)]
        [DataRow(true, false, 18)]
        [DataRow(true, true, 62)]
        public void Test_InOut1(bool value_1, bool value_2, int result)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);


            var textReader = new StringReader(@$"{value_1}
{value_2}");

            Console.SetIn(textReader);

            // Act
            Aufgabe_2.Aufgabe2();

            // Assert

            List<string> lines_list_check = new List<string> { $"Ihr Risiko für einen Herzinfarkt liegt bei: {result}%" };

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
