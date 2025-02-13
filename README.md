
# Examination System
The **Examination System** is a modern desktop application built using **C# and SQL Server**, designed to facilitate online exams for students while enabling instructors to manage courses, students, and assessments efficiently.

This system features a **modern UI design** and offers two interfaces:

### 🧑‍🎓 Student Interface
- 📘 View enrolled courses
- 📊 Access a personal dashboard with personal information
- ✍️ Take exams
- ✅ View exam results

### 🎓 Instructor Interface
- 📋 Dashboard for quick access to key data
- 📝 Generate exams for assigned courses
- 📝 Generate multiple model exams for the same course
- 🧾 Use multiple database reports 

## 🛠️ Technologies Used
- **C# (.NET Framework/.NET Core)** – for the application logic
- **SQL Server** – for database management
- **Framework** – .NET 9 Framework
- **WinForms** – for the modern UI design

## 🏗️ Database Structure
The system follows a well-structured **Enhanced ERD (Entity-Relationship Diagram)**, ensuring efficient data storage and management. The database includes tables for:
- **Users** (Students & Instructors)
- **Courses & Tracks**
- **Exams & Questions**
- **Student Exam Results**

<p align="center">
   <img src="Github%20Images/Enhanced ERD.png" alt="Mapping" width="500">
</p>

<p align="center">
   <span>Mapping Diagram</span>
   <br/>
   <img src="Github%20Images/Mapping.png" alt="Mapping" width="500">
</p>


## 🚀 Features
### 🧑‍🎓 Student Capabilities

✔ View enrolled courses

✔ Take exams with multiple question types

✔ View exam results and performance analytics

✔ Access a personalized dashboard  

### 🏫 Instructor Capabilities

✔ Generate exams for assigned courses only

✔ Access a dashboard for insights  

✔ Generate multiple model exams for the same course

✔ Use report that returns the students information according to track number

✔ Use report that takes the student ID and returns the grades of the student in all courses

✔ Use report that takes the instructor ID and returns the name of the courses that he teaches and the number of student per course

✔ Use report that takes course ID and returns its topics

✔ Use report that takes exam number and returns the Questions in it and chocies to be printed

✔ Use report that takes exam number and the student ID then returns the Questions in this exam with the student answers


## 🔧 Installation & Setup
1. **Clone the repository:**
   ```sh
   git clone https://github.com/ibr0him/Examination-System
   cd Examination System
   ```
2. Open the project in **Visual Studio 2022**.
3. Run the application and log in as **Instructor** or **Student**.

## 📷 Student Interface

   <img src="Github%20Images/Student HomePage.PNG">
   <img src="Github%20Images/Student Personal Info.PNG">
   <img src="Github%20Images/Student ExamPage.PNG">

## 📷 Instructor Interface

   <img src="Github%20Images/Instructor HomePage.PNG">
   <img src="Github%20Images/Instructor PersonalPage.PNG">
   <img src="Github%20Images/Instructor GenerateExam.PNG">
   <img src="Github%20Images/Instructor ViewExams.PNG">
   <img src="Github%20Images/Instructor ReportPage.png">

---
