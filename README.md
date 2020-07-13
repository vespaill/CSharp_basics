<link rel="stylesheet" type="text/css" media="all" href="markdown_styles.css" />

<a href="https://www.udemy.com/course/csharp-tutorial-for-beginners/" target="_blank"><h1>C# Basics for Beginners: Learn C# Fundamentals by Coding</h1></a>

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

- Add `C:\Windows\Microsoft.NET\Framework\v3.5` to your `PATH` environment variables.

- Invoke the C# compiler to generate an executable:

      csc -out:helloWorld.exe .\helloWorld.cs

- Run the executable:

      .\helloWorld.exe

#### Variables / Constants

- Variable: a name given to a storage location in memory.
- Constant: an immutable value.

#### Naming Conventions

- For local variables use Camel Case: `int curVal;`
- For constants use Pascal Case: `const int MaxZoom = 5;`

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables" target="_blank"><h4>Primitive Types</h4></a>
<table>
  <caption>Commonly used Primitive Types</caption>
  <tr>
    <th></th>
    <th>C# Type</th>
    <th>.NET Type</th>
    <th>Bytes</th>
    <th>Range</th>
  </tr>
  <tr>
    <td>Integral Numbers</td>
    <td>byte</td>
    <td>Byte</td>
    <td>1</td>
    <td>0 to 255</td>
  </tr>
  <tr>
    <td></td>
    <td>short</td>
    <td>Int16</td>
    <td>2</td>
    <td>-32,768 to 32,767</td>
  </tr>
  <tr>
    <td></td>
    <td>int</td>
    <td>Int32</td>
    <td>4</td>
    <td>-2.1B to 2.1B</td>
  </tr>
  <tr>
    <td></td>
    <td>long</td>
    <td>Int64</td>
    <td>8</td>
    <td>...</td>
  </tr>
  <tr>
    <td>Real Numbers</td>
    <td>float</td>
    <td>Single</td>
    <td>4</td>
    <td>-3.4&times;10<sup>38</sup> to 3.4&times;10<sup>38</sup></td>
  </tr>
  <tr>
    <td></td>
    <td>double</td>
    <td>Double</td>
    <td>8</td>
    <td>...</td>
  </tr>
  <tr>
    <td></td>
    <td>decimal</td>
    <td>Decimal</td>
    <td>16</td>
    <td>-7.9&times;10<sup>28</sup> to 7.9&times;10<sup>28</sup></td>
  </tr>
  <tr>
    <td>Character</td>
    <td>char</td>
    <td>Char</td>
    <td>2</td>
    <td>Unicode Characters</td>
  </tr>
  <tr>
    <td>Boolean</td>
    <td>bool</td>
    <td>Boolean</td>
    <td>1</td>
    <td>True / False</td>
  </tr>
</table>

- **double** is the default data type used by CSharp compilers when using real numbers
- To declare a float or a decimal, explicitly tell the compiler to treat the number as such by placing a suffix `f` or `m`.

      float number = 1.2f
      decimal number = 1.2m

#### Non-Primitive Types

- String
- Array
- Enum
- Class

#### Overflowing

    byte number = 255;
    number++;
    Console.WriteLine(number);    // output is 0 due to overflow

- Prevent overflow at runtime and throw exception:

       checked
       {
           byte number = 255;
           number++;
       }

#### Type Conversion
- Implicit type conversion (no data loss):

      byte b = 1;                              00000001
      int i = b;    00000000 00000000 00000000 00000001

- Another example of implicit type conversion:

      int i = 1;
      float f = i;

- Won't compile because there is data loss:

      int i = 1;
      byte b = i;

- Need to explicity tell the compiler that you're aware of data loss and you still want to convert it (casting):

      int i = 1;
      byte b = (byte)i;

      float f = 1.0f;
      int i = (int)f;

- Non-compatible types cannot be casted:

      string s = "1";
      int i = (int)s;    // won't compile

- Need to convert or parse them instead:

      string s = "1";
      int i = Convert.ToInt32(s);
      int j = int.Parse(s);