# uProfiler
Configurable microprofiler for .NET

Simply wrap your code with 
```C#
using (new MicroProfiler("My operation"))
{
  // my code 
}
```
and see the result!

# Installaton

Install via NuGet 

# Features

* Configurable output targets (includes Console, DebugOutput, MultiTarget) but could by anything else - including DB
* Dependency-free

# Todo

* INameProvider for auto-filling Name (with source trace details etc.)
