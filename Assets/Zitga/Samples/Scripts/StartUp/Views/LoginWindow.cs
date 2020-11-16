using System.Text.RegularExpressions;
using Loxodon.Framework.Views;
using UnityEngine;
using UnityEngine.UI;

public class LoginWindow : Window
{
    public InputField username;
    public InputField password;
    public Button confirmButton;
    public Button cancelButton;

    protected override void OnCreate(IBundle bundle)
    {
        confirmButton.onClick.AddListener(OnClickConfirm);
        cancelButton.onClick.AddListener(OnClickCancel);
    }

    private void OnClickConfirm()
    {
        if (!(ValidateUsername(username.text) && ValidatePassword(password.text)))
        {
            Debug.Log("Input is not valid");
            return;
        }

        Hide();
    }

    private void OnClickCancel()
    {
        Hide();
    }

    private bool ValidateUsername(string username)
    {
        if (string.IsNullOrEmpty(username) || !Regex.IsMatch(username, "^[a-zA-Z0-9_-]{4,12}$"))
        {
            // localization.GetText("login.validation.username.error", "Please enter a valid username.");
            return false;
        }
        return true;
    }

    private bool ValidatePassword(string password)
    {
        if (string.IsNullOrEmpty(password) || !Regex.IsMatch(password, "^[a-zA-Z0-9_-]{4,12}$"))
        {
            // "login.validation.password.error", "Please enter a valid password.";
            return false;
        }
        return true;
    }
}