using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson_5
{
    class Program
    {
        // Savenko Vadim
        static void Main(string[] args)
        {
            // задание с переводом из 10 в двоичную
            from10to2(22);
            while (StackIndex != -1)
                Console.WriteLine(pop());

            // Задание для определение правильности последовательности:

            string inputStr = "[(2+2)*{3+(3-2)}]";
            // отпарвляем только нужные элементы:

       
            if (CheckMatching(inputStr))
                Console.WriteLine("Последовательность правильная!");
            else
                Console.WriteLine("Последовательность не правильная!");
        
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

        public static string pop()
        {
            if (StackIndex != -1)
                return T[StackIndex--].ToString();
            else
                return "-1";
        }
        // функция вывода определённого элемента по индексу
        public static string pop(int index)
        {
            if (index <= StackIndex)
            {
                string temp = T[index].ToString();

                for (int i = index; i < StackIndex; i++)
                {
                    T[i] = T[i + 1];
                }
                StackIndex--;
                return temp;
            }
            return "-1";
        }

        // from10to2
        public static void from10to2(int num)
        {
            if (num >= 2)
                from10to2(num / 2);
            push((num % 2).ToString());
        }

        // задание 2 - определить правильность последовательностей: [({})]

        public static bool CheckMatching(string input)
        {
            // заполняем stack
            string sequence = "[]{}()";
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < sequence.Length; j++)
                {
                    if (input[i] == sequence[j])
                        push(input[i].ToString());
                }
            }
            string temp;
            do
            {
               temp = pop();
                // последний элемент в любом случае будет закрывающей, или сразу не подходит
                int position;
               switch (temp)
                {
                    case ")":
                        position = SearchElement("(");
                        if (position == -1)
                            return false;
                        else
                            pop(position);
                        break;
                    case "}":
                        position = SearchElement("{");
                        if (position == -1)
                            return false;
                        else
                            pop(position);
                        break;
                    case "]":
                        position = SearchElement("[");
                        if (position == -1)
                            return false;
                        else
                            pop(position);
                        
                        break;
                    case "-1":
                        return true;
                    default: return false;
                }
            }
            while (temp != "-1");
            return true;
        }

        public static int SearchElement(string el)
        {
            for (int i = StackIndex; i >= 0; i--)
            {
                if (el == T[i].ToString())
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
