// devblogs.microsoft.com/dotnet/performance-improvements-in-net-8/

using BenchmarkDotNet.Running;


//var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

var summary = BenchmarkRunner.Run(typeof(PerformanceDemo.BenchMarker.StringFunctions));

// var summary = BenchmarkRunner.Run(typeof(PerformanceDemo.BenchMarker.StringComparison));

//var summary = BenchmarkRunner.Run(typeof(PerformanceDemo.BenchMarker.StringComparisonWithCase));