using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    internal class Program_02
    {
        static void Main(string[] args) {
            IntSquareValue squareValue = new IntSquareValue();
            squareValue.SquareValue = 10;

            Console.WriteLine($"calc : {squareValue.SquareValue}");

            while (true) ;
        }
    }

    public class IntSquareValue {
        private int value;
        private int squareValue;

        /// <summary>
        /// パブリックインターフェース
        /// </summary>
        /// <param name="value">数値</param>
        /// <returns>int</returns>
        public int SquareValue {
            get { return CalculateSquare(value); }
            set { this.squareValue = value; }
        }

        /// <summary>
        /// プライベートな実装
        /// </summary>
        /// <param name="value">数値</param>
        /// <returns>int</returns>
        private int CalculateSquare(int value) {
            return (int)Math.Pow(value, 2);//二乗を返す
        }
    }
}
