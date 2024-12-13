using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendX___QRCode_Based_Attendance_System.Common.Helper
{
    public class GarbageCollector
    {
        private readonly Action<string> _updateMemoryStatusAction;
        private readonly Action<string> _updateMemoryAfterGcStatusAction;

        public GarbageCollector(Action<string> updateMemoryStatusAction, Action<string> updateMemoryAfterGcStatusAction)
        {
            _updateMemoryStatusAction = updateMemoryStatusAction;
            _updateMemoryAfterGcStatusAction = updateMemoryAfterGcStatusAction;
        }

        public async Task MonitorMemoryAsync()
        {
            while (true)
            {
                // Wait for a certain interval before checking memory usage
                await Task.Delay(10000); // Check every 10 seconds

                // Get current memory usage
                long memoryUsed = GC.GetTotalMemory(false); // False means it doesn't force a collection
                string memoryStatus = $"Memory Used: {memoryUsed / (1024 * 1024)} MB";
       

                // Update memory status in TextBox1
                _updateMemoryStatusAction(memoryStatus);

                // Check if memory usage exceeds a threshold
                const long memoryThreshold = 50 * 1024 * 1024; // Example: 50 MB
                if (memoryUsed > memoryThreshold)
                {
                    string gcMessage = "Memory usage exceeded threshold. Triggering garbage collection...";
              

                    // Optional: Log this message if needed
                    _updateMemoryStatusAction(gcMessage);

                    // Trigger garbage collection
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    // Log after collection
                    long memoryAfterGC = GC.GetTotalMemory(false);
                    string memoryAfterGcStatus = $"Memory after GC: {memoryAfterGC / (1024 * 1024)} MB";
                    

                    // Update memory after GC status in TextBox2
                    _updateMemoryAfterGcStatusAction(memoryAfterGcStatus);
                }
            }
        }
    }

}
