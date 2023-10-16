// See https://aka.ms/new-console-template for more information
using System;
// Printer using singleton pattern
public sealed class Printer
{
    private static Printer? instance;

    private Printer() { }

    public static Printer Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Printer();
                Console.WriteLine("Printer instance created");
            }
            return instance;
        }
    }

    public void Print(string message)
    {
        Console.WriteLine($"Printing: {message}");
    }
}
// Exam interface
public abstract class Exam
{
    public abstract void Conduct();
    public abstract void Evaluate();
    public abstract void PublishResults();
}
// Different exams inheriting the methods in the exam interface
public class MathExam : Exam
{
    public override void Conduct()
    {
        Console.WriteLine("Conducting Math Exam");
    }

    public override void Evaluate()
    {
        Console.WriteLine("Evaluating Math Exam");
    }

    public override void PublishResults()
    {
        Console.WriteLine("Publishing Math Exam Results");
    }
}

public class ScienceExam : Exam
{
    public override void Conduct()
    {
        Console.WriteLine("Conducting Science Exam");
    }

    public override void Evaluate()
    {
        Console.WriteLine("Evaluating Science Exam");
    }

    public override void PublishResults()
    {
        Console.WriteLine("Publishing Science Exam Results");
    }
}

public class ProgrammingExam : Exam
{
    public override void Conduct()
    {
        Console.WriteLine("Conducting Programming Exam");
    }

    public override void Evaluate()
    {
        Console.WriteLine("Evaluating Programming Exam");
    }

    public override void PublishResults()
    {
        Console.WriteLine("Publishing Programming Exam Results");
    }
}

// Abstract Exam Factory to manage exam creation
public abstract class ExamFactory
{
    public abstract Exam CreateExam();
}

// Concrete Factories using the abstract method
public class MathExamFactory : ExamFactory
{
    public override Exam CreateExam()
    {
        return new MathExam();
    }
}

public class ScienceExamFactory : ExamFactory
{
    public override Exam CreateExam()
    {
        return new ScienceExam();
    }
}

public class ProgrammingExamFactory : ExamFactory
{
    public override Exam CreateExam()
    {
        return new ProgrammingExam();
    }
}


// Main Program
class Program
{
    static void Main()
    {
        // Singleton pattern ensures only one printer instance is used
        Printer printer1 = Printer.Instance;

        // Create a new printer object
        Printer printer2 = Printer.Instance;

        // Compare the two printer instances
        if (printer1 == printer2)
        {
            Console.WriteLine("printer1 and printer2 are the same.");
        }
        else
        {
            Console.WriteLine("printer1 and printer2 are different.");
        }

        // Abstract Factory pattern creates different types of exams
        ExamFactory mathFactory = new MathExamFactory();
        ExamFactory scienceFactory = new ScienceExamFactory();
        ExamFactory programmingFactory = new ProgrammingExamFactory();

        Exam mathExam = mathFactory.CreateExam();
        Exam scienceExam = scienceFactory.CreateExam();
        Exam programmingExam = programmingFactory.CreateExam();

        // Test the created exams
        mathExam.Conduct();
        mathExam.Evaluate();
        mathExam.PublishResults();

        scienceExam.Conduct();
        scienceExam.Evaluate();
        scienceExam.PublishResults();

        programmingExam.Conduct();
        programmingExam.Evaluate();
        programmingExam.PublishResults();
    }
}

