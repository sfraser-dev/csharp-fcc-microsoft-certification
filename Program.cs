// cw-> System.Console.WriteLine();
// psm-> static void Main(string[] args)
// cl-> class FileName {}

string calcGrade(decimal val)
{
    if (val >= 97.0m)
    {
        return "A+";
    }
    else if (val >= 93.0m)
    {
        return "A";
    }
    else if (val >= 90.0m)
    {
        return "A-";
    }
    else if (val >= 87.0m)
    {
        return "B+";
    }
    else if (val >= 83.0m)
    {
        return "B";
    }
    else
    {
        return "error";
    }
}

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophiaSum = 0;
int nicolasSum = 0;
int zahirahSum = 0;
int jeongSum = 0;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum + "\n");

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t " + sophiaScore + "\t" + calcGrade(sophiaScore));
Console.WriteLine("Nicolas:\t " + nicolasScore + "\t" + calcGrade(nicolasScore));
Console.WriteLine("Zahirah:\t " + zahirahScore + "\t" + calcGrade(zahirahScore));
Console.WriteLine("Jeong:\t\t " + jeongScore + "\t" + calcGrade(jeongScore));

Console.WriteLine("\n######################################\n");

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

// System.Console.WriteLine($"{course1Name} {course1Grade}");
// System.Console.WriteLine($"{course2Name} {course2Grade}");
// System.Console.WriteLine($"{course3Name} {course3Grade}");
// System.Console.WriteLine($"{course4Name} {course4Grade}");
// System.Console.WriteLine($"{course5Name} {course5Grade}");

// System.Console.WriteLine($"{totalGradePoints} {totalCreditHours}");
decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;
int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");

// System.Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
// System.Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
// System.Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
// System.Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
// System.Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

// // System.Console.WriteLine($"Final GPA: {gradePointAverage}");
// System.Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");

decimal x = 7 / 5;
Console.WriteLine($"x={x}");

Console.WriteLine("\n######################################\n");

Random dice1 = new Random();
int roll1 = dice1.Next(1, 7);
Console.WriteLine($"roll1 = {roll1}");
Random dice2 = new();
int roll2 = dice2.Next(1, 7);
Console.WriteLine($"roll2 = {roll2}");

Random dice3 = new Random();
int roll3 = dice3.Next();
int roll4 = dice3.Next(101);
int roll5 = dice3.Next(50, 101);

Console.WriteLine($"roll3: {roll3}");
Console.WriteLine($"roll4: {roll4}");
Console.WriteLine($"roll5: {roll5}");

Console.WriteLine("\n######################################\n");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);

Console.WriteLine("\n######################################\n");

Random dice4 = new();

int roll6 = dice4.Next(1, 7);
int roll7 = dice4.Next(1, 7);
int roll8 = dice4.Next(1, 7);

int total = roll6 + roll7 + roll8;
Console.WriteLine($"Dice roll: {roll6} + {roll7} + {roll8} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

