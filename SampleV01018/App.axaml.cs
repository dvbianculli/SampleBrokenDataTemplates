using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using SampleV01018.ViewModels;
using SampleV01018.Views;

namespace SampleV01018
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