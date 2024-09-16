# HashPref
Quick preformance test of hashing matricies. I compared individually adding vs using `HashCode.Combine()` together

```
BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4169/23H2/2023Update/SunValley3)
AMD Ryzen 3 5300G with Radeon Graphics, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100-preview.4.24267.66
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
```
| Method          | Mean     | Error    | StdDev   |
|---------------- |---------:|---------:|---------:|
| HashcodeAdd     | 61.12 ns | 0.485 ns | 0.453 ns |
| HashCodeCombine | 28.11 ns | 0.561 ns | 0.525 ns |
