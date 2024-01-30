using System;
using System.Collections.Generic;

int notaMedia = 8;

if (notaMedia >= 5) {
    Console.WriteLine("Nota suficiente para aprovação");
}

List<string> programmingLanguages = new List<string>();
programmingLanguages.Add("C#");
programmingLanguages.Add("Java");
programmingLanguages.Add("JavaScript");

Console.WriteLine(programmingLanguages[0]);

void showPosition(int nSelect)
{
    Console.WriteLine(programmingLanguages[nSelect]);
}


Console.Write("\nEscolha a posição que você quer buscar na lista (-1 para cancelar): ");
string nSelectString = Console.ReadLine()!;

int nSelect = int.Parse(nSelectString);

if (nSelect != -1) {
    showPosition(nSelect);
} else {
    Console.WriteLine("tchau tchau");
}
        



