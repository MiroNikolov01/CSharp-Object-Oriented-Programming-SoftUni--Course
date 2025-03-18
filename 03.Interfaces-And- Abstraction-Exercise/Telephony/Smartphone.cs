namespace Telephony;

public class Smartphone : IBrowse, ICaller
{
    public string Browse(string url)
    {
        if (url.All(c => !char.IsDigit(c)))
        {
            return $"Browsing: {url}!";
        }

        return "Invalid URL!";
    }

    public string Call(string phoneNumber)
    {
        if (phoneNumber.Any(c => !char.IsDigit(c)))
        {
            return "Invalid number!";
        }

        return $"Calling... {phoneNumber}";
    }
}