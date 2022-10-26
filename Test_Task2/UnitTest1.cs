using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Test_Task2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Task2")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(false, false, 5)]
        [DataRow(false, true, 15)]
        [DataRow(true, false, 18)]
        [DataRow(true, true, 62)]
        public void TestMethod3(bool value_1, bool value_2, int result)
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

            Assert.AreEqual("Herzinfarkt-Risiko-Test", lines_list[0]);
            Assert.AreEqual("Sind Sie übergewichtig?(true/false):", lines_list[1]);
            Assert.AreEqual("Haben Sie häufiger Stress?(true/false):", lines_list[2]);
            Assert.AreEqual($"Ihr Risiko für einen Herzinfarkt liegt bei: {result}%", lines_list[3]);
                                              
        }
    }
}
