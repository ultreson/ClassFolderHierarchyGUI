using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassFolderHierarchyGUI
{
    public class Semester
    {
        private List<Course> m_courseList = new List<Course>();
        private string m_name;

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public List<Course> List
        {
            get
            {
                return m_courseList;
            }
        }

        public Semester(string pName)
        {
            m_name = pName;
        }

        public void Create(string path)
        {
            Directory.CreateDirectory(path + "\\" + m_name);
            path = path + "\\" + m_name;
            StringBuilder CourseName = new StringBuilder(path);
            foreach (Course course in m_courseList)
            {
                path = CourseName.ToString();
                Directory.CreateDirectory(path + "\\" + course.Name);
                path = path + "\\" + course.Name;
                StringBuilder pathBuilder = new StringBuilder(path);
                for (int week = 1; week < 16; week++)
                {
                    path = pathBuilder.ToString();
                    Directory.CreateDirectory(path + "\\semaine " + week.ToString("00"));
                    path = path + "\\semaine " + week.ToString("00");
                    if (course.NumberOfDays > 1)
                    {
                        for (int day = 0; day < course.NumberOfDays; day++)
                        {
                            Directory.CreateDirectory(path + "\\" + course.TabDayNames[day]);
                        }
                    }
                }
            }
        }
    }
}