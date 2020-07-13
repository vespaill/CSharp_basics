# [C# Basics for Beginners: Learn C# Fundamentals by Coding](https://www.udemy.com/course/csharp-tutorial-for-beginners/)


#### C# vs .NET
- C# is a programming language.
- .NET is a framework for building applicaitons on Windows.

#### .NET
- CLR (Common Language Runtime).
- Class Library.

#### Architecture of .NET applications.
- Applications consist of building blocks called Classes.
- A Class is a container for data and methods.
- A Namespace is a container for related classes.
- An Assembly is a container for related Namespaces (A .dll or .exe file).

#### Compiling and running
- Add `C:\Windows\Microsoft.NET\Framework\v3.5` to your `PATH`  environment variables.

- Invoke the C# compiler to generate an executable:

      csc -out:helloWorld.exe .\helloWorld.cs

- Run the executable:

      .\helloWorld.exe