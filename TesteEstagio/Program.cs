using System;

class Program {
    static bool IsFibonacci(int num) {
        int a = 0, b = 1;
        while (a < num) {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == num;
    }

    static void Main(string[] args) {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsFibonacci(num)) {
            Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
        }
        else {
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
        }
    }
}
