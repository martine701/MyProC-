using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;


BasicStringFunctionality();
StringConcatenation();
EscapeChars();
StringInterpolation();
StringInterpolationWithDefaultInterpolatedStringHandler();
VerbatimStrings();
StringEquality();
StringEqualitySpecifyingCompareRules();
StringsAreImmutable();
FunWithStringBuilder();

void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);
    sb.Append("\n");
    sb.AppendLine("Half Life");
    sb.AppendLine("Beyond Good and Evil");
    sb.AppendLine("Deus Ex 2");
    sb.AppendLine("System Shock");
    Console.WriteLine(sb.ToString());
    sb.Replace("2", "Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chars.", sb.Length);
    Console.WriteLine();

}

void StringsAreImmutable()
{
    Console.WriteLine("=> Strings are immutable:");
    string s1 = "This is my string.";
    Console.WriteLine("s1 = {0}", s1);

    // Uppercase s1?
    string upperString = s1.ToUpper();
    Console.WriteLine("upperString = {0}", upperString);

    // Nope! s1 is in the same format!
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine();

}

void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String equality (Case Insensitive):");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();

    // Check the results of changing the default compare rules.
    Console.WriteLine("Default rules: s1={0}, s2={1}, s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
    Console.WriteLine("Ignore case: s1={0}, s2={1}, s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1={0}, s2={1}, s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture, Ignore Kana Type: s1={0}, s2={1}, s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture, Ignore Kana Type, Ignore Width: s1={0}, s2={1}, s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture, Ignore Kana Type, Ignore Width, Ordinal: s1={0}, s2={1}, s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine();    
    Console.WriteLine("Default rules: s1={0}, s2={1}, s1.IndexOf(s2): {2}", s1, s2, s1.IndexOf(s2));
    Console.WriteLine("Ignore case: s1={0}, s2={1}, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1={0}, s2={1}, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture, Ignore Kana Type: s1={0}, s2={1}, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture, Ignore Kana Type, Ignore Width: s1={0}, s2={1}, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase));        
    Console.WriteLine("Ignore case, Invariant Culture, Ignore Kana Type, Ignore Width, Ordinal: s1={0}, s2={1}, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase): {2}", s1, s2, s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine();

}

void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Test these strings for equality.
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
    Console.WriteLine("s1.CompareTo(s2): {0}", s1.CompareTo(s2));  
    Console.WriteLine("s2.CompareTo(s1): {0}", s2.CompareTo(s1));
    Console.WriteLine("s1.CompareTo(Hello!): {0}", s1.CompareTo("Hello!"));
    Console.WriteLine("HELLO!.CompareTo(s1): {0}", "HELLO!".CompareTo(s1));
    Console.WriteLine("hello!.CompareTo(s1): {0}", "hello!".CompareTo(s1));
    Console.WriteLine();
}

void VerbatimStrings()
{
    Console.WriteLine("=> Verbatim Strings:");
    // The following string is printed verbatim
    Console.WriteLine(@"C:\MyApp\bin\Debug");
    // White space is preserved with verbatim strings  
    string myLongString = @"This is a very
            very
                very
                    long string";
    Console.WriteLine(myLongString);
    Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
    Console.WriteLine();
}

void StringInterpolationWithDefaultInterpolatedStringHandler()
{
    Console.WriteLine("=> String Interpolation with Default Interpolated String Handler:");
    int age = 4;
    string name = "Soren";

    var builder = new DefaultInterpolatedStringHandler(3, 2);
    builder.AppendLiteral("\tHello ");
    builder.AppendFormatted(name.ToUpper());
    builder.AppendLiteral(" you are ");
    builder.AppendFormatted(age);
    builder.AppendLiteral(" years old.");
    var greeting = builder.ToStringAndClear();
    Console.WriteLine(greeting);
    Console.WriteLine();
}

void StringInterpolation()
{
    Console.WriteLine("=> String Interpolation:");
    int age = 4;
    string name = "Soren";
    string greeting = string.Format("\tHello {0} you are {1} years old.", name.ToUpper(), age);

    string greeting2 = $"\tHello {name.ToUpper()} you are {age} years old.";
    Console.WriteLine(greeting);
    Console.WriteLine(greeting2);
    Console.WriteLine();
}

void EscapeChars()
{
    Console.WriteLine("=> Escape characters:");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
    Console.WriteLine(strWithTabs);
    Console.WriteLine("Everyone loves \"Hello World\"\a ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
    // Adds a total of 4 blank lines (then beep again!).
    Console.WriteLine("All finished.\n\n\n\a ");
    Console.WriteLine();
}

void StringConcatenation()
{
    Console.WriteLine("=> String Concatenation:");
    string s1 = "Programming the ";
    string s2 = "PsychoDrill (PTP)";
    string s3 = s1 + s2;    
    Console.WriteLine(s3);
    string s4 = String.Concat(s1, s2);
    Console.WriteLine(s4);
    Console.WriteLine();
}

void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String Functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
    Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();
}