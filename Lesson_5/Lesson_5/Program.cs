using System;

namespace Lesson_5
{
    class Program
    {
        // Savenko Vadim
        static void Main(string[] args)
        {
            from10to2(22);
            while (StackIndex !=-1)
                pop();
        }

        //Stack
        private static int size = 100;
        public static char[] T = new char[size];
        public static int StackIndex = -1;

        public static void push(string element)
        {
            if (StackIndex < size)
                T[++StackIndex] = element[0];
            else
                Console.WriteLine("Stack overflow");
        }

        public static void pop()
        {
            if (StackIndex != -1)
                Console.WriteLine(T[StackIndex--]);
            else
                Console.WriteLine("Stack is empty!\n");
        }

        // from10to2
        public static void from10to2(int num)
        {
            if (num >= 2)
                from10to2(num / 2);
            push((num % 2).ToString());
        }
        
    }
}
