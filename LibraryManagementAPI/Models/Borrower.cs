﻿namespace LibraryManagementAPI.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int BookId { get; set; }
    }
}
