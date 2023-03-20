using ReactiveUI;

namespace SampleV01018.ViewModels
{
	public class FileViewModel : ViewModelBase
	{

		#region Members
		private string _fileName;
		private bool _isChecked = false;
		#endregion

		#region Constructors and Initializers
		public FileViewModel()
		{

		}
		#endregion

		#region Properties


		public string FileName
		{
			get { return _fileName; }
			set { this.RaiseAndSetIfChanged( ref _fileName, value ); }

		}

		public bool IsChecked
		{
			get
			{
				return _isChecked;
			}
			set
			{
				this.RaiseAndSetIfChanged( ref _isChecked, value );
			}
		}

		#endregion

	}
}
