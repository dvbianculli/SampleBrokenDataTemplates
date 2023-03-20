using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using SampleV011PR5.ViewModels;
using SampleV011PR5.Views;

namespace SampleV011PR5
{
	public partial class App : Application
	{
		public override void Initialize()
		{
			AvaloniaXamlLoader.Load( this );
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if( ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop )
			{
				desktop.MainWindow = new MainWindow
				{
					DataContext = new MainWindowViewModel(),
				};
			}

			base.OnFrameworkInitializationCompleted();
		}
	}
}