int examAssignments = 5;

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

int[] sophiaScores = [90, 86, 87, 98, 100];
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScores = [90, 95, 87, 88, 96];

int[] studentScores = new int[10];

string studentLetterGrade = "";

Console.WriteLine(@"Student     Grade");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    // Assignment credits are 10% of exam grade

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)
    (sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        studentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        studentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        studentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        studentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        studentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        studentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        studentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        studentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        studentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        studentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        studentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        studentLetterGrade = "D-";
    else
        studentLetterGrade = "F";

    Console.WriteLine($@"{currentStudent}        {currentStudentGrade}   {studentLetterGrade}");
}

Console.WriteLine("Press enter key to continue");
Console.ReadLine();