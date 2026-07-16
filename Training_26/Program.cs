using System.Runtime.CompilerServices;
Console.Write ("Input the string: ");
string braces = Console.ReadLine ();
//To ensure whether the input string is not null
while (braces == null) {
    Console.Write ("Enter valid string: ");
    braces = Console.ReadLine ();
}
//To print the ouput
Console.WriteLine (BracketChecker (braces));



bool BracketChecker (string bracket) {
    //Odd number of brackets is not balanced
    if (bracket.Length % 2 == 1) {
        return false;
    }
    Stack<int> stack = new Stack<int> ();
    foreach (char c in bracket) {
        if (c == '(' || c == '[' || c == '{') {
            stack.Push (c);
        } else if (stack.Count > 0 && ((stack.Peek () == '(' && c == ')') || (stack.Peek () == '[' && c == ']') || (stack.Peek () == '{' && c == '}'))) {
            stack.Pop ();
        } else {
            return false;
        }
    }
    //Only if the stack is empty the brackets are balanced
    if (stack.Count () == 0) {
        return true;
    }
    return false;
}

