using FizzBuzz.Game;

namespace FizzBuzzTests
{
    public class GameTest
    {
        //[Fact]
        //public void IsExist()
        //{
        //    var gameBoard = new FizzBuzz.Game.FizzBuzzBoard();
        //    var number = 3;
        //    string response = gameBoard.GetWordForNumber(number);
        //}

        FizzBuzzBoard fizzBuzzBoard = new FizzBuzzBoard();

        /*
         * Ben bir oyuncu olarak
         * 3 sayısını verdiğimde
         * Fizz değerini almalıyım.
         */

        [Fact]
        public void When_Send_Three_Return_Fizz()
        {
            var number = 3;
            string actual = fizzBuzzBoard.GetWordForNumber(number);
            Assert.Equal("Fizz", actual);

        }
        [Fact]
        public void When_Send_Five_Return_Buzz()
        {
            var number = 5;
            string actual = fizzBuzzBoard.GetWordForNumber(number);
            Assert.Equal("Buzz", actual);

        }
        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void When_Send_Multiply_three_Return_Fizz(int number)
        {
            string actual = fizzBuzzBoard.GetWordForNumber(number);
            Assert.Equal("Fizz", actual);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void When_Send_Multiply_five_Return_Fizz(int number)
        {
            string actual = fizzBuzzBoard.GetWordForNumber(number);
            Assert.Equal("Buzz", actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void When_Send_Multiply_fifteen_Return_Fizz(int number)
        {
            string actual = fizzBuzzBoard.GetWordForNumber(number);
            Assert.Equal("FizzBuzz", actual);
        }

    }
}