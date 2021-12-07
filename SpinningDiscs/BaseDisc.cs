using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    internal abstract class BaseDisc
    {
        static int StorageCapacityInBlocks;
        string Name;
        static double SpinSpeedLinear;
        List<string> Contents;
        Boolean ReWritable;
        int StorageSpaceUsedInBlocks;

        void WriteToDisc(string[] contentsWritten, int sizeInBlocks)
        {
            if (sizeInBlocks > StorageCapacityInBlocks)
            {
                int excessData = 128 * (sizeInBlocks - StorageCapacityInBlocks);
                Console.WriteLine($"{excessData} kibiBytes of this data was unable to be written " +
                    $"due to storage capacity limitations.");
                sizeInBlocks = StorageCapacityInBlocks;
                Contents = new List<string>();
            }
            foreach (string s in contentsWritten)
            {
                Contents.Add(s);
                if (sizeInBlocks + StorageSpaceUsedInBlocks > StorageCapacityInBlocks)
                {
                    int overWrittenData = 128 * (sizeInBlocks + StorageSpaceUsedInBlocks - StorageCapacityInBlocks);
                    Console.WriteLine($"{overWrittenData} kibiBytes of data previously on the disc " +
                        $"were probably lost in this operation.");
                }
                StorageSpaceUsedInBlocks = Math.Max(StorageCapacityInBlocks, sizeInBlocks + StorageSpaceUsedInBlocks);
            }
        }

        double GetStorageCapacityInMB()
        {
            return StorageCapacityInBlocks / 8.0;
        }

    }
}
