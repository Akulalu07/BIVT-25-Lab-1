using System;
namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0) || (a == 0 && b == 0 && c == 0))
            {  
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (a % b == 0 || b % a == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a * a == b || b * b == b)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here

            answer = f * f - 4 * d * g;
                
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 1;
            }
            else if (x > -1 && x < 1)
            {
                answer =  -1 * x;
            }
            else
            {
                answer = -1;
            }
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            double squart = Math.Sqrt(squareS) / 2;

            if (squart * Math.PI <= circleS)
            {
                answer = true;                
            }
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s && t)
            {
                answer = 6;
            }
            else if (s && !t && f)
            {
                answer = 10;
            }
            else if (s && !t && !f)
            {
                answer = 2;
            }
            else if (!s && t)
            {
                answer = 3;
            }
            else if (!s && !t && f)
            {
                answer = 5;
            }
            else
            {
                answer = 1;
            }

            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if (isLeapYear)
            {
                answer =  false;
            } 
            int aurors = (pupils + 6) / 7;
            int totalCost = aurors * salary + 5 * pupils;

            if (totalCost <= bank)
            {
                answer = true;
            }
            // end

                return answer;
        }
    }
}
