using System;
using Xunit;

namespace SuperCodigo.TestesUnidade
{
    public class OperacoesTeste
    {
        public Operacoes _operacoes;
      
        public OperacoesTeste()
        {
            // arrange
            _operacoes = new Operacoes();
        }


        //Testes ObterPosicaoCaractere
        [Fact]
        public void ObterPosicaoCaractereTeste()
        {
            // act and assert
            Assert.Equal(1, _operacoes.ObterPosicaoCaractere("ABCDEF", "A"));
        }

        [Fact]
        public void ObterPosicaoCaractereTesteZero()
        {
            // act
            var exception = Assert.Throws<ArgumentException>(() => _operacoes.ObterPosicaoCaractere("", "a"));

            // assert
            Assert.Equal(ConstantesOperacoes.CADEIA_CARACTERES_CADEIA_INVALIDA, exception.Message);
        }

        [Fact]
        public void ObterPosicaoCaractereTesteCaractereInvalido()
        {
            // act
            var exception = Assert.Throws<ArgumentException>(() => _operacoes.ObterPosicaoCaractere("ABCDEF", "aa"));

            // assert
            Assert.Equal(ConstantesOperacoes.CADEIA_CARACTERES_CARACTERE_INVALIDO, exception.Message);
        }

        [Fact]
        public void ObterPosicaoCaractereTesteNaoEncontrado()
        {
            // act and assert
            Assert.Equal(-1, _operacoes.ObterPosicaoCaractere("ABCDEF", "G"));
        }



        //Testes ObterElementoFibonnaci

        [Fact]
        public void ObterElementoFibonnaciTeste()
        {
            // act and assert
            Assert.Equal(13, _operacoes.ObterElementoFibonnaci(7));
        }

        [Fact]
        public void ObterElementoFibonnaciDois()
        {
            // act and assert
            Assert.Equal(1, _operacoes.ObterElementoFibonnaci(2));
        }

        [Fact]
        public void ObterElementoFibonnaciTesteZero()
        {
            // act
            var exception = Assert.Throws<ArgumentException>(() => _operacoes.ObterElementoFibonnaci(0));

            // assert
            Assert.Equal(ConstantesOperacoes.FIBONNACI_MAIOR_QUE_ZERO, exception.Message);
        }


        //Testes Triângulos
        [Fact]
        public void DeterminarTipoTrianguloTesteZero()
        {
            // act and assert
            Assert.Equal("INEXISTENTE", _operacoes.DeterminarTipoTriangulo(0,0,0));
        }

        [Fact]
        public void DeterminarTipoTrianguloTesteMedidasExageradas()
        {
            // act and assert
            Assert.Equal("INEXISTENTE", _operacoes.DeterminarTipoTriangulo(2, 5, 12));
        }

        [Fact]
        public void DeterminarTipoTrianguloTesteIsoscelesAB()
        {
            // act and assert
            Assert.Equal("ISOSCELES", _operacoes.DeterminarTipoTriangulo(5, 5, 3));
        }


        [Fact]
        public void DeterminarTipoTrianguloTesteIsoscelesBC()
        {
            // act and assert
            Assert.Equal("ISOSCELES", _operacoes.DeterminarTipoTriangulo(5, 4, 4));
        }

        [Fact]
        public void DeterminarTipoTrianguloTesteEquilatero()
        {
            // act and assert
            Assert.Equal("EQUILATERO", _operacoes.DeterminarTipoTriangulo(5, 5, 5));
        }

        [Fact]
        public void DeterminarTipoTrianguloTesteEscaleno()
        {
            // act and assert
            Assert.Equal("ESCALENO", _operacoes.DeterminarTipoTriangulo(5, 4, 3));
        }
    }
}