using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Test_Task1
{
    [TestClass]
    public class UnitTest1
    {
        #region Initialize

        #endregion

        #region TestMethod1
        [TestMethod, TestCategory("Task1")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(43.34, 43.341, 43.34)]
        [DataRow(-1, 0, -1)]

        public void TestMethod1(double value_1, double value_2, double result)
        {
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
                        Trace.WriteLine($"{lines[i]}");
                    }
                }

                Assert.AreEqual("Die kleinere Zahl", lines_list[0]);
                Assert.AreEqual("Geben Sie die erste Zahl ein:", lines_list[1]);
                Assert.AreEqual("Geben Sie die zweite Zahl ein:", lines_list[2]);
                Assert.AreEqual($"Die kleinere Zahl ist: {result}", lines_list[3]);

            }

        }


        #endregion

        #region TestMethod2
        [TestMethod, TestCategory("Task1")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(0, 0, "Gleicher Wert")]

        public void TestMethod2(double value_1, double value_2, string result)
        {
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
                        Trace.WriteLine($"{lines[i]}");
                    }
                }

                Assert.AreEqual("Die kleinere Zahl", lines_list[0]);
                Assert.AreEqual("Geben Sie die erste Zahl ein:", lines_list[1]);
                Assert.AreEqual("Geben Sie die zweite Zahl ein:", lines_list[2]);
                Assert.AreEqual($"Die kleinere Zahl ist: {result}", lines_list[3]);

            }

        }

        #endregion
    }
}