using Windows.UI.Xaml;

namespace Uno.UI
{
	public class ApplicationHelper
	{
		private static string _requestedCustomTheme;

		/// <summary>
		/// This is a custom theme that can be used in ThemeDictionaries
		/// </summary>
		/// <remarks>
		/// When the custom theme key is not found in a theme dictionary, it will fallback to
		/// Application.RequestedTheme (Dark/Light)
		/// </remarks>
		public static string RequestedCustomTheme
		{
			get => _requestedCustomTheme;
			set
			{
				_requestedCustomTheme = value;

				if (_requestedCustomTheme?.Equals("Dark") ?? false)
				{
					Application.Current.RequestedTheme = ApplicationTheme.Dark;
				}
				else if (_requestedCustomTheme?.Equals("Light") ?? false)
				{
					Application.Current.RequestedTheme = ApplicationTheme.Light;
				}
			}
		}
	}
}
