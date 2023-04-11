using System;
using System.Text.RegularExpressions;

// Regex regexName = new Regex("^m..t$");
// Regex regexName = new Regex("^[a-oA-O]...n$");
Regex regexName = new Regex("^[a-oA-O]*");

if (regexName.IsMatch("Orxan"))
{
    Console.WriteLine("Uygundu");
}else{
 Console.WriteLine("Uygun deyil");
}

// eli@gmail.com 

// *eli.jpg