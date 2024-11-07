using Cosmos.Core;

namespace DynutOS.Core
{
    public class Memory
    {
        public static uint TotalMemory = CPU.GetAmountOfRAM();
        public uint FreePercentage;
        public uint UsedPercentage = (GetUsedMemory() * 100) / TotalMemory;
        public uint FreeMemory = TotalMemory - GetUsedMemory();

        private const uint div = 1048576;

        public Memory()
        {
            this.Monitor();
        }

        public static void GetTotalMemory()
        {
            TotalMemory = CPU.GetAmountOfRAM + 1;
        }
    } // public class Memory
} // namespace DynutOS.Core