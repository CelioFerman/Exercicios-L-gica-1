using System;

class ExercicioLogica3
{
    static void Main()
    {

        ExibirMenu();
        int pedido = ItemEscolhido();
        ItemSelecionado(pedido);
    }

    static Dictionary<string, int> menu = new Dictionary<string, int>
    {
        { "Cachorro Quente", 14 },
        { "X-Salada", 20 },
        { "X-Bacon", 10 },
        { "Torrada Costela Barbecue", 25 },
        { "Fim de Noite", 30 }
    };

    static void ExibirMenu()
    {
        Console.WriteLine("=== Menu ===");
        int index = 1;

        foreach (var item in menu)
        {
            Console.WriteLine($"{index}. {item.Key} - R$ {item.Value}");
            index++;
        }
    }

    static int ItemEscolhido()
    {
        Console.WriteLine("\nEscolha um item pelo número de 1 a 5: ");
        int itemEscolhido;

        while (!int.TryParse(Console.ReadLine(), out itemEscolhido) || itemEscolhido < 1 || itemEscolhido > menu.Count)
        {
            Console.WriteLine("Opção invalida! Tente novamente: ");
        }
        return itemEscolhido;

    }

    static void ItemSelecionado(int pedido)
    {
        string itemSelecionado = new List<string>(menu.Keys)[pedido - 1];
        int preco = menu[itemSelecionado];

        Console.WriteLine($"\nVocê escolheu: {itemSelecionado} - Preço: R$ {preco}");
    }
}    
