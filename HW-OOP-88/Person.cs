using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HW_OOP_88;

public partial class Person: INotifyPropertyChanged
{
    private int id;
    public int Id 
    {
        get => id; 
        set
        {
            id = value;
            OnPropertyChanged("Id");
        }
    }

    private string name;
    public string Name 
    {
        get => name; 
        set
        {
            name = value;
            OnPropertyChanged("Name");
        }
    }

    private int age;
    public int Age 
    {
        get => age; 
        set
        {
            age = value;
            OnPropertyChanged("Age");
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
