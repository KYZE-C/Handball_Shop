using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Handball_Shopv1.Client
{
	public class AuthenticationState : AuthenticationStateProvider
	{
		private readonly ILocalStorageService _localStorageService;
		public AuthenticationState(ILocalStorageService localStorageService)
		{
			_localStorageService = localStorageService;
		}
		public override async Task<Microsoft.AspNetCore.Components.Authorization.AuthenticationState> GetAuthenticationStateAsync()
		{
			var authstate = new Microsoft.AspNetCore.Components.Authorization.AuthenticationState(new ClaimsPrincipal());

			string username = await _localStorageService.GetItemAsStringAsync("username");
			if (username != null)
			{
				var Identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }, "Authentication type");

				authstate = new Microsoft.AspNetCore.Components.Authorization.AuthenticationState(new ClaimsPrincipal(Identity));
			}
			NotifyAuthenticationStateChanged(Task.FromResult(authstate));

			return authstate;
		}
	}
}
