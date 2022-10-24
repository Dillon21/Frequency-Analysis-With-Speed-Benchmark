``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
12th Gen Intel Core i7-12700, 1 CPU, 20 logical and 12 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


```
|     Method |     Mean |    Error |   StdDev |     Gen0 | Allocated |
|----------- |---------:|---------:|---------:|---------:|----------:|
|  testFirst | 21.94 ms | 0.264 ms | 0.247 ms | 562.5000 |   7.29 MB |
| testSecond | 32.42 ms | 0.398 ms | 0.372 ms | 533.3333 |   7.29 MB |
|  testThird | 32.43 ms | 0.511 ms | 0.478 ms | 562.5000 |   7.29 MB |
