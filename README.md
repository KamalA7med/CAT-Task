## 1. 📋 Task: To-Do List Mini-Project

This is a comprehensive C# Console Application designed to manage and track user tasks, emphasizing modular design and file persistence.

### Key Features and Architecture:

* **Modular Architecture**: Logic is cleanly separated into specialized directories:
    * **`Classes/`**: Contains core business logic, including the `Task_Mangment_System` and `FileHandler` classes.
    * **`Screens/`**: Manages the user interface, with specific files like `Add_Taskk_Screen.cs` and `Print_Tasks_Screen.cs`.
* **Data Persistence**: Tasks are saved to and loaded from text files (`Tasks.txt` and `Completed_Tasks.txt`) using dedicated file handling logic.



---

## 2. 🧩 Task: Problem Solution

This section covers the solutions to specific technical challenges.

### A. Shortest String Algorithm (C#)

**Challenge:** Implement a function to identify and return the shortest string within a given list of strings.

* **Solution Logic:** The C# function iterates through the input list, comparing the length of each string to the current shortest string found so far.
* **Demonstration Data:** The function was tested using an input list that includes names like `"Kamal"`, `"Ali"`, `"Osama"`, `"Mohamed"`, and the single character `"O"`.
* **Result:** The solution correctly returns the shortest string, `"O"`.
* **Solution Location:** `DataBase/PS/Program.cs`.

### B. Student Grade Retrieval (SQL)

**Challenge:** Write the necessary SQL to set up a table and retrieve specific student records based on grade criteria.

* **Table Schema Used:** `StudentData` with columns for `student_id` (Primary Key), `name` (VARCHAR), and `grade` (INT).
* **Data Inserted:** Sample data includes students with grades: 98, 90, 80, and 93.
* **Retrieval Criteria:** Select all records where the grade is inclusively between 90 and 100.
* **Expected Output:** The query successfully selects students with grades 98, 90, and 93.
* **Solution Location:** `DataBase/SQLQuery2.sql`.
