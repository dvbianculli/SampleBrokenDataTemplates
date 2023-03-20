﻿using ReactiveUI;

namespace SampleV011PR5.ViewModels
{
	public class BaseViewModel : ViewModelBase
	{
        public BaseViewModel()
        {
            
        }

		private string _name = string.Empty;

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if( _name != value )
				{
					_name = value;
					this.RaisePropertyChanged( nameof( Name ) );
				}
			}
		}


	}
}
