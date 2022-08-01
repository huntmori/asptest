namespace TodoApi.Models
{
    public class TodoItem 
    {
        private long id;
        public long Id 
        {
            get 
            {
                return id;
            }
            set 
            {
                this.id = value;
            }
        }

        
        public string? Name { get; set; }
        public bool IsComplete{ get; set;}
    }
}