using System;using System.IO;
using System.Collections;

namespace TextFileReader_csharp
{

class Class1
{
static void Main(string[] args)
{
StreamReader sr = new StreamReader("C:\Users\hrolo\Desktop\automatizar-pruebas-unitarias-2019-Hectorolon\Problema 01.txt");
string linea="";
ArrayList texto = new ArrayList();

while (linea != null)
{
linea = sr.ReadLine();
if (linea != null)
texto.Add(linea);
}
srr.Close();

foreach (string sOutput in texto)
Console.WriteLine(sOutput);
Console.ReadLine();
}
}
}



