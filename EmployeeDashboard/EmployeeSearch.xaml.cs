/* Title:           Employee Search
 * Date:            10-26-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the search function for an employee */

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
using System.Windows.Shapes;

namespace EmployeeDashboard
{
    /// <summary>
    /// Interaction logic for EmployeeSearch.xaml
    /// </summary>
    public partial class EmployeeSearch : Window
    {
        WPFMessagesClass TheMessagesClass = new WPFMessagesClass();

        public EmployeeSearch()
        {
            InitializeComponent();
        }
    }
}
