1. Verificación de balanceo de paréntesis
Para verificar si una expresión matemática tiene los paréntesis balanceados, podemos usar una pila. Aquí tienes un código en C# que realiza esta tarea:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expression = "{7+(8*5)-[(9-7)+(4+1)]}";
        if (IsBalanced(expression))
        {
            Console.WriteLine("La fórmula está balanceada.");
        }
        else
        {
            Console.WriteLine("La fórmula no está balanceada.");
        }
    }

    static bool IsBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in expression)
        {
            if (c == '{' || c == '(' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == '}' || c == ')' || c == ']')
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if (!IsMatchingPair(top, c))
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }

    static bool IsMatchingPair(char open, char close)
    {
        return (open == '{' && close == '}') ||
               (open == '(' && close == ')') ||
               (open == '[' && close == ']');
    }
}

2. Resolución del problema de las Torres de Hanoi
El problema de las Torres de Hanoi se puede resolver de manera recursiva. Aquí tienes un código en C# que implementa la solución:
using System;

class Program
{
    static void Main()
    {
        int n = 3; // Número de discos
        Console.WriteLine("Movimientos para resolver las Torres de Hanoi:");
        SolveHanoi(n, 'A', 'C', 'B'); // A: origen, C: destino, B: auxiliar
    }

    static void SolveHanoi(int n, char source, char destination, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 de {source} a {destination}");
            return;
        }
        SolveHanoi(n - 1, source, auxiliary, destination);
        Console.WriteLine($"Mover disco {n} de {source} a {destination}");
        SolveHanoi(n - 1, auxiliary, destination, source);
    }
}
