// The name of this variable speaks by itself
string charset = "abcdefghijklmnopqrstuvwxyz";

// Fills the vector with the characters informed in the "charset" variable + an empty character
string[] charsetV = new string[charset.Length + 1];
charsetV[0] = "";
for (int i = 1; i < charset.Length + 1; i++)
{
    charsetV[i] = charset[i - 1].ToString();
}

Console.Write("Enter your password: ");
string password = Console.ReadLine();

while (password.Length > 8)
{
    Console.WriteLine("Password must be less than 8 characters!");
    Console.Write("Enter your password: ");
    password = Console.ReadLine();
}

string attempt = "";

// Generates the combinations, each for is responsible for a character (all start with the empty character)
for (int c = 0; c < charsetV.Length; c++)
{
    for (int c2 = 0; c2 < charsetV.Length; c2++)
    {
        for (int c3 = 0; c3 < charsetV.Length; c3++)
        {
            for (int c4 = 0; c4 < charsetV.Length; c4++)
            {
                for (int c5 = 0; c5 < charsetV.Length; c5++)
                {
                    for (int c6 = 0; c6 < charsetV.Length; c6++)
                    {
                        for (int c7 = 0; c7 < charsetV.Length; c7++)
                        {
                            for (int c8 = 0; c8 < charsetV.Length; c8++)
                            {
                                attempt = charsetV[c] + charsetV[c2] + charsetV[c3] + charsetV[c4] + charsetV[c5] + charsetV[c6] + charsetV[c7] + charsetV[c8];
                                //Console.WriteLine(attempt); -> uncomment this line if yo want to see all the combinations beeing generated
                                // Checks if current attempt equals password, and if so, terminates all for loops
                                if (attempt == password)
                                {
                                    c = c2 = c3 = c4 = c5 = c6 = c7 = c8 = charsetV.Length - 1;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

// Print the password
Console.Write("Your password is: ");
if (attempt == "")
{
    Console.WriteLine("Empty");
}
else
{
    Console.WriteLine(attempt);
}
