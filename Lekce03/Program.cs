using System.Text.Json;

namespace Lekce03;

class Program
{
    static void Main(string[] args)
    {
        //Ukol - Obratte poradi stringu
        string palindrom = "Kuna nese nanuk";
        ReverseText(palindrom);

        //Ukol - Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy
        string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };
        isPalidrome(slova);

        //Ukol - opravte v tomto textu omylem zapnuty Caps Lock
        string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";
        ToggleCase(capsLock);

        //Ukol - rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
        string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";
        Decrypt(sifra);
    }

    private static void Decrypt(string sifra)
    {
        string sentence = "";

        foreach (var ch in sifra)
        {
            char letter = (char)(ch - 1);
            sentence += letter;
        }
        Console.WriteLine(sentence);
    }

    private static void ToggleCase(string str)
    {
        string correctText = string.Empty;
        foreach (var item in str)
        {
            if (char.IsLower(item))
            {
                correctText += char.ToUpper(item);
            }
            else
            {
                correctText += char.ToLower(item);
            }
        }
        Console.WriteLine(correctText);
    }

    private static void isPalidrome(string[] words)
    {
        foreach (string word in words)
        {

            if (ReverseText(word) == word)
            {
                Console.WriteLine($"{word} is palidrome.");
            }
            else
            {
                Console.WriteLine($"{word} is not palidrome.");
            }
        }
    }

    private static string ReverseText(string palindrom)
    {
        string reverseText = string.Empty;

        for (int i = palindrom.Length - 1; i >= 0; i--)
        {
            reverseText += palindrom[i];
        }
        return reverseText;
    }
}
