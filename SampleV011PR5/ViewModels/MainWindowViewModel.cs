using System.Collections.ObjectModel;
using ReactiveUI;

namespace SampleV011PR5.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
		public string Greeting => "Welcome to Avalonia!";

        public MainWindowViewModel()
        {
         
			for(int i = 0; i < 10; i++)
			{
				var fileVM = new FileViewModel();
				fileVM.FileName = $"File {i}";
				this.RecentFileVMs.Add(fileVM);
			}

			for(int i = 0;i < 5;i++) 
			{
				var solutionVM = new SolutionViewModel();
				solutionVM.Name = $"Solution {i}";
				for(int  j = 0;j < 5; j++ )
				{
					var projectVM = new ProjectViewModel();
					projectVM.Name = $"Project {j}";

					for(int k = 0;k < 5;k++ )
					{
						var componentVM = new ComponentViewModel();
						componentVM.Name = $"Component {k}";

						for(int l = 0;l < 5;l++ )
						{
							var memberVM = new MemberViewModel();
							memberVM.Name = $"Member {l}";
							componentVM.MemberVMs.Add(memberVM);
						}

						projectVM.ComponentVMs.Add(componentVM);
					}

					solutionVM.ProjectVMs.Add(projectVM);
				}
				this.SolutionVMs.Add(solutionVM);
			}

        }

		private ObservableCollection<FileViewModel> _recentFileVMs;

		public ObservableCollection<FileViewModel> RecentFileVMs
		{
			get
			{
				if( _recentFileVMs == null )
					_recentFileVMs = new ObservableCollection<FileViewModel>();
				return _recentFileVMs;
			}
			set
			{
				if( _recentFileVMs != value )
				{
					_recentFileVMs = value;
					this.RaisePropertyChanged( nameof( RecentFileVMs ) );
				}
			}
		}

		private ObservableCollection<SolutionViewModel> _solutionVMs;

		public ObservableCollection<SolutionViewModel> SolutionVMs
		{
			get
			{
				if( _solutionVMs == null )
					_solutionVMs = new ObservableCollection<SolutionViewModel>();
				return _solutionVMs;
			}
			set
			{
				if( _solutionVMs != value )
				{
					_solutionVMs = value;
					this.RaisePropertyChanged( nameof( SolutionVMs ) );
				}
			}
		}


	}
}