using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {

        string regex = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[-_!@#$%^&*., ?]).+$";

        // Compile the ReGex
        Regex p = new Regex(regex);

        Match m = p.Match(phoneNumber);



        var phoneNumberCleansed= Regex.Replace(phoneNumber, @"[^0-9]", "");
     
            return (phoneNumberCleansed.Length != 10 || phoneNumberCleansed.StartsWith("0") || phoneNumberCleansed.StartsWith("1"))
                ? throw new ArgumentException("Invalid phone number!")
                : phoneNumberCleansed;
    }


    private bool ValidatePhoneNoLength(string phoneNumber)
    { 
        return true;
    }
    private string ValidateCountryCode(string phoneNumber)
    {
        Regex r = new Regex(@"^1");
        return "";
    }

    private string ValidateAreaCode(string phoneNumber)
    {
        return "";
    }

    private string ValidateExchangeCode(string phoneNumber)
    {
        return "";
    }
}