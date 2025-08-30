using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassLibrary.Interfaces
{
    public interface IArrayActivity
    {
        void SetArray(int[] array);
        void Output();
        void SearchArray(int? target, bool? findLargestValue);
    }
}