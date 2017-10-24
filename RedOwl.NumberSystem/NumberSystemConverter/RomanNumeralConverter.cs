using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystemConverter
{
    public class RomanNumeralConverter
    {
        #region numeral types
        enum RomanNumeralsType
        {
            M = 1_000,
            D = 500,
            C = 100,
            L = 50,
            X = 10,
            V = 5,
            I = 1
        }

        internal class RomanNumeralPair
        {
            public int NumericValue { get; set; }

            public string RomanNumeralRepresentation { get; set; }
        }
        #endregion

        private readonly List<RomanNumeralPair> romanNumeralList;

        /// <summary>
        /// Ctor
        /// </summary>
        public RomanNumeralConverter()
        {
            romanNumeralList = new List<RomanNumeralPair>()
            {
                new RomanNumeralPair()
                {
                    NumericValue = Convert.ToInt32(RomanNumeralsType.M),
                    RomanNumeralRepresentation = RomanNumeralsType.M.ToString()
                },
                new RomanNumeralPair()
                {
                    NumericValue = Convert.ToInt32(RomanNumeralsType.D),
                    RomanNumeralRepresentation = RomanNumeralsType.D.ToString()
                },
                new RomanNumeralPair()
                {
                    NumericValue = Convert.ToInt32(RomanNumeralsType.C),
                    RomanNumeralRepresentation = RomanNumeralsType.C.ToString()
                },
                new RomanNumeralPair()
                {
                    NumericValue = Convert.ToInt32(RomanNumeralsType.L),
                    RomanNumeralRepresentation = RomanNumeralsType.L.ToString()
                },
                new RomanNumeralPair()
                {
                    NumericValue = Convert.ToInt32(RomanNumeralsType.X),
                    RomanNumeralRepresentation = RomanNumeralsType.X.ToString()
                },
                new RomanNumeralPair()
                {
                    NumericValue = Convert.ToInt32(RomanNumeralsType.V),
                    RomanNumeralRepresentation = RomanNumeralsType.V.ToString()
                },
                new RomanNumeralPair()
                {
                    NumericValue = Convert.ToInt32(RomanNumeralsType.I),
                    RomanNumeralRepresentation = RomanNumeralsType.I.ToString()
                }
            };
        }

        /// <summary>
        /// Convert a numeric value into a roman numeral
        /// </summary>
        /// <param name="num">Numeric value</param>
        /// <returns>The associated roman value</returns>
        public string ConvertRomanNumeral(int num)
        {
            if (num < 1 || num > 3_000)
                throw new IndexOutOfRangeException("The number supplied is out of the expected range (1-3000). ");

            var builder = new StringBuilder();

            foreach(var currentPair in romanNumeralList)
            {
                while (num >= currentPair.NumericValue)
                {
                    builder.Append(currentPair.RomanNumeralRepresentation);
                    num -= currentPair.NumericValue;
                }
            }

            return builder.ToString();
        }
    }
}