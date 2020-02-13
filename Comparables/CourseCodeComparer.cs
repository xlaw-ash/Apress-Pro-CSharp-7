using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Comparables
{
    class CourseCodeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (x as Course).Code.CompareTo((y as Course).Code);
        }
    }
}
