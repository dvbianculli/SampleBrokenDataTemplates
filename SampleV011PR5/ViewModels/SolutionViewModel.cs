using System.Collections.ObjectModel;
using ReactiveUI;

namespace SampleV011PR5.ViewModels
{
	public class SolutionViewModel : BaseViewModel
	{
        public SolutionViewModel() : base()
        {
            
        }

		private ObservableCollection<ProjectViewModel> _projectVMs;

		public ObservableCollection<ProjectViewModel> ProjectVMs
		{
			get
			{
				if( _projectVMs == null )
					_projectVMs = new ObservableCollection<ProjectViewModel>();
				return _projectVMs;
			}
			set
			{
				if( _projectVMs != value )
				{
					_projectVMs = value;
					this.RaisePropertyChanged( nameof( ProjectVMs ) );
				}
			}
		}
	}
}
