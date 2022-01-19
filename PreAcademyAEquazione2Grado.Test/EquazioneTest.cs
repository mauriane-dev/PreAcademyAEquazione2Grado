using PreAcademyAEquazione2Grado.Core;
using Xunit;

namespace PreAcademyAEquazione2Grado.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            //ARRANGE: predisposizione/prerequisiti del test
            Equation equazione = new Equation();
            double a = 1;
            double b = -3;
            double c = 2;

            //ACT: chiamata alla funzionalit� da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //ASSERT: valutazione del risultato atteso vs risultato restituito
            Assert.True(risultato.Length == 2);
            Assert.Equal(1, risultato[0]); //in alternativa Assert.True(risultato[0] == 1);
            Assert.Equal(2, risultato[1]); //in alternativa Assert.True(risultato[1] == 2);
        }
        [Fact]
        public void Test2()
        {
            //ARRANGE: predisposizione/prerequisiti del test
            Equation equazione = new Equation();
            double a = 1;
            double b = -5;
            double c = 6;

            //ACT: chiamata alla funzionalit� da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //ASSERT: valutazione del risultato atteso vs risultato restituito
            Assert.True(risultato.Length == 2);
            Assert.Equal(2, risultato[0]); //in alternativa Assert.True(risultato[0] == 2);
            Assert.Equal(3, risultato[1]); //in alternativa Assert.True(risultato[1] == 3);
        }

        [Fact]
        public void Test3()
        {
            //ARRANGE: predisposizione/prerequisiti del test
            Equation equazione = new Equation();
            double a = 1;
            double b = 2;
            double c = 1;

            //ACT: chiamata alla funzionalit� da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //ASSERT: valutazione del risultato atteso vs risultato restituito
            Assert.True(risultato.Length == 1);
            Assert.Equal(-1, risultato[0]); //in alternativa Assert.True(risultato[0] == -1);
           
        }
        [Fact]
        public void Test4()
        {
            //ARRANGE: predisposizione/prerequisiti del test
            Equation equazione = new Equation();
            double a = 1;
            double b = -3;
            double c = 10;

            //ACT: chiamata alla funzionalit� da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //ASSERT: valutazione del risultato atteso vs risultato restituito
            Assert.Null(risultato);
        }
    }
}