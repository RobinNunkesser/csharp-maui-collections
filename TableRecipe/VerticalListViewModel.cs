﻿using System.Collections.ObjectModel;

namespace TableRecipe
{
    public class VerticalListViewModel
    {
        public ObservableCollection<ItemViewModel> Items { get; set; }

        public VerticalListViewModel()
        {
            Items = new ObservableCollection<ItemViewModel>
            {
                new ItemViewModel
                {
                    Text = "Item 1",
                    Detail = "Detail 1"
                },
                new ItemViewModel
                {
                    Text = "Item 2",
                    Detail = "Detail 2"
                }
            };
        }
    }
}
