using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TaskManagerApp.Models;
using System.Linq;  // LINQ 기능을 사용하려면 이 네임스페이스를 추가
using System.Xml.Serialization;  // XmlSerializer를 사용하려면 이 네임스페이스를 추가



namespace TaskManagerApp.Services
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        private int nextId = 1;

        public List<Task> GetAllTasks() => tasks;
        
        // 할일 추가
        public void AddTask(string title, string description, DateTime dueDate)
        {
            var task = new Task
            {
                Id = nextId++,
                Title = title,
                Description = description,
                DueDate = dueDate,
                IsCompleted = false
            };
            tasks.Add(task);
        }

        // 할일 삭제
        public void DeleteTask(int id)
        {
            tasks.RemoveAll(t => t.Id == id);
        }

        // 할일 완료 선택
        public void ToggleTaskCompletion(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
                task.IsCompleted = !task.IsCompleted;
        }

        // 할일 저장 (JSON 파일)
        public void SaveTasksAsJson(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var json = JsonSerializer.Serialize(tasks, options);
            File.WriteAllText(filePath, json, new System.Text.UTF8Encoding(true)); // BOM을 포함한 UTF-8로 저장
        }

        // 할일 저장 (텍스트 파일)
        public void SaveTasksAsText(string filePath)
        {
            var lines = tasks.Select(t => $"{t.Id}|{t.Title}|{t.Description}|{t.DueDate}|{t.IsCompleted}");
            File.WriteAllLines(filePath, lines);
        }

        // 할일 저장 (XML 파일)
        public void SaveTasksAsXml(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<Task>));
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, tasks);
            }

        }

        // 할일 불러오기 (JSON 파일)
        public void LoadTasksFromJson(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var json = File.ReadAllText(filePath, System.Text.Encoding.UTF8);
            tasks = JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
            nextId = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;
        }

        // 할일 불러오기 (텍스트 파일)
        public void LoadTasksFromText(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            tasks.Clear();
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 5)
                {
                    tasks.Add(new Task
                    {
                        Id = int.Parse(parts[0]),
                        Title = parts[1],
                        Description = parts[2],
                        DueDate = DateTime.Parse(parts[3]),
                        IsCompleted = bool.Parse(parts[4])
                    });
                }
            }
            nextId = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;
        }

        // 할일 불러오기 (XML 파일)
        public void LoadTasksFromXml(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var serializer = new XmlSerializer(typeof(List<Task>));
            using (var reader = new StreamReader(filePath))
            {
                tasks = (List<Task>)serializer.Deserialize(reader);
            }
            nextId = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;
        }
    }
}
