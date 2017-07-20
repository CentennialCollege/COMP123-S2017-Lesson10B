using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 13, 2017
 * Description: This Interface lists the signature for any Super Hero Subclass
 * Version: 0.2 - added public method trains
 */

namespace COMP123_S2017_Lesson10B
{

    public interface IHasKarma
    {
        // PUBLIC PROPERTIES
        int Karma { get; set; }

        // PUBLIC METHODS
        void Trains();
    }
}