string fraseDigitada, fraseMeme;
Console.Write("Usuário, o que você pensa sobre mim? \n");
fraseDigitada = Console.ReadLine()!;

fraseMeme =
    $"\n{fraseDigitada.Remove(10)}... NÃO, PERA.\nTô nervoso";

Console.WriteLine(fraseMeme);