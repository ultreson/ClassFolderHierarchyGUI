using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassFolderHierarchyGUI
{
    public class Course
    {

        private string[] m_tabDayNames = new string[] {"lundi", "mardi", "mercredi","jeudi", "vendredi"};
        private string m_name;
        private int m_nbDays;
        private bool[] m_tabBoolDays;

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public int NumberOfDays
        {
            get
            {
                return m_nbDays;
            }
        }

        public string[] TabDayNames
        {
            get
            {
                string[] tabDayNames = new string[NumberOfDays];
                int count = 0;
                for (int day = 0; day < 5; day++)
                {
                    if (m_tabBoolDays[day])
                    {
                        tabDayNames[count] = m_tabDayNames[day];
                        count++;
                    }
                }
                return tabDayNames;
            }
        }

        public Course(string pName, bool[] pTabDays)
        {
            m_name = pName;
            m_tabBoolDays = pTabDays;
            CountNumberOfDays();
        }

        private void CountNumberOfDays()
        {
            m_nbDays = 0;
            foreach (bool item in m_tabBoolDays)
            {
                if (item)
                    m_nbDays++;
            }
        }

    }
}
