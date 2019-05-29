using Microsoft.VisualStudio.TestTools.UnitTesting;
using NBench;
using ProjectManager.Controllers;

namespace PerformanceTests
{
   // [TestClass]
    public class TaskPerfTests
    {
        [PerfBenchmark(NumberOfIterations = 3, RunMode = RunMode.Throughput,
        TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 5000)]
        [CounterThroughputAssertion("TestCounter", MustBe.GreaterThanOrEqualTo, 0.0d)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.GreaterThanOrEqualTo, ByteConstants.SixtyFourKb)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.LessThanOrEqualTo, 0.0d)]
        [PerfSetup]
        public void PerformanceTests()
        {
            // Set up Prerequisites   
            var controller = new ProjectController();
            // Act on Test  
            var response = controller.RetrieveProjects();
            // Assert the result  
            Assert.IsTrue(response != null);
        }
    }
}
