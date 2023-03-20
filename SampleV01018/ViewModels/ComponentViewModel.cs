using System.Collections.ObjectModel;
using ReactiveUI;

namespace SampleV01018.ViewModels
{
	public class ComponentViewModel : BaseViewModel
	{
        public ComponentViewModel() : base()
        {
            
        }

		private ObservableCollection<MemberViewModel> _memberVMs;

		public ObservableCollection<MemberViewModel> MemberVMs
		{
			get
			{
				if( _memberVMs == null )
					_memberVMs = new ObservableCollection<MemberViewModel>();
				return _memberVMs;
			}
			set
			{
				if( _memberVMs != value )
				{
					_memberVMs = value;
					this.RaisePropertyChanged( nameof( MemberVMs ) );
				}
			}
		}
	}
}
