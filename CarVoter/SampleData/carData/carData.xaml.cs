﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Blend.SampleData.carData
{
	using System; 
	using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class carData { }
#else

	public class carData : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public carData()
		{
			try
			{
				Uri resourceUri = new Uri("ms-appx:/SampleData/carData/carData.xaml", UriKind.RelativeOrAbsolute);
				Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private Collection _Collection = new Collection();

		public Collection Collection
		{
			get
			{
				return this._Collection;
			}
		}
	}

	public class Collection : System.Collections.ObjectModel.ObservableCollection<CollectionItem>
	{ 
	}

	public class CollectionItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Description = string.Empty;

		public string Description
		{
			get
			{
				return this._Description;
			}

			set
			{
				if (this._Description != value)
				{
					this._Description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}

		private Windows.UI.Xaml.Media.ImageSource _Image = null;

		public Windows.UI.Xaml.Media.ImageSource Image
		{
			get
			{
				return this._Image;
			}

			set
			{
				if (this._Image != value)
				{
					this._Image = value;
					this.OnPropertyChanged("Image");
				}
			}
		}

		private double _kiloWatts = 0;

		public double kiloWatts
		{
			get
			{
				return this._kiloWatts;
			}

			set
			{
				if (this._kiloWatts != value)
				{
					this._kiloWatts = value;
					this.OnPropertyChanged("kiloWatts");
				}
			}
		}

		private double _NumDownVotes = 0;

		public double NumDownVotes
		{
			get
			{
				return this._NumDownVotes;
			}

			set
			{
				if (this._NumDownVotes != value)
				{
					this._NumDownVotes = value;
					this.OnPropertyChanged("NumDownVotes");
				}
			}
		}

		private double _NumUpVotes = 0;

		public double NumUpVotes
		{
			get
			{
				return this._NumUpVotes;
			}

			set
			{
				if (this._NumUpVotes != value)
				{
					this._NumUpVotes = value;
					this.OnPropertyChanged("NumUpVotes");
				}
			}
		}

		private string _Title = string.Empty;

		public string Title
		{
			get
			{
				return this._Title;
			}

			set
			{
				if (this._Title != value)
				{
					this._Title = value;
					this.OnPropertyChanged("Title");
				}
			}
		}
	}
#endif
}