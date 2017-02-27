# twc-training-oop-fundamentals
A training exercise for Troy Web Consulting pertaining to fundamental object oriented concepts

Since this is a console application, a prompt has been added to the end of `Program.cs` to detect if the program is running in debug mode. If can detect that it is running in debug, it will not shut down until you hit your `enter` key or restart your debugger.

## Installation
First, please clone the project with the `git clone https://github.com/xueye/twc-training-oop-fundamentals.git` command and store it to your local machine.

You will need to install [.NET Core](https://www.microsoft.com/net/core) to run this project, however it will run on both Windows and Mac!

You will also need to install the [.NET Core 1.1 SDK](https://go.microsoft.com/fwlink/?LinkID=835014) **after** that.

### Windows Instructions (Visual Studio)
1. After installing .NET Core, open Visual Studio
2. From the Menu, go to `File` -> `Open / Project/Solution`
3. Navigate to the `twc-training-oop-fundamentals.sln` file in the repository, and open it
4. Allow it to install all the dependencies (may take awhile!)
5. Build the project
6. Run it!

### OSX Instructions
1. After installing .NET Core, refresh your terminal
2. Navigate in a terminal to your project directory for the `twc-training-oop-fundamentals` project
3. run `dotnet restore`
4. run `dotnet run`
