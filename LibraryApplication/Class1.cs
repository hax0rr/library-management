using System;
using System.Data;
using System.Configuration;
using System.Web;


/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	
        public static string GetRandomPassword(int length)
    {
    char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    string password = string.Empty;
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
    int x = random.Next(1, chars.Length);
    //For avoiding Repetation of Characters
    if (!password.Contains(chars.GetValue(x).ToString()))
    password += chars.GetValue(x);
    else
    i=i-1;
    }
    return password;
    }

}
