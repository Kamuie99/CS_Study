using System;
using System.Windows.Forms;
using TaskManagerApp.Models;
using TaskManagerApp.Services;
using System.IO;  // Path 사용을 위한 네임스페이스 추가


namespace TaskManagerApp
{
    public partial class Form1 : Form
    {
        private readonly TaskManager taskManager = new TaskManager();
        private const string FilePath = "tasks.json";

        public Form1()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void LoadTasks()
        {
            string filePath = "tasks.json"; // 파일 경로를 지정 (혹은 사용자가 선택한 경로로 변경 가능)
            string extension = Path.GetExtension(filePath).ToLower();

            if (extension == ".json")
                taskManager.LoadTasksFromJson(filePath);
            else if (extension == ".txt")
                taskManager.LoadTasksFromText(filePath);
            else if (extension == ".xml")
                taskManager.LoadTasksFromXml(filePath);
            RefreshTaskList();
        }


        private void RefreshTaskList()
        {
            lbxTasks.Items.Clear();
            foreach (var task in taskManager.GetAllTasks())
            {
                lbxTasks.Items.Add(task);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            var description = txtDescription.Text;
            var dueDate = dtpDueDate.Value;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("업무 제목은 필수값입니다.", "Validation Error");
                return;
            }

            taskManager.AddTask(title, description, dueDate);
            RefreshTaskList();

            // 입력 칸 초기화
            txtTitle.Clear();
            txtDescription.Clear();
            dtpDueDate.Value = DateTime.Now; // 기본값으로 현재 날짜로 설정
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lbxTasks.SelectedItem is Task selectedTask)
            {
                taskManager.DeleteTask(selectedTask.Id);
                RefreshTaskList();
            }
        }

        private void btnToggleCompletion_Click(object sender, EventArgs e)
        {
            if (lbxTasks.SelectedItem is Task selectedTask)
            {
                taskManager.ToggleTaskCompletion(selectedTask.Id);
                RefreshTaskList();
            }
        }

        private void btnSaveTasks_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Files|*.json|Text Files|*.txt|XML Files|*.xml|All Files|*.*";
                saveFileDialog.Title = "Save task file as";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".json")
                        taskManager.SaveTasksAsJson(filePath);
                    else if (extension == ".txt")
                        taskManager.SaveTasksAsText(filePath);
                    else if (extension == ".xml")
                        taskManager.SaveTasksAsXml(filePath);

                    MessageBox.Show("Tasks saved successfully.", "Information");
                }
            }
        }

        private void btnLoadTasks_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files|*.json|Text Files|*.txt|XML Files|*.xml|All Files|*.*";
                openFileDialog.Title = "작업목록 파일 선택";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".json")
                        taskManager.LoadTasksFromJson(filePath);
                    else if (extension == ".txt")
                        taskManager.LoadTasksFromText(filePath);
                    else if (extension == ".xml")
                        taskManager.LoadTasksFromXml(filePath);

                    RefreshTaskList();
                    MessageBox.Show("작업 목록을 정상적으로 불러왔습니다.", "Information");
                }
            }
        }

    }
}
