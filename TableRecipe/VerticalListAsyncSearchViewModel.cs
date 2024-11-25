﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TableRecipe
{
    public class VerticalListAsyncSearchViewModel
        : INotifyPropertyChanged
    {
        private MockListService service = new();
        private List<ItemViewModel>? items;
        public List<ItemViewModel>? FilteredItems
        {
            get
            {
                if (string.IsNullOrEmpty(searchTerm))
                    return items;
                return items
                    ?.Where(
                        item =>
                            item.Text
                                .ToLower()
                                .Contains(searchTerm.ToLower())
                            || item.Detail
                                .ToLower()
                                .Contains(searchTerm.ToLower())
                    )
                    .ToList();
            }
        }

        private string searchTerm = "";
        public string SearchTerm
        {
            get => searchTerm;
            set
            {
                if (searchTerm != value)
                {
                    searchTerm = value;
                    OnPropertyChanged("FilteredItems");
                }
            }
        }

        internal async Task Initialize()
        {
            items = await service.ExecuteAsync();
            OnPropertyChanged("FilteredItems");
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(
            [CallerMemberName] string name = ""
        ) =>
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(name)
            );
        #endregion
    }
}
