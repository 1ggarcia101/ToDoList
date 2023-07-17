using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoTask
    {
        private List<Task> tasks;

        public ToDoTask()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void EditTask(int index, Task updatedTask)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index] = updatedTask;
            }
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        // Other methods like getting all tasks, marking a task as completed, etc.
    }
}