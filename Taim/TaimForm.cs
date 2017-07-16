using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Taim
{
    public partial class TaimForm : Form
    {
        public const string TASK_LIST_FILE_NAME = "tasks.txt";

        private bool isMouseDown;
        private Point lastLocation;
        private IMouseEvents globalHook;
        private IMouseEvents appHook;
        private bool isLoadingInProgress;

        private TaimTask currentTask;

        private List<TaimTask> taskList;

        public TaimForm()
        {
            InitializeComponent();

            LoadTasks();
            LoadCurrentTask();
        }

        private void LoadTasks()
        {
            try
            {
                using (var stream = File.OpenRead(TASK_LIST_FILE_NAME))
                {
                    var serializer = new XmlSerializer(typeof(List<TaimTask>));
                    taskList = (List<TaimTask>)serializer.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                taskList = new List<TaimTask>();
            }
        }

        private void SaveTasks()
        {
            using (var writer = new StreamWriter(TASK_LIST_FILE_NAME))
            {
                var serializer = new XmlSerializer(taskList.GetType());
                serializer.Serialize(writer, taskList);
                writer.Flush();
            }
        }

        private void AppHook_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void AppHook_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void GlobalHook_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
                this.Update();
                lastLocation = new Point(lastLocation.X + deltaX, lastLocation.Y + deltaY);
            }
        }
        
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTasks();
            this.Close();
        }

        private void TaimForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalHook.MouseMove -= GlobalHook_MouseMove;
            appHook.MouseDown -= AppHook_MouseDown;
            appHook.MouseUp -= AppHook_MouseUp;
        }

        private void SetCurrentTask(TaimTask task)
        {
            currentTask = task;
            UpdateTaskView();
        }

        private void taskTimer_Tick(object sender, EventArgs e)
        {
            currentTask.Work(new TimeSpan(0, 0, 1));
            elapsedTimeLabel.Text = currentTask.ElapsedTime.ToString();
            if (elapsedTimeLabel.BackColor == SystemColors.Control)
            {
                elapsedTimeLabel.BackColor = SystemColors.ControlDark;
            }
            else {
                elapsedTimeLabel.BackColor = SystemColors.Control;
            }
        }

        private void UpdateTaskView()
        {
            isLoadingInProgress = true;
            titleTxt.Text = currentTask.Title;
            descriptionTxt.Text = currentTask.Description;
            estimationTxt.Text = currentTask.Estimation;
            elapsedTimeLabel.Text = currentTask.ElapsedTime.ToString();
            isLoadingInProgress = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartTaskTimer();
        }

        private void StartTaskTimer()
        {
            taskTimer.Enabled = true;
            taskTimer.Start();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTaskTimer();
        }

        private void StopTaskTimer()
        {
            taskTimer.Stop();
            elapsedTimeLabel.BackColor = SystemColors.Control;
        }

        private void task_DetailChanged(object sender, EventArgs e)
        {
            if (!isLoadingInProgress)
            {
                currentTask.Title = titleTxt.Text;
                currentTask.Description = descriptionTxt.Text;
                currentTask.Estimation = estimationTxt.Text;
                SaveTasks();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTaskTimer();
            TaimTask newTask = new TaimTask("enter new title", "enter new description", "enter new estimation");
            taskList.Add(newTask);
            SetCurrentTask(newTask);
        }

        private void TaimForm_Shown(object sender, EventArgs e)
        {
            InitMouseHook();
        }

        private void InitMouseHook()
        {
            globalHook = Hook.GlobalEvents();
            globalHook.MouseMove += GlobalHook_MouseMove;
            appHook = Hook.AppEvents();
            appHook.MouseDown += AppHook_MouseDown;
            appHook.MouseUp += AppHook_MouseUp;
        }

        private void prevTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskList.Count == 0)
            {
                return;
            }

            int index = taskList.IndexOf(currentTask);
            index--;
            if (index < 0)
            {
                index = taskList.Count - 1;
            }
            SetCurrentTask(taskList[index]);
        }

        private void nextTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskList.Count == 0)
            {
                return;
            }

            int index = taskList.IndexOf(currentTask);
            index++;
            if (index >= taskList.Count)
            {
                index = 0;
            }
            SetCurrentTask(taskList[index]);
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirm", "Complete the task?", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                StopTaskTimer();
                taskList.Remove(currentTask);
                SaveTasks();
                LoadCurrentTask();
            }
        }

        private void LoadCurrentTask()
        {
            if (taskList.Count == 0)
            {
                currentTask = new TaimTask("enter new task", "new description", "new est");
                taskList.Add(currentTask);
            }
            else
            {
                currentTask = taskList[0];
            }
            UpdateTaskView();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TaimForm_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void TaimForm_Deactivate(object sender, EventArgs e)
        {
            this.TransparencyKey = SystemColors.Control;
        }

        private void TaimForm_Activated(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Purple; // a color that never been used
        }
    }
}
