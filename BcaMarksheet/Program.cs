using System;

class bca
{

    public static void Main(String[] args)
    {
        int[,] mrk = new int[3, 4];
        int[] total = new int[3];
        float[] per = new float[3];
        char[] grade = new char[3];
        char[] result = new char[3];


        for (int i = 0; i < 3; i++)
        {

            Console.WriteLine("****Data of year: {0}****", i + 1);
            int temp = 0;
            int p = 0;
            char k = 'P';
            for (int j = 0; j < 4; j++)
            {

                Console.WriteLine("Enter marks for sub{0}: ", j + 1);
                mrk[i, j] = int.Parse(Console.ReadLine());
                temp = temp + mrk[i, j];
                if (mrk[i, j] < 40)
                {
                    k = 'F';
                }
            }
            total[i] = temp;

            p = temp / 4;
            per[i] = p;

            if (p > 75)
            {
                grade[i] = 'A';
            }
            else if (p < 60)
            {
                grade[i] = 'C';
            }
            else
            {
                grade[i] = 'B';
            }

            if (p > 40)
            {

                if (k == 'F')
                {
                    result[i] = 'F';
                }

                else
                {
                    result[i] = 'P';
                }
            }
            else
            {
                result[i] = 'F';
            }
        }

        Console.WriteLine("");
        Console.WriteLine("***Final Marksheet***");

        int F_total = 0;
        int F_per = 0;
        char F_grade;
        char F_result = 'P';

        for (int i = 0; i < 3; i++)
        {

            Console.WriteLine("");
            Console.WriteLine("{0} Year", i + 1);
            Console.Write("Total: " + total[i] + " ");
            Console.Write("Per: " + per[i] + " ");
            Console.Write("Grade: " + grade[i] + " ");
            Console.Write("Result: " + result[i]);
            Console.WriteLine("");

            F_total = F_total + total[i];

            if (result[i] == 'F')
            {
                F_result = 'F';
            }

        }
        Console.WriteLine("");
        Console.WriteLine("Final:");

        F_per = F_total / 12;

        if (F_per > 75)
        {
            F_grade = 'A';
        }
        else if (F_per < 60)
        {
            F_grade = 'C';
        }
        else
        {
            F_grade = 'B';
        }

        Console.Write("Total: " + F_total + " ");
        Console.Write("Per: " + F_per + " ");
        Console.Write("Grade: " + F_grade + " ");
        Console.Write("Result: " + F_result);

        Console.ReadLine();
    }


}
