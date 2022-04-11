﻿namespace BookStore.Web.ViewModels.Books
{
    public class BookInListModel
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public string Price { get; set; }

        public string ImageUrl { get; set; }

        public int Id { get; set; }

        public bool IsOnPromotional { get; set; }
    }
}
