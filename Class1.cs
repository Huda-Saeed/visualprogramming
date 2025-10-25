namespace ToDoLibrary
{
    public class TaskItem
    {
        private int TaskId;
        private string Title;
        private string Description;
        private DateTime DueDate;
        private bool iscompleted;
        public int taskid
        {
            get { return TaskId; }
            set { TaskId = value; }
        }
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        public DateTime duedate
        {
            get { return DueDate; }
            set { DueDate = value; }
        }
        public bool iscomplete
        {
            get { return iscompleted; }
            set { iscompleted = value; }
        }
        public TaskItem(int id,string tit,string des,DateTime dued)
        {
            TaskId = id;    
            Title = tit;
            Description = des;
            DueDate = dued;
            iscompleted = false;
            }
    }

}
