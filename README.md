# String Comparison Benchmark in .NET Core

This repository contains a C# application designed to benchmark various string comparison methods using the BenchmarkDotNet library. The benchmarks aim to evaluate the performance and memory usage of different techniques for comparing strings in .NET Core applications.

## Key Features

- **BenchmarkDotNet Integration**: Leverages the powerful BenchmarkDotNet library to provide detailed performance metrics, including execution time and memory allocation.
- **String Comparison Focus**: Compares different methods for string comparison (such as `string.Equals`, `==`, and `Compare`) to determine the most efficient approach in various scenarios.
- **Memory Diagnoser**: Includes a memory diagnoser to measure and report on the memory usage of each benchmarked method.
- **Custom Ordering**: Results are ordered from the fastest to the slowest method, making it easy to identify the best-performing string comparison technique.

## Getting Started

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/nvdsar/StringComparer.git
   ```
2. **Build the Project**:

   Make sure to build in Release mode for accurate benchmarking results:

   ```bash
   dotnet build -c Release
   ```
3. **Run the Benchmarks**:

   Execute the benchmarks from the command line to avoid attaching a debugger:

   ```bash
   dotnet run -c Release
   ```
   ## Requirements

- .NET Core SDK 3.1 or later
- BenchmarkDotNet library (included in the project dependencies)

## Contributions

Feel free to fork this repository, make improvements, and submit pull requests. Contributions are welcome to add more string comparison methods or optimize the existing benchmarks.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
