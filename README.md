🧠 Console App for Data Manipulation in Temporary Session Memory

A lightweight C# Console Application that demonstrates data manipulation operations — such as adding, updating, deleting, and retrieving records — all stored in temporary in-memory session storage (not persisted to a database).

This project is ideal for understanding runtime memory management, session-based data handling, and CRUD logic implementation in a simple console environment.

---------------------------------------

📋 Overview

This console app simulates how data can be temporarily managed during a running session — similar to session objects or caching systems in web applications.

Data is stored in memory (using generic collections like List<T> or dictionaries) and is cleared when the application ends.

It’s perfect for experimenting with:

Runtime data operations

Memory-only session management

Simulation of database-like CRUD logic

------------------------------

🚀 Features

⚙️ In-Memory Data Storage – Data is stored only during the active session

🧮 CRUD Operations – Create, Read, Update, Delete items dynamically

🧠 Session Memory Simulation – Mimics session lifetime like in web apps

🔄 ID Auto-generation – Each item gets a unique ID

🧾 Search and Filter Support – Find items using conditions

🧹 Auto-clear Memory – Data resets after the app exits

-----------------------------------

🧩 Technologies Used
| Component        | Description                   |
| ---------------- | ----------------------------- |
| **Language**     | C#                            |
| **Framework**    | .NET 6 / .NET 7 (Console App) |
| **Data Storage** | In-memory (List, Dictionary)  |
| **IDE**          | Visual Studio / VS Code       |

-----------------------------------

💡 Key Concepts Demonstrated

Data stored in volatile memory (no persistence)

Simulated session-like lifetime

CRUD implementation using C# Lists

Real-world console input/output handling

Clean separation of logic via services

----------------------------------------

🧠 Future Enhancements

💾 Optional persistence to JSON or SQLite

⏳ Auto-expiring records (session timeout simulation)

🧪 Unit testing for session operations

🧍 User authentication for multi-session simulation
