using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TableRecipe;

public class VerticalListGroupingAsyncUpdateViewModel : INotifyPropertyChanged
{
    
    
    public VerticalListGroupingAsyncUpdateViewModel()
    {
        Update = new Command(UpdateData);
        Groups =
            new ObservableCollection<
                SectionViewModel<ItemViewModel>
            >();
    }

    private async void UpdateData()
    {
        await Task.Delay(1000);
        var NewGroups =
            new ObservableCollection<
                SectionViewModel<ItemViewModel>
            >();
        var Group1 = new SectionViewModel<ItemViewModel>
        {
            Header = "Section 1"
        };
        Group1.Add(
            new ItemViewModel
            {
                Text = "Section 1, Item 1",
                Detail = "Detail 1"
            }
        );
        Group1.Add(
            new ItemViewModel
            {
                Text = "Section 1, Item 2",
                Detail = "Detail 2"
            }
        );
        NewGroups.Add(Group1);
        var Group2 = new SectionViewModel<ItemViewModel>
        {
            Header = "Section 2"
        };
        Group2.Add(
            new ItemViewModel
            {
                Text = "Section 2, Item 1",
                Detail = "Detail 1"
            }
        );
        NewGroups.Add(Group2);
        Groups = NewGroups;
        OnPropertyChanged(nameof(Groups));
    }

    public ObservableCollection<
        SectionViewModel<ItemViewModel>
    > Groups { get; set; }
    public ICommand Update { get; set; }
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value,
        [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}