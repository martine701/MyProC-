using FunWithBitwiseOperations;
using static FunWithBitwiseOperations.ContactPreferenceEnum;


Console.WriteLine("**** Fun with Bitwise Operations ****");
Console.WriteLine("6 & 4 = {0}", 6 & 4);
Console.WriteLine("6 | 4 = {0}", 6 | 4);
Console.WriteLine("6 ^ 4 = {0}", 6 ^ 4);
Console.WriteLine("~6 = {0}", ~6);
Console.WriteLine("6 << 1 = {0}", 6 << 1);
Console.WriteLine("6 >> 1 = {0}", 6 >> 1);
Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
Console.WriteLine("int.MinValue = {0}", int.MinValue);
Console.WriteLine();

ContactPreferenceEnum emailAndPhone = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;
Console.WriteLine("Email and Phone: {0}", emailAndPhone);
Console.WriteLine("Has Email: {0}", emailAndPhone.HasFlag(Email));
Console.WriteLine("Has Text: {0}", emailAndPhone.HasFlag(Text));
Console.WriteLine("Has Phone: {0}", emailAndPhone.HasFlag(Phone));
Console.WriteLine("Has Mail: {0}", emailAndPhone.HasFlag(Mail));
Console.WriteLine("Has All: {0}", emailAndPhone.HasFlag(All));
Console.WriteLine();


