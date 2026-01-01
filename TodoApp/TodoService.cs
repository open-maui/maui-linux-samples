using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace TodoApp;

public class TodoService
{
	private static TodoService? _instance;

	private int _nextId = 1;

	public static TodoService Instance => _instance ?? (_instance = new TodoService());

	public ObservableCollection<TodoItem> Todos { get; } = new ObservableCollection<TodoItem>();

	public int CompletedCount => Todos.Count((TodoItem t) => t.IsCompleted);

	public int TotalCount => Todos.Count;

	private TodoService()
	{
		AddTodo("Learn OpenMaui Linux", "Explore the SkiaSharp-based rendering engine for .NET MAUI on Linux desktop. This is a very long description that should wrap to multiple lines and demonstrate the ellipsis truncation feature when MaxLines is set to 2.");
		AddTodo("Build amazing apps", "Create cross-platform applications that run on Windows, macOS, iOS, Android, and Linux! With OpenMaui, you can write once and deploy everywhere.");
		AddTodo("Share with the community", "Contribute to the open-source project and help others build great Linux apps. Join our growing community of developers who are passionate about bringing .NET MAUI to Linux.");
	}

	public TodoItem AddTodo(string title, string notes = "")
	{
		TodoItem todoItem = new TodoItem
		{
			Id = _nextId++,
			Index = Todos.Count,
			Title = title,
			Notes = notes,
			DueDate = DateTime.Today.AddDays(7.0)
		};
		Todos.Add(todoItem);
		return todoItem;
	}

	public void RefreshIndexes()
	{
		for (int i = 0; i < Todos.Count; i++)
		{
			Todos[i].Index = i;
		}
	}

	public TodoItem? GetTodo(int id)
	{
		return Todos.FirstOrDefault((TodoItem t) => t.Id == id);
	}

	public void DeleteTodo(TodoItem todo)
	{
		Todos.Remove(todo);
	}
}
