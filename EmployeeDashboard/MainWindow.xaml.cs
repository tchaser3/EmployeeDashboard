/* Title:           Employee Dashboard
 * Date:            10-25-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the Employee Dashboard */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NewEmployeeDLL;
using NewEventLogDLL;
using DataValidationDLL;
using DateSearchDLL;
using EmployeePunchedHoursDLL;
using System.Windows.Threading;

namespace EmployeeDashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //setting up the classes
        WPFMessagesClass TheMessagesClass = new WPFMessagesClass();
        EmployeeClass TheEmployeeClass = new EmployeeClass();
        EventLogClass TheEventLogClass = new EventLogClass();
        DateSearchClass TheDateSearchClass = new DateSearchClass();

        FindActiveNonExemptEmployeesDataSet TheFindActiveNoExcemptEmployeesDataSet = new FindActiveNonExemptEmployeesDataSet();

        DispatcherTimer MyTimer = new DispatcherTimer();

        int gintCurrentLocation;
        int gintNumberOfRecords;
        int[] gintEmployeeID = new int[16];

        public static int gintSelectedEmployeeID;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RowDefinition_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void BeginTheProcess(object sender, EventArgs e)
        {
            SetPage();
        }
        private void LoadNonExemptEmployees()
        {
            gintCurrentLocation = 0;

            TheFindActiveNoExcemptEmployeesDataSet = TheEmployeeClass.FindActiveNonExemptEmployees();

            gintNumberOfRecords = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees.Rows.Count - 1;
        }
        private void SetPage()
        {
            int intCounter;

            for (intCounter = 0; intCounter <= 15; intCounter++)
            {
                if (intCounter == 0)
                {
                    txtButton1.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[0] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 1)
                {
                    txtButton2.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[1] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 2)
                {
                    txtButton3.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[2] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 3)
                {
                    txtButton4.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[2] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 4)
                {
                    txtButton5.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[4] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 5)
                {
                    txtButton6.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[5] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 6)
                {
                    txtButton7.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[6] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 7)
                {
                    txtButton8.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[7] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                if (intCounter == 8)
                {
                    txtButton9.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[8] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 9)
                {
                    txtButton10.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[9] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 10)
                {
                    txtButton11.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[10] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 11)
                {
                    txtButton12.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[11] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 12)
                {
                    txtButton13.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[12] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 13)
                {
                    txtButton14.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[13] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 14)
                {
                    txtButton15.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[14] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
                else if (intCounter == 15)
                {
                    txtButton16.Text = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].FirstName + " " + TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].LastName;
                    gintEmployeeID[15] = TheFindActiveNoExcemptEmployeesDataSet.FindActiveNonExemptEmployees[gintCurrentLocation].EmployeeID;
                    gintCurrentLocation++;

                    if (gintCurrentLocation > gintNumberOfRecords)
                    {
                        LoadNonExemptEmployees();
                    }
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            LoadNonExemptEmployees();
            SetPage();

            MyTimer.Tick += new EventHandler(BeginTheProcess);
            MyTimer.Interval = new TimeSpan(0, 0, 10);
            MyTimer.Start();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            SetPage();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            gintCurrentLocation -= 32;

            if(gintCurrentLocation < 0)
            {
                gintCurrentLocation = gintNumberOfRecords + gintCurrentLocation;
            }
            SetPage();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            TheMessagesClass.CloseTheProgram();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            EmployeeSearch EmployeeSearch = new EmployeeSearch();
            EmployeeSearch.Show();
        }
    }
}
