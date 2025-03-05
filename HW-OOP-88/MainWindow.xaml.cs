using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_OOP_88;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    DbPersonContext db = new DbPersonContext();
    public Person Person;
    public MainWindow()
    {
        InitializeComponent();
        db.Persons.Load();
        
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Person = db.Persons.First()!;
        DataContext = Person;
    }
}