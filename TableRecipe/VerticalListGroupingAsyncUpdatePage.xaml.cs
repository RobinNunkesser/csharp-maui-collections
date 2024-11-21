using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableRecipe;

public partial class VerticalListGroupingAsyncUpdatePage : ContentPage
{
    public VerticalListGroupingAsyncUpdatePage()
    {
        InitializeComponent();
        BindingContext = new VerticalListGroupingAsyncUpdateViewModel();
    }
}