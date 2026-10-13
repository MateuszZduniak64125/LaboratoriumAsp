using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class IsbnAttribute : ValidationAttribute
{
    public IsbnAttribute() => ErrorMessage = "Niepoprawny format ISBN";

    public override bool IsValid(object? value)
    {
        if (value is not string)
        {
            ErrorMessage = "ISBN nie jest lancuchem";
            return false;
        }
        string isbn = value as string;
        if (isbn.Length != 13 &&  isbn.Length != 10)
        {
            ErrorMessage = "ISBN ma niepoprawna dlugosc";
            return false;
        }

        if (!isbn.ToCharArray().All(c => char.IsDigit(c)))
        {
            ErrorMessage = "ISBN powinien zawierac same cyfry";
            return false;
        }
        return true;
    }
}