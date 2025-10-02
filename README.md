# Simple Console Todo App
#loom video
https://www.loom.com/share/175a9de21d2a4d638a497fe7268d9a18?sid=2db03158-202a-4eb5-aa5b-f0bc23e0f5a9
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
- [License](#license)
- [Acknowledgments](#acknowledgments)

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
```
Expected output: `6.0.xxx` or higher

#### 2. Operating System
- **Windows:** Windows 10 or later
- **macOS:** macOS 10.15 (Catalina) or later
- **Linux:** Ubuntu 20.04+, Debian 10+, Fedora 32+, or equivalent

#### 3. Terminal/Command Line
- **Windows:** Command Prompt, PowerShell, or Windows Terminal
- **macOS/Linux:** Built-in Terminal application

### Optional (Recommended for Development)

#### Code Editor
While not required to run the application, you may want a code editor if you plan to modify the code:

- **Visual Studio Code** (Recommended for beginners)
  - Download: [https://code.visualstudio.com](https://code.visualstudio.com)
  - Install the **C# Dev Kit** extension for enhanced C# support

- **Visual Studio Community** (Windows)
  - Download: [https://visualstudio.microsoft.com/vs/community/](https://visualstudio.microsoft.com/vs/community/)
  - Full-featured IDE with built-in C# support

- **JetBrains Rider**
  - Download: [https://www.jetbrains.com/rider/](https://www.jetbrains.com/rider/)
  - Professional IDE (paid, with free trial)

---

## 🚀 Installation & Setup

### Step 1: Install .NET SDK

**For Windows:**
1. Download the .NET SDK installer from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Run the installer and follow the installation wizard
3. Restart your terminal after installation

**For macOS:**
```bash
# Option 1: Download from website
# Visit https://dotnet.microsoft.com/download

# Option 2: Use Homebrew
brew install --cask dotnet-sdk
```

**For Linux (Ubuntu/Debian):**
```bash
# Download installation script
wget https://dot.net/v1/dotnet-install.sh

# Make it executable
chmod +x dotnet-install.sh

# Install .NET 8.0
./dotnet-install.sh --channel 8.0
```

**Verify Installation:**
```bash
dotnet --version
```
You should see a version number (e.g., `8.0.100`)

### Step 2: Download the Project

**Option A: Clone from GitHub**
```bash
git clone https://github.com/yourusername/simple-todo-app.git
cd simple-todo-app
```

**Option B: Download ZIP**
1. Download the project ZIP file
2. Extract to your desired location
3. Open terminal and navigate to the project folder:
```bash
cd path/to/simple-todo-app
```

### Step 3: Verify Project Structure

Your project folder should contain:
```
simple-todo-app/
├── Program.cs          # Main application code
├── TodoApp.csproj      # Project configuration file
├── README.md           # This file
└── .gitignore          # Git ignore rules
```

---

## 🎮 How to Run

### Quick Start

1. **Open your terminal**

2. **Navigate to the project directory:**
   ```bash
   cd path/to/simple-todo-app
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

That's it! The application will launch immediately.

### Alternative: Build and Run Separately

```bash
# Build the project first
dotnet build

# Then run the compiled application
dotnet run
```

### Expected Output on Launch

```
=== TODO APP ===

No todos yet!

1. Add todo
2. Mark done
3. Remove todo
4. Exit

Choice: 
```

---

## 📖 Usage Guide

### Adding a Todo

1. Select option `1` from the menu
2. Enter your todo text
3. Press Enter

**Example:**
```
Choice: 1
Enter todo: Learn C# fundamentals
```

### Viewing Todos

Todos are automatically displayed at the top of the screen after each action:

```
=== TODO APP ===

1. [ ] Learn C# fundamentals
2. [ ] Build a console app
3. [✓] Install .NET SDK
```

- `[ ]` = Incomplete task
- `[✓]` = Completed task

### Marking a Todo as Done/Undone

1. Select option `2` from the menu
2. Enter the number of the todo you want to toggle
3. Press Enter

**Example:**
```
Choice: 2
Enter number: 1
```

The todo will switch between complete and incomplete status.

### Removing a Todo

1. Select option `3` from the menu
2. Enter the number of the todo you want to delete
3. Press Enter

**Example:**
```
Choice: 3
Enter number: 2
```

The todo will be permanently removed from the list.

### Exiting the Application

1. Select option `4` from the menu
2. The application will display "Goodbye!" and close

**Example:**
```
Choice: 4
Goodbye!
```

---

## 📁 Project Structure

```
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
├── .gitignore              # Git ignore rules
│
├── obj/                    # Build artifacts (auto-generated)
│   └── [Compiler-generated files]
│
└── bin/                    # Compiled output (created after first build)
    └── Debug/
        └── net8.0/
            └── TodoApp.exe
```

### Code Architecture

The application uses a **single-file architecture** with the following components:

1. **Data Storage:** `List<(string task, bool done)>`
   - Tuple-based collection storing task text and completion status
   - In-memory storage (data resets on restart)

2. **Main Loop:** `while (true)`
   - Continuously displays menu and processes user input
   - Exits only when user selects option 4

3. **User Interface:**
   - `Console.Clear()` - Clears screen for fresh display
   - `Console.WriteLine()` - Displays menu and todos
   - `Console.ReadLine()` - Captures user input

4. **Operations:**
   - **Create:** Add new todo to list
   - **Read:** Display todos with status indicators
   - **Update:** Toggle completion status
   - **Delete:** Remove todo from list

---

## 🎓 Learning Journey

This project was built using **AI-assisted learning** techniques as part of the Moringa AI Capstone Project. The complete learning journey includes:

- Detailed AI prompts used for learning
- Step-by-step C# concepts mastered
- Comparisons with JavaScript/TypeScript
- Common errors encountered and solutions
- Reflections on AI-assisted learning effectiveness

### Key Concepts Demonstrated

- **Variables and Collections:** `List<T>` and tuples
- **Control Flow:** `while` loops, `if-else` statements, `switch` cases
- **User Input:** `Console.ReadLine()`, input validation with `TryParse()`
- **Type Safety:** Explicit type declarations and safe conversions
- **String Interpolation:** Modern C# string formatting with `$""`
- **Tuple Manipulation:** Working with value tuples for simple data structures
- **CRUD Operations:** Create, Read, Update, Delete functionality

---

## 🛠️ Technologies Used

- **Language:** C# 12.0
- **Framework:** .NET 8.0
- **Development Environment:**
  - .NET SDK 8.0
  - Visual Studio Code with C# Dev Kit
- **Version Control:** Git & GitHub
- **AI Tools:** Claude AI (ai.moringaschool.com) for learning assistance
- **Documentation:** Markdown

---

## 👨‍💻 Author

**Denis Kipyegon**  
Junior Frontend Developer | Learning C# & .NET

- **Background:** 2 years experience with Angular, JavaScript, TypeScript
- **Previous Experience:** Ruby on Rails (MVC, CRUD, routing concepts)
- **Learning Goal:** Transition to full-stack development with C# backend
- **Project Duration:** September 29 - October 2, 2025
- **GitHub:** [github.com/yourusername](https://github.com/yourusername)
- **LinkedIn:** [linkedin.com/in/yourprofile](https://linkedin.com/in/yourprofile)

---

## 📝 License

This project was created for educational purposes as part of the Moringa School AI Capstone Project. Feel free to use this code for learning purposes.

---

## 🙏 Acknowledgments

- **Moringa School** - For the structured capstone project framework and learning resources
- **Claude AI** - For AI-assisted learning, debugging support, and code guidance
- **Microsoft Documentation** - For comprehensive C# and .NET documentation
- **Moringa Instructors** - For project guidance, requirements, and support
- **The Developer Community** - For inspiration and best practices

---

## 📚 Additional Resources

If you're learning C# and found this project helpful, check out these resources:

### Official Documentation
- **C# Documentation:** [https://docs.microsoft.com/en-us/dotnet/csharp/](https://docs.microsoft.com/en-us/dotnet/csharp/)
- **.NET Documentation:** [https://docs.microsoft.com/en-us/dotnet/](https://docs.microsoft.com/en-us/dotnet/)
- **C# Programming Guide:** [https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/)

### Learning Paths
- **C# for JavaScript Developers:** [Microsoft Learn](https://learn.microsoft.com/en-us/shows/csharp-101/)
- **Introduction to C#:** [Microsoft Learn Path](https://learn.microsoft.com/en-us/training/paths/csharp-first-steps/)
- **Build .NET Applications:** [Microsoft Learn](https://learn.microsoft.com/en-us/training/dotnet/)

### Community Resources
- **Stack Overflow - C# Tag:** [stackoverflow.com/questions/tagged/c%23](https://stackoverflow.com/questions/tagged/c%23)
- **C# Discord Community:** [discord.gg/csharp](https://discord.gg/csharp)
- **r/csharp Subreddit:** [reddit.com/r/csharp](https://reddit.com/r/csharp)

---

## 🐛 Common Issues & Troubleshooting

### Issue: "dotnet: command not found"

**Solution:**
- Ensure .NET SDK is installed: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
- Restart your terminal after installation
- Verify installation: `dotnet --version`

### Issue: "The type or namespace name 'System' could not be found"

**Solution:**
- Ensure you have the correct `using System;` statement at the top of Program.cs
- C# is case-sensitive - use `System` not `system`

### Issue: Build errors when running

**Solution:**
```bash
# Clean the build
dotnet clean

# Rebuild the project
dotnet build

# Run again
dotnet run
```

### Issue: Console window closes immediately

**Solution:**
- This shouldn't happen with this project as it waits for user input
- If it does, add `Console.ReadKey();` before your program exits

---

## 💬 Questions or Issues?

If you encounter any problems running this application:

1. **Check Prerequisites:** Ensure .NET SDK is installed (`dotnet --version`)
2. **Review Error Messages:** C# compiler errors are usually descriptive
3. **Check File Structure:** Ensure all files are in the correct locations
4. **Clean and Rebuild:** Try `dotnet clean` then `dotnet build`
5. **Contact:** Open an issue on GitHub or reach out directly

---

## 🔄 Future Enhancements

Potential features to add as you continue learning:

- [ ] File persistence (save/load todos from a file)
- [ ] Due dates for tasks
- [ ] Task priorities (high, medium, low)
- [ ] Task categories or tags
- [ ] Search and filter functionality
- [ ] Task descriptions
- [ ] Undo/Redo functionality
- [ ] Export to CSV or JSON
- [ ] Color-coded output
- [ ] Statistics (completed vs pending tasks)

---

## 📊 Project Statistics

- **Lines of Code:** ~50 (excluding comments and whitespace)
- **Development Time:** 4 days (Sept 29 - Oct 2, 2025)
- **Language:** C#
- **Framework:** .NET 8.0
- **Type:** Console Application
- **Complexity:** Beginner-friendly

---

## 🎯 Learning Outcomes

By building this project, I learned:

1. **C# Syntax Basics:**
   - Variable declarations and type system
   - Control structures (loops, conditionals)
   - String interpolation and formatting

2. **Collections:**
   - Working with `List<T>` generic collections
   - Using tuples for simple data structures
   - List manipulation (Add, Remove, indexing)

3. **Console I/O:**
   - Reading user input with `Console.ReadLine()`
   - Displaying output with `Console.WriteLine()`
   - Screen management with `Console.Clear()`

4. **Error Handling:**
   - Safe type conversion with `TryParse()`
   - Input validation
   - Boundary checking

5. **Development Workflow:**
   - Using .NET CLI tools
   - Project structure and organization
   - Version control with Git

---

**Built with ❤️ and AI assistance as part of learning C# fundamentals**

---

*Last Updated: October 2, 2025*
