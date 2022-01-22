using System.Diagnostics;

const int jobsCnt = 10000;
const int assignmentCnt = 1000000;
const int resourcesCnt = 15000;

var sw = new Stopwatch();

Console.WriteLine("------------- Initializing data -------------");
sw.Start();
var arrayJobs = new Csharp_Algorithms_lists.ArrayBased.JobInitializer(jobsCnt).CreateJobs();
var arrayAssignments = new Csharp_Algorithms_lists.ArrayBased.AssignmentInitializer(assignmentCnt, arrayJobs.Length).CreateAssigns();
var arrayResources = new Csharp_Algorithms_lists.ArrayBased.ResourceInitializer(resourcesCnt).CreateResources();

var dicJobs = new Csharp_Algorithms_lists.DictionaryBased.JobInitializer(jobsCnt).CreateJobs();
var dicAssignments = new Csharp_Algorithms_lists.DictionaryBased.AssignmentInitializer(assignmentCnt, dicJobs.Count).CreateAssigns();
var dicResources = new Csharp_Algorithms_lists.DictionaryBased.ResourceInitializer(resourcesCnt).CreateResources();
sw.Stop();
Console.WriteLine($"Data initialized in: {sw.ElapsedMilliseconds} ms");

sw.Reset();

Console.WriteLine($"{jobsCnt * 2} Jobs created");
Console.WriteLine($"{assignmentCnt * 2} assignments created");
Console.WriteLine($"{resourcesCnt * 2} resources created");
Console.WriteLine("");

sw.Start();
new Csharp_Algorithms_lists.DictionaryBased.JobAssignmentLinker(dicJobs, dicAssignments).LinkItems();
sw.Stop();

Console.WriteLine("------------------ Dictionaries ---------------------");
Console.WriteLine($"Jobs and assignments linked in: {sw.Elapsed} ms");
sw.Reset();

sw.Start();
new Csharp_Algorithms_lists.ArrayBased.JobAssignmentLinker(arrayJobs, arrayAssignments).LinkItems();
sw.Stop();

Console.WriteLine("------------------ Arrays ---------------------");
Console.WriteLine($"Jobs and assignments linked in: {sw.Elapsed} ms");
sw.Reset();

Console.WriteLine("");

Console.WriteLine("Press any key...");

Console.ReadKey();