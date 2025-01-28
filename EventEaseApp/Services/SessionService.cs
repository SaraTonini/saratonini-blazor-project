using Blazored.LocalStorage;

public class SessionService
{
    private readonly ILocalStorageService _localStorage;

    public SessionService(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    // Set user session data
    public async Task SetUserSessionAsync(string userName, string userEmail)
    {
        await _localStorage.SetItemAsync("userName", userName);
        await _localStorage.SetItemAsync("userEmail", userEmail);
    }

    // Get user session data
    public async Task<(string? UserName, string? UserEmail)> GetUserSessionAsync()  // Rendi nullable
    {
        var userName = await _localStorage.GetItemAsync<string>("userName");
        var userEmail = await _localStorage.GetItemAsync<string>("userEmail");

        return (userName, userEmail);
    }
}
