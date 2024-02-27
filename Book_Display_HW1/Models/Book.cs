namespace Book_Display_HW1.Models
{
    using System;

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public DateTime DueDate { get; set; }
        public int DaysUntilDelivery => (int)(DueDate - DateTime.Now).TotalDays;
    }

}
