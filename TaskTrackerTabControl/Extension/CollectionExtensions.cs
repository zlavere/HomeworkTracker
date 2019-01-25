using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTrackerTabControl.Extension
{
    public static class CollectionExtensions
    {
        public static IList<TaskGroupTabPage> ToTaskGroupTabPagesList(this TabControl.TabPageCollection collection)
        {
            return collection.Cast<TaskGroupTabPage>().ToList();
        }
    }
}
