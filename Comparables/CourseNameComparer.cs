using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Comparables
{
    class CourseNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return String.Compare((x as Course).Name, (y as Course).Name);
        }
    }
}
