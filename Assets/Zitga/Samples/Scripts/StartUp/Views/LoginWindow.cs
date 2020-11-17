using System.Collections;
using System.Text.RegularExpressions;
using Loxodon.Framework.Views;
using UnityEngine;
using UnityEngine.UI;

public class LoginWindowProperties : AWindowProperties
{
    public string name = "Hai";
    public int level = 5;
}

public class LoginWindow : Window<LoginWindowProperties>
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

    protected override void OnPropertiesSet()
    {
        log.Debug(Properties.name);
    }

    private void OnClickConfirm()
    {
        if (!(ValidateUsername(username.text) && ValidatePassword(password.text)))
        {
            log.Debug("Input is not valid");
            return;
        }

        StartCoroutine(CurrentGlobalWindowManager.HideWindow(this));
    }

    private void OnClickCancel()
    {
        StartCoroutine(CurrentGlobalWindowManager.HideWindow(this));
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