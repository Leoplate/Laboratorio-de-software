using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit;
namespace TestProject1
{
    
    
    public class Pruebas
    {
        [Fact]
        public void PruebaSumar()
        {
            //Arrange
               primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico P = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();
            //Act
            int primer = 1;
            int seg = 1;
            int resu = P.Sumar(primer, seg);

            //Assert
            Assert.Equal(2, resu);

        }

        [Fact]
        public void PruebaMayor()
        {
            //Arrange
            primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico P = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();
            //Act
            int primer = 1;
            int seg = 1;
            int resu = P.CalcularMayor(primer, seg);

            //Assert
            Assert.Equal(1, resu);

        }


        [Fact]
        public void PruebaDividir()
        {
            //Arrange
            primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico P = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();
            //Act
            int primer = 1;
            int seg = 1;
            int resu = P.Dividir(primer, seg);

            //Assert
            Assert.Equal(1, resu);

        }


        [Fact]
        public void PruebaNegativo()
        {
            //Arrange
            primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico P = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();
            //Act
            int primer = -5;
            int seg = -6;
            int resu1 = P.CalcularMayor(primer, seg);
            bool resu = P.EsNegativo();

            //Assert
            Assert.Equal(true, resu);

        }

    }
}
