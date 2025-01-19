namespace ConsoleApplication.Extensions;

public static class Char
{
    public static bool IsVowel(this char ch) => Vowels.Contains(ch);

    public static bool IsConsonant(this char ch) => Consonants.Contains(ch);

    private static readonly HashSet<char> Vowels =
    [
        'И', 'А', 'О', 'У', 'Ы', 'Э', 'Я', 'Ё', 'Е', 'Ю', 'и', 'а', 'о', 'у', 'ы', 'э', 'я', 'ё', 'е', 'ю', 'A', 'E',
        'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y'
    ];

    private static readonly HashSet<char> Consonants =
    [
        'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'б',
        'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'B', 'C',
        'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', 'b', 'c', 'd',
        'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'
    ];
}