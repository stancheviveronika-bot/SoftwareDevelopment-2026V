using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOmanage
{
    internal class TodoItem
    {
        private int id;
        private string title;
        private string description;
        private DateTime dueDate;
        private bool isCompleted;
        
        public int Id { get; set; }
        public string Title {
            get
            {
                return title;
            }
            set 
            {
                if (string.IsNullOrEmpty(title))
                    throw new ArgumentNullException("Заглавието е задължително");

            }
        }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItem(int id,string title, string description, DateTime deadLine)
        {

            if (id <= 0)
                throw new ArgumentOutOfRangeException("ID трябва да е полоьително число:");
            if(string.IsNullOrEmpty(title)) 
                throw new ArgumentNullException("Заглавието е задължително");

            Id = id;
            Title = title;
            Description = description;
            DeadLine = deadLine;
            IsCompleted = false;
        }
    }

}
