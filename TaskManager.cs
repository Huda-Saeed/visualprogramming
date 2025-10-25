using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLibrary
{
    public class TaskManager
    {
        private List<TaskItem> tasksList = new List<TaskItem>();
        public void AddTask(TaskItem task)
        { 
                tasksList.Add(task);
        }
        public void UpdateTask(int id,TaskItem updatedTask)
        {
            foreach (TaskItem t in tasksList)
            {
                if (t.taskid == id)
                {
                    t.title = updatedTask.title;
                    t.description = updatedTask.description;
                    t.duedate = updatedTask.duedate;
                    t.iscomplete = updatedTask.iscomplete;
                }
            }
        }
        public void DeleteTask(int id)
        {
            TaskItem taskremove = null;
            foreach (TaskItem t in tasksList)
            {
                if (t.taskid == id)
                {
                    taskremove = t;
                    break;
                }
            }

            if (taskremove != null)
            {
                tasksList.Remove(taskremove);
            }
        }
        public TaskItem[] GetAlltasks()
        {
            return tasksList.ToArray();
        }
            public void MarkAsCompleted(int id)
        {
            foreach (TaskItem t in tasksList)
            {
                if (t.taskid == id)
                {
                    t.iscomplete = true;
                    break;
                }
            }
        }
    }
}
