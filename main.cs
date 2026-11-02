using System;
using System.Collections.Generic;

// 1. Variables & Basic Types
string developerName = "Alex";
int projectCount = 3;
double successRate = 98.5;
bool IsComplete = false;

// 2. String Interpolation & Console Output
Console.WriteLine($"Developer: {developerName}");
Console.WriteLine($"Projects: {projectCount} | Success Rate: {successRate}%");

// 3. Conditional Logic (If-Else)
if (successRate >= 90)
{
    Console.WriteLine("Performance status: Excellent");
}
else
{
    Console.WriteLine("Performance status: Needs Review");
}

// 4. Collections & Loops
var languages = new List<string> { "C#", "TypeScript", "Python" };

Console.WriteLine("\nSkills Inventory:");
foreach (var lang in languages)
{
    // Punchy, clean string output
    Console.WriteLine($" - Familiar with {lang}");
}

// 5. Instantiating a Class (OOP)
Console.WriteLine("\nInitializing Project Task...");
ProjectTask currentTask = new ProjectTask("Database Migration", 12);
currentTask.DisplayTaskDetails();


// ==========================================
// 6. Object-Oriented Concept (Class Definition)
// ==========================================
public class ProjectTask
{
    // Auto-implemented properties
    public string TaskName { get; set; }
    public int EstimatedHours { get; set; }

    // Constructor
    public ProjectTask(string taskName, int hours)
    {
        TaskName = taskName;
        EstimatedHours = hours;
    }

    // Method
    public void DisplayTaskDetails()
    {
        Console.WriteLine($"Task: '{TaskName}' requires approximately {EstimatedHours} hours.");
    }
}