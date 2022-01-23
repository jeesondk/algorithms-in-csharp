using System;
using FluentAssertions;
using Xunit;
using System.Diagnostics;

namespace CSharp_Algorithms_lists_Tests;

public class DictionaryBasedTests
{
    [Theory]
    [Trait("TestType", "DictionaryBased")]
    [InlineData(100, 10000, 150)]
    [InlineData(500, 50000, 750)]
    [InlineData(1000, 100000, 1500)]
    [InlineData(5000, 500000, 7500)]
    [InlineData(10000, 1000000, 15000)]
    [InlineData(50000, 5000000, 75000)]
    [InlineData(100000, 10000000, 150000)]
    public void CanRunListMerge(int jobsCnt, int assignmentCnt, int resourcesCnt)
    {
        var sw = new Stopwatch();
        
        var dicJobs = new Csharp_Algorithms_lists.DictionaryBased.JobInitializer(jobsCnt).CreateJobs();
        var dicAssignments = new Csharp_Algorithms_lists.DictionaryBased.AssignmentInitializer(assignmentCnt, dicJobs.Count).CreateAssigns();

        sw.Start();
        var jobAssignemntLinker =
            new Csharp_Algorithms_lists.DictionaryBased.JobAssignmentLinker(dicJobs, dicAssignments); 
        
        Action act = () => jobAssignemntLinker.LinkItems();
        sw.Stop();
        act.Should().NotThrow<Exception>($"Code Executed in: {sw.Elapsed}");
    }
}