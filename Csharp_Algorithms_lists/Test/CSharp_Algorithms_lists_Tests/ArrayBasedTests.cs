using System;
using FluentAssertions;
using Xunit;
using System.Diagnostics;

namespace CSharp_Algorithms_lists_Tests;

public class ArrayBasedTests
{
    [Theory]
    [Trait("TestType", "ArrayBased")]
    [InlineData(100, 10000, 150)]
    [InlineData(500, 50000, 750)]
    [InlineData(1000, 100000, 1500)]
    [InlineData(5000, 500000, 7500)]
    [InlineData(10000, 1000000, 15000)]
    [InlineData(50000, 5000000, 75000)]
    [InlineData(100000, 10000000, 150000, Skip = "LongRunning")]
    public void CanRunListMerge(int jobsCnt, int assignmentCnt, int resourcesCnt)
    {
        var sw = new Stopwatch();
        
        var arrayJobs = new Csharp_Algorithms_lists.ArrayBased.JobInitializer(jobsCnt).CreateJobs();
        var arrayAssignments = new Csharp_Algorithms_lists.ArrayBased.AssignmentInitializer(assignmentCnt, arrayJobs.Length).CreateAssigns();
        var arrayResources = new Csharp_Algorithms_lists.ArrayBased.ResourceInitializer(resourcesCnt).CreateResources();

        sw.Start();
        var jobAssignemntLinker =
            new Csharp_Algorithms_lists.ArrayBased.JobAssignmentLinker(arrayJobs, arrayAssignments); 
        
        Action act = () => jobAssignemntLinker.LinkItems();
        sw.Stop();
        act.Should().NotThrow<Exception>($"Code Executed in: {sw.Elapsed}");
    }
}