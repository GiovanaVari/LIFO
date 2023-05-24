Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(6);
pilha.Push(1);
pilha.Push(4);
pilha.Push(8);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(88);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}