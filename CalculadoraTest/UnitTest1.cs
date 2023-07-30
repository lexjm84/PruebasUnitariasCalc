using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasUnitariasCalc;
namespace CalculadoraTest
{
        [TestClass]
        public class UnitTest1
        {
            [DataRow(4, 4, 8)]
            [DataRow(4, 0, 4)]
            [DataRow(0, 0, 0)]
            [DataRow(-1, -3, -4)]
            [DataRow(4, -1, 8)]
            [TestMethod]
            public void Suma_retornaValor(double a, double b, double esperado)
            {
                /* //Arrange
                  DataRow*/

                //Act
                double actual = clsCalculadora.suma(a, b);


                //Assert
                Assert.AreEqual(esperado, actual);
            }
            [DataRow(4, 4, 0)]
            [DataRow(4, 0, 4)]
            [DataRow(1, 4, -3)]
            [DataRow(-1, -4, 3)]
            [DataRow(4, -1, 55)]
            [TestMethod]
            public void resta_retornaValor(double a, double b, double esperado)
            {
                /* //Arrange
              DataRow*/


                //Act
                double actual = clsCalculadora.resta(a, b);


                //Assert
                Assert.AreEqual(esperado, actual);
            }


            [DataRow(4, 4, 1)]
            [DataRow(4, 0, -1)]
            [DataRow(0, 0, 0)]
            [DataRow(-1, -4, 0.25)]
            [DataRow(4, -1, -41)]
            [TestMethod]
            public void div_retornaValor(double a, double b, double esperado)
            {
                /* //Arrange
                  DataRow*/


                //Act
                double actual = clsCalculadora.division(a, b);


                //Assert
                Assert.AreEqual(esperado, actual);
            }

            [DataRow(4, 4, 16)]
            [DataRow(4, 0, 0)]
            [DataRow(1, 1, 1)]
            [DataRow(-1, -4, 4)]
            [DataRow(4, -1, -4)]
            [TestMethod]
            public void mult_retornaValor(double a, double b, double esperado)
            {
                /* //Arrange
              DataRow*/


                //Act
                double actual = clsCalculadora.multiplicacion(a, b);


                //Assert
                Assert.AreEqual(esperado, actual);
            }
        }
    }
