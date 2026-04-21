using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques
{
    public interface SortingTechniques
    {
        int[] Array { get; set; }
        int[] SortArray();
        void TimeComplexity();
        void SpaceComplexity();
    }
}
