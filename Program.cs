using System.Globalization;

Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");

const string turkishWord = "istikbal";

Console.WriteLine(turkishWord.ToUpper() == "ISTIKBAL");     //Return false

Console.WriteLine(turkishWord.ToUpper(new CultureInfo("tr-TR")) == "ISTIKBAL");     //Return false

Console.WriteLine(string.Equals(turkishWord, "ISTIKBAL", StringComparison.CurrentCultureIgnoreCase));      //Return false

Console.WriteLine(string.Equals(turkishWord, "ISTIKBAL", StringComparison.OrdinalIgnoreCase));      //Return true

Console.WriteLine(string.Equals(turkishWord, "ISTIKBAL", StringComparison.InvariantCultureIgnoreCase));      //Return true