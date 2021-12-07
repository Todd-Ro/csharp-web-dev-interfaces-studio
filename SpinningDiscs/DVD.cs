using System;
namespace SpinningDiscs
{
    public class DVD
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        static double SpinSpeedLinear = .12*Math.PI*570.0/60.0;

        void SpinDisc()
        {
            Console.WriteLine($"The disc spun a linear distance of " +
                $"{SpinSpeedLinear} meters in a single second.");
        }
    }
}
