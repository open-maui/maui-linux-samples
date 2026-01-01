using System;
using System.ComponentModel;

namespace TodoApp;

public class TodoItem : INotifyPropertyChanged
{
	private string _title = "";

	private string _notes = "";

	private bool _isCompleted;

	private DateTime _dueDate;

	private int _index;

	public int Id { get; set; }

	public int Index
	{
		get
		{
			return _index;
		}
		set
		{
			if (_index != value)
			{
				_index = value;
				OnPropertyChanged("Index");
			}
		}
	}

	public string Title
	{
		get
		{
			return _title;
		}
		set
		{
			if (_title != value)
			{
				_title = value;
				OnPropertyChanged("Title");
			}
		}
	}

	public string Notes
	{
		get
		{
			return _notes;
		}
		set
		{
			if (_notes != value)
			{
				_notes = value;
				OnPropertyChanged("Notes");
			}
		}
	}

	public bool IsCompleted
	{
		get
		{
			return _isCompleted;
		}
		set
		{
			if (_isCompleted != value)
			{
				_isCompleted = value;
				OnPropertyChanged("IsCompleted");
			}
		}
	}

	public DateTime DueDate
	{
		get
		{
			return _dueDate;
		}
		set
		{
			if (_dueDate != value)
			{
				_dueDate = value;
				OnPropertyChanged("DueDate");
			}
		}
	}

	public DateTime CreatedAt { get; set; } = DateTime.Now;

	public event PropertyChangedEventHandler? PropertyChanged;

	protected void OnPropertyChanged(string propertyName)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
