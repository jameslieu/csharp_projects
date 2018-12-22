using System;
using System.ComponentModel.DataAnnotations;

namespace NoteTaker.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public string Body { get; set; }
        public string StudyCues { get; set; }
        public string Summary { get; set; }

        public DateTime CreatedOn  { get; set; }
        public DateTime UpdatedOn  { get; set; }
    }
}
