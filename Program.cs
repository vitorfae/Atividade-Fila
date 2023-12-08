using System;

public class Stack
{
    private string[] array;
    private int top;
    private int capacity;

    public Stack(int capacity)
    {
        this.capacity = capacity;
        this.array = new string[capacity];
        this.top = -1;
    }

    public void Push(string item)
    {
        if (IsFull())
        {
            Console.WriteLine("A pilha está cheia. Não é possível empilhar mais elementos.");
        }
        else
        {
            array[++top] = item;
            Console.WriteLine($"Elemento '{item}' empilhado com sucesso.");
        }
    }

    public string Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("A pilha está vazia. Não é possível desempilhar elementos.");
            return null;
        }
        else
        {
            string poppedItem = array[top--];
            Console.WriteLine($"Elemento '{poppedItem}' desempilhado com sucesso.");
            return poppedItem;
        }
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == capacity - 1;
    }

    public string Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("A pilha está vazia. Não há elementos para visualizar no topo.");
            return null;
        }
        else
        {
            return array[top];
        }
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("A pilha está vazia. Não há elementos para imprimir.");
        }
        else
        {
            Console.WriteLine("Elementos da pilha:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Exemplo de uso da classe Stack
        Stack minhaPilha = new Stack(5);

        minhaPilha.Push("Elemento1");
        minhaPilha.Push("Elemento2");
        minhaPilha.Push("Elemento3");

        minhaPilha.PrintStack();

        Console.WriteLine($"Topo da pilha: {minhaPilha.Peek()}");

        minhaPilha.Pop();
        minhaPilha.PrintStack();

        Console.ReadLine();
    }
}