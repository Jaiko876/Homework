using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
// Молоствов Игорь
namespace Homework3
{    //Описать класс дробей
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int n, int d)
        {
            if (d == 0)
            {
                throw new ArgumentException("Знаменатель не может равняться 0");
            }
            numerator = n;
            denominator = d;
        }

        public String GetFraction()
        {
            return $"{numerator}/{denominator}";
        }

        public static Fraction Sum(Fraction a, Fraction b)
        {
            int numerator = 0;
            int denominator = 0;
            int multiple;

            if (a.denominator == b.denominator)
            {
                numerator = a.numerator + b.numerator;
                denominator = a.denominator;
            }
            else
            {
                multiple = GetLeastCommonMultiple(a.denominator, b.denominator);
                int additionalMultiplierFirst = multiple / a.denominator;
                int additionalMultiplierSecond = multiple / b.denominator;
                numerator = a.numerator * additionalMultiplierFirst + b.numerator * additionalMultiplierSecond;
                denominator = a.denominator * additionalMultiplierFirst;
            }

            return new Fraction(numerator, denominator);
        }

        public static Fraction Diff(Fraction a, Fraction b)
        {
            int numerator = 0;
            int denominator = 0;
            int multiple;

            if (a.denominator == b.denominator)
            {
                numerator = a.numerator - b.numerator;
                denominator = a.denominator;
            }
            else
            {
                multiple = GetLeastCommonMultiple(a.denominator, b.denominator);
                int additionalMultiplierFirst = multiple / a.denominator;
                int additionalMultiplierSecond = multiple / b.denominator;
                numerator = a.numerator * additionalMultiplierFirst - b.numerator * additionalMultiplierSecond;
                denominator = a.denominator * additionalMultiplierFirst;
            }

            return new Fraction(numerator, denominator);
        }

        public static Fraction Multiplication(Fraction a, Fraction b)
        {
            int numerator = a.numerator * b.numerator;
            int denominator = a.denominator * b.denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction Division(Fraction a, Fraction b)
        {
            int numerator = a.numerator * b.denominator;
            int denominator;
            if (b.numerator < 0)
            {
                denominator = a.denominator * b.numerator * -1;
                numerator *= -1;
            }
            else
            {
                denominator = a.denominator * b.numerator;
            }
            

            return new Fraction(numerator, denominator);
        }

        private static int GetGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static int GetLeastCommonMultiple(int a, int b)
        {
            return a * b / GetGreatestCommonDivisor(a, b);
        }
    }
}