using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    internal class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        static int StorageCapacityInBlocks = 5625;
        static double StorageCapacityInMebiBytes = 703.125;
        string Name;
        static double SpinSpeedLinear = 1.25;
        List<string> Contents;
        Boolean ReWritable;

        void SpinDisc()
        {
            Console.WriteLine($"The disc spun a linear distance of " +
                $"{SpinSpeedLinear} meters in a single second.");
        }
    }
}
