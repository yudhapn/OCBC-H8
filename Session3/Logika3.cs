using System;

public class Logika3
{
    private const string VALID_USERNAME = "ocbc";
    private const string VALID_PASSWORD = "bootcamp";
    private const string SUCCEEDED_MESSAGE = "Anda berhasil login";
    private const string FAILED_MESSAGE = "Username atau Password anda salah";
    public static void Main(string[] args)
    {
        login();
    }

    private static void login()
    {
        string username, password, message;
        Console.Write("Username: ");
        username = Console.ReadLine();
        Console.Write("Password: ");
        password = Console.ReadLine();

        message = verifUserCredential(username, password) ? SUCCEEDED_MESSAGE : FAILED_MESSAGE;
        showLoginResult(message);
    }

    private static bool verifUserCredential(string username, string password)
    {
        return username == VALID_USERNAME && password == VALID_PASSWORD;
    }

    private static void showLoginResult(string message)
    {
        Console.WriteLine(message);
    }

}