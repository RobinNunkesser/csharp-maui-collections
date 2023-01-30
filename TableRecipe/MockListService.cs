using System;
namespace TableRecipe
{
    public class MockListService
    {
        public List<ItemViewModel> Items { get; set; } =
            new List<ItemViewModel>
            {
                new ItemViewModel
                {
                    Text = "Sponge",
                    Detail = "Detail 1"
                },
                new ItemViewModel
                {
                    Text = "Banana",
                    Detail = "Detail 2"
                },
                new ItemViewModel
                {
                    Text = "Laptop",
                    Detail = "Detail 3"
                },
                new ItemViewModel
                {
                    Text = "Teddy Bear",
                    Detail = "Detail 4"
                }
            };

        public List<ItemViewModel> Execute() => Items;

        public async Task<List<ItemViewModel>> ExecuteAsync()
        {
            await Task.Delay(1000);
            return Items;
        }

    }
}

