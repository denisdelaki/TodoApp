# Simple Console Todo App

A minimalist command-line todo list application built with C# as part of the Moringa AI Capstone Project. This project demonstrates C# fundamentals including collections, control flow, user input handling, and basic CRUD operations - all through an interactive terminal interface.

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation & Setup](#installation--setup)
- [How to Run](#how-to-run)
- [Usage Guide](#usage-guide)
- [Project Structure](#project-structure)
- [Learning Journey](#learning-journey)
- [Technologies Used](#technologies-used)
- [Author](#author)

---

## 🎯 About the Project

This console-based Todo application was developed as part of the **Moringa AI Capstone Project: Beginner's Toolkit with GenAI** (September 29 - October 2, 2025). The project demonstrates learning C# fundamentals using AI-assisted learning techniques.

### Project Context

As a junior frontend developer with experience in Angular, JavaScript, and TypeScript, this project represents my journey into C# backend development. The goal was to:
- Learn C# fundamentals through hands-on coding
- Understand the transition from JavaScript/TypeScript to C#
- Build a foundation for .NET backend development
- Leverage GenAI tools to accelerate the learning process

### What It Does

The application provides a simple, interactive terminal interface for managing daily tasks. Users can add new todos, mark them as complete/incomplete, delete tasks, and view their todo list - all without leaving the command line.

---

## ✨ Features

- ✅ **Add new tasks** - Create todos with custom text
- ✅ **Mark tasks complete** - Toggle completion status with visual checkmarks
- ✅ **Remove tasks** - Delete completed or unwanted todos
- ✅ **Interactive menu** - Easy-to-navigate terminal interface
- ✅ **Real-time updates** - Screen refreshes after each action
- ✅ **Input validation** - Safe number parsing prevents crashes
- ✅ **Visual feedback** - Clear status indicators (`[✓]` vs `[ ]`)

---

## 📦 Prerequisites

Before running this project, ensure you have the following installed on your machine:

### Required Software

#### 1. .NET SDK (Required)
- **Version:** .NET 6.0 or higher (tested with .NET 8.0)
- **Download:** [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
- **Purpose:** Required to compile and run C# applications

**Check if installed:**
```bash
dotnet --version
Expected output: 6.0.xxx or higher
2. Operating System

Windows: Windows 10 or later
macOS: macOS 10.15 (Catalina) or later
Linux: Ubuntu 20.04+, Debian 10+, Fedora 32+, or equivalent

3. Terminal/Command Line

Windows: Command Prompt, PowerShell, or Windows Terminal
macOS/Linux: Built-in Terminal application

Optional (Recommended for Development)
Code Editor
While not required to run the application, you may want a code editor if you plan to modify the code:

Visual Studio Code (Recommended for beginners)

Download: https://code.visualstudio.com
Install the C# Dev Kit extension for enhanced C# support


Visual Studio Community (Windows)

Download: https://visualstudio.microsoft.com/vs/community/
Full-featured IDE with built-in C# support


JetBrains Rider

Download: https://www.jetbrains.com/rider/
Professional IDE (paid, with free trial)




🚀 Installation & Setup
Step 1: Install .NET SDK
For Windows:

Download the .NET SDK installer from https://dotnet.microsoft.com/download
Run the installer and follow the installation wizard
Restart your terminal after installation

For macOS:
bash# Option 1: Download from website
# Visit https://dotnet.microsoft.com/download

# Option 2: Use Homebrew
brew install --cask dotnet-sdk
For Linux (Ubuntu/Debian):
bash# Download installation script
wget https://dot.net/v1/dotnet-install.sh

# Make it executable
chmod +x dotnet-install.sh

# Install .NET 8.0
./dotnet-install.sh --channel 8.0
Verify Installation:
bashdotnet --version
You should see a version number (e.g., 8.0.100)
Step 2: Download the Project
Option A: Clone from GitHub
bashgit clone https://github.com/yourusername/simple-todo-app.git
cd simple-todo-app
Option B: Download ZIP

Download the project ZIP file
Extract to your desired location
Open terminal and navigate to the project folder:

bashcd path/to/simple-todo-app
Step 3: Verify Project Structure
Your project folder should contain:
simple-todo-app/
├── Program.cs          # Main application code
├── TodoApp.csproj      # Project configuration file
├── README.md           # This file
└── obj/                # Build artifacts (auto-generated)

🎮 How to Run
Quick Start

Open your terminal
Navigate to the project directory:

bash   cd path/to/simple-todo-app

Run the application:

bash   dotnet run
That's it! The application will launch immediately.
Alternative: Build and Run Separately
bash# Build the project first
dotnet build

# Then run the compiled application
dotnet run
Expected Output on Launch
=== TODO APP ===

No todos yet!

1. Add todo
2. Mark done
3. Remove todo
4. Exit

Choice:

📖 Usage Guide
Adding a Todo

Select option 1 from the menu
Enter your todo text
Press Enter

Example:
Choice: 1
Enter todo: Learn C# fundamentals
Viewing Todos
Todos are automatically displayed at the top of the screen after each action:
=== TODO APP ===

1. [ ] Learn C# fundamentals
2. [ ] Build a console app
3. [✓] Install .NET SDK

[ ] = Incomplete task
[✓] = Completed task

Marking a Todo as Done/Undone

Select option 2 from the menu
Enter the number of the todo you want to toggle
Press Enter

Example:
Choice: 2
Enter number: 1
The todo will switch between complete and incomplete status.
Removing a Todo

Select option 3 from the menu
Enter the number of the todo you want to delete
Press Enter

Example:
Choice: 3
Enter number: 2
The todo will be permanently removed from the list.
Exiting the Application

Select option 4 from the menu
The application will display "Goodbye!" and close

Example:
Choice: 4
Goodbye!

📁 Project Structure
simple-todo-app/
│
├── Program.cs              # Main application file
│   ├── Data structure: List<(string task, bool done)>
│   ├── Main loop: while (true)
│   ├── Menu display logic
│   ├── User input handling
│   └── CRUD operations
│
├── TodoApp.csproj          # Project configuration
│   ├── Target framework: net8.0
│   ├── Output type: Exe
│   └── Dependencies
│
├── README.md               # Documentation (this file)
│
├── obj/                    # Build artifacts (auto-generated)
│   └── [Compiler-generated files]
│
└── bin/                    # Compiled output (created after first build)
    └── Debug/
        └── net8.0/
            └── TodoApp.exe
Code Architecture
The application uses a single-file architecture with the following components:

Data Storage: List<(string task, bool done)>

Tuple-based collection storing task text and completion status
In-memory storage (data resets on restart)


Main Loop: while (true)

Continuously displays menu and processes user input
Exits only when user selects option 4


User Interface:

Console.Clear() - Clears screen for fresh display
Console.WriteLine() - Displays menu and todos
Console.ReadLine() - Captures user input


Operations:

Create: Add new todo to list
Read: Display todos with status indicators
Update: Toggle completion status
Delete: Remove todo from list




🎓 Learning Journey
This project was built using AI-assisted learning techniques as part of the Moringa AI Capstone Project. The complete learning journey, including:

Detailed AI prompts used
Step-by-step C# concepts learned
Comparisons with JavaScript/TypeScript
Common errors encountered and solutions
Reflections on AI-assisted learning

...can be found in the comprehensive Project Documentation PDF.
Key Concepts Demonstrated

Variables and Collections: List<T> and tuples
Control Flow: while loops, if-else statements
User Input: Console.ReadLine(), input validation
Type Safety: int.TryParse() for safe conversions
String Interpolation: $"Text {variable}"
Tuple Manipulation: Working with named tuples


🛠️ Technologies Used

Language: C# 12.0
Framework: .NET 8.0
Development Tools:

.NET SDK
Visual Studio Code (with C# Dev Kit)


AI Tools: Claude AI (ai.moringaschool.com) for learning assistance


👨‍💻 Author
Denis Kipyegon
Junior Frontend Developer | Learning C# & .NET

Background: 2 years experience with Angular, JavaScript, TypeScript
Learning Goal: Transition to full-stack development with C# backend
Project Duration: September 29 - October 2, 2025
GitHub: Your GitHub Profile
LinkedIn: Your LinkedIn


📝 License
This project was created for educational purposes as part of the Moringa School AI Capstone Project.

🙏 Acknowledgments

Moringa School - For the structured capstone project and learning framework
Claude AI - For AI-assisted learning and debugging support
Microsoft Documentation - For comprehensive C# and .NET resources
Moringa Instructors - For guidance and project requirements


📚 Additional Resources
If you're learning C# and found this project helpful, check out these resources:

Official C# Documentation: https://docs.microsoft.com/en-us/dotnet/csharp/
C# for JavaScript Developers: Microsoft Learn Path
Complete Project Documentation: View PDF

