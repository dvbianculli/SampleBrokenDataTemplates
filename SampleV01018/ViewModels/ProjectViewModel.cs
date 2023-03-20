using System.Collections.ObjectModel;
using ReactiveUI;

namespace SampleV01018.ViewModels
{
	public class ProjectViewModel : BaseViewModel
	{
        public ProjectViewModel() : base()
        {
            
        }

		private ObservableCollection<ComponentViewModel> _componentVMs;

		public ObservableCollection<ComponentViewModel> ComponentVMs
		{
			get
			{
				if( _componentVMs == null )
					_componentVMs = new ObservableCollection<ComponentViewModel>();
				return _componentVMs;
			}
			set
			{
				if( _componentVMs != value )
				{
					_componentVMs = value;
					this.RaisePropertyChanged( nameof( ComponentVMs ) );
				}
			}
		}
	}
}
