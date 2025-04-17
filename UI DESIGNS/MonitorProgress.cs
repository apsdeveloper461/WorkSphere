using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_DESIGNS
{
    public partial class MonitorProgress : UserControl
    {
        private ServiceReference1.User user;
        public MonitorProgress(ServiceReference1.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void MonitorProgress_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + user.Name + "!";
            if (user.Role == "admin")
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                ServiceReference1.Project[] projects = client.displayProject(user);
                List<ServiceReference1.TimeLog> timeLogs = new List<ServiceReference1.TimeLog>();
                if (projects != null)
                {
                    foreach (var project in projects)
                    {
                        if (project.Status == true)
                        {

                        ServiceReference1.TimeLog[] timeLog = client.getTimeLogsByProjectId(user,project.Id);
                        foreach (var log in timeLog)
                        {
                            timeLogs.Add(log);
                        }
                        }
                    }
                }

                var timeLogDisplayList = timeLogs.Select(t => new TimeLogDisplay
                {
                    Id = t.Id,
                    status = t.Status,
                    ProjectName = t.Project.Title,
                    DeveloperEmail = t.Developer.Email,
                    Hours = t.WorkedHours,
                    Description = t.Description,
                    Date = t.Date
                }).ToList();

                dataGridView1.DataSource = timeLogDisplayList;

            }
            else
            {
                ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
                ServiceReference1.Project[] projects = service1Client.projectCurrentlyOnWhichWork(user);
                List<ServiceReference1.TimeLog> timeLogs = new List<ServiceReference1.TimeLog>();
                if (projects != null)
                {
                    foreach (ServiceReference1.Project project in projects)
                    {
                        ServiceReference1.TimeLog[] timeLog = service1Client.getTimeLogsByProjectId(user, project.Id);
                        foreach (var log in timeLog)
                        {
                            timeLogs.Add(log);
                        }
                    }
                    var timeLogDisplayList = timeLogs.Select(t => new TimeLogDisplay
                    {
                        Id = t.Id,
                        status = t.Status,
                        ProjectName = t.Project.Title,
                        DeveloperEmail = t.Developer.Email,
                        Hours = t.WorkedHours,
                        Description = t.Description,
                        Date = t.Date
                    }).ToList();

                    dataGridView1.DataSource = timeLogDisplayList;
                }
            }
        }
    }
}
