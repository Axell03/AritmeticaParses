using Antlr4.Runtime;
using parser;

string input = "5*6+9*3-1";
Console.WriteLine($"Input: {input}\n");

ICharStream stream = CharStreams.fromString(input);
A_Lexer lexer = new A_Lexer(stream);
CommonTokenStream tokens = new CommonTokenStream(lexer);
A_Parser parser = new aritmeticaParser(tokens);
var tree = parser.aritmetica();

Aritmetica aritmetica = new Aritmetica();
int res = aritmetica.Visit(tree);