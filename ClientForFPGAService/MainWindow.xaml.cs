using System.Windows;
using System.Dynamic;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Web;

namespace ClientForFPGAService
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        TabItem listOfProjects;

        public MainWindow()
        {
            InitializeComponent();

            listOfProjects = tabItemListOfProjects;
            tabControlMenu.Items.Remove(tabItemListOfProjects);

            dynamic dataContext = new ExpandoObject();
            dataContext.firstData = new[]
            {
                new DataGrid("text", 54, "wetrwe", false),
                new DataGrid("text", 34, "ergerg", false), 
                new DataGrid("text", 325, "wrthetrwe", true), 
                new DataGrid("text", 2134, "we45hye", false)
            };
            DataContext = dataContext;
        }

        private void ShowStartPage_Click(object sender, RoutedEventArgs e)
        {
            var temp = tabControlMenu.Items;
        }

        private void buttonDownloadRep_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Complete!");
            tabControlMenu.Items.Add(listOfProjects);

            List<ProjectInfo> projects = new List<ProjectInfo>();
            projects.Add(new ProjectInfo("Project 1", "11.02.2013","ewtrtehgwhjrerhethjerhj","1.0.0.0"));
            projects.Add(new ProjectInfo("Project 2", "15.05.2013","rtjtyj54uj545erherj","1.0.5.0"));
            projects.Add(new ProjectInfo("Project 3", "21.07.2013","tykuko65ir6ujdhfgswtt45ehjrth","1.0.2.0"));
            projects.Add(new ProjectInfo("Project 4", "11.02.2014","jtr5k7654ewyeshjryk5i6uerjk","1.3.0.0"));
            projects.Add(new ProjectInfo("Project 5", "11.06.2012","r567olu,tmrnthgryu65i","2.0.0.0"));

            dynamic dataContext = new ExpandoObject();
            dataContext.projects = projects;
            DataContext = dataContext;           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CodeViewerWindow a = new CodeViewerWindow();
            a.ShowDialog();

        }
    }
}
