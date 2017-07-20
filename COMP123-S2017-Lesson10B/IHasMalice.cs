using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 18, 2017
 * Description: This is the IHasMalice Interface
 * Version: 0.2 - Added public method Trains
 */

namespace COMP123_S2017_Lesson10B
{
    public interface IHasMalice
    {
        // Public Properties
        int Malice { get; set; }

        // public Methods
        void Trains();
    }
}