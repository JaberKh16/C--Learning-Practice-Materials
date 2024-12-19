
// Program-1
StringBuilder builder = new StringBuilder();
builder.Append("Hello");
builder.Append(", ");
builder.Append("World");
string result = builder.ToString(); // "Hello, World"


builder.


// Program -2
var sb = new StringBuilder();
// Create a string composed of numbers 0 - 9
for (int i = 0; i < 10; i++)
{
    sb.Append(i.ToString());
}
Console.WriteLine(sb);  // displays 0123456789

// Copy one character of the string (not possible with a System.String)
sb[0] = sb[9];

Console.WriteLine(sb);  // displays 9123456789


// Program-3 
string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(question);

for (int j = 0; j < stringBuilder.Length; j++)
{
    if (System.Char.IsLower(stringBuilder[j]) == true)
        stringBuilder[j] = System.Char.ToUpper(stringBuilder[j]);
    else if (System.Char.IsUpper(stringBuilder[j]) == true)
        stringBuilder[j] = System.Char.ToLower(stringBuilder[j]);
}
// Store the new string.
string corrected = sb.ToString();
System.Console.WriteLine(corrected); // Output: How does Microsoft Word deal with the Caps Lock key? 
