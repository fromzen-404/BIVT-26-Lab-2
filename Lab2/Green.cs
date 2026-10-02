using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;
            for (int i=1; i<n; i+=2)
            {
                sum += n / (n+1);
            }
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
                for (int i = 1; i <= n; i++)
                {
                    answer += Math.Pow(x, -i);
                    stepen++
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;      // Вычисляем i!
                answer += fact; // Прибавляем к общей сумме
            }
            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            int i = 1;
            while (true)
            {
                double term = Math.Sin(i * Math.Pow(x, i));
                if (Math.Abs(term) < E) 
                    break;    
                answer += term;
                i++;
            }
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            double prev = 1.0;                  
            double curr = 1.0 / Math.Pow(x, n);
            while (Math.Abs(curr - prev) >= E)
            {
                n++;
                prev = curr;
                curr = 1.0 / Math.Pow(x, n);
            }
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;
            while (elem < limit)
            {
                elem *= 2;      // elem = elem * 2
                answer += elem; // answer = answer + elem
                i++;            // Счетчик итераций
            }
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
