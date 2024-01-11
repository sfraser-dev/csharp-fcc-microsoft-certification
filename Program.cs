// vscode snippets
// cl-> class FileName {}
// svm-> static void Main(string[] args) (only when inside a class or struct)
// cw-> System.Console.WriteLine();

namespace Program
{
    class Prog
    {
        static string calcGrade(decimal val)
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
        static void Main(string[] args)
        {
            Console.WriteLine("\n############################ Calc Grades of Students\n");

            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;
            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            // average score
            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            // print the total score
            Console.WriteLine("Sophia: " + sophiaSum);
            Console.WriteLine("Nicolas: " + nicolasSum);
            Console.WriteLine("Zahirah: " + zahirahSum);
            Console.WriteLine("Jeong: " + jeongSum + "\n");

            // print average score and its corresponding grade in formatted table
            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t " + sophiaScore + "\t" + calcGrade(sophiaScore));
            Console.WriteLine("Nicolas:\t " + nicolasScore + "\t" + calcGrade(nicolasScore));
            Console.WriteLine("Zahirah:\t " + zahirahScore + "\t" + calcGrade(zahirahScore));
            Console.WriteLine("Jeong:\t\t " + jeongScore + "\t" + calcGrade(jeongScore));

            Console.WriteLine("\n############################ Calc Sophia's GPA\n");

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

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;
            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            // print Sophia's scores for each subject in a formatted table and calc final GPA
            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

            Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");

            Console.WriteLine("\n############################ Decimal Type\n");

            decimal x = 7 / 5;
            Console.WriteLine($"x={x}");

            Console.WriteLine("\n############################ Dice Game with Random and Next\n");

            // random values
            Random dice1 = new Random();
            int roll1 = dice1.Next(1, 7);           // between 1 and 7-1
            Console.WriteLine($"roll1 = {roll1}");
            Random dice2 = new();
            int roll2 = dice2.Next(1, 7);           // between 1 and 7-1

            Console.WriteLine($"roll2 = {roll2}");

            Random dice3 = new Random();
            int roll3 = dice3.Next();           // between 0 and Int32.MaxValue-1
            int roll4 = dice3.Next(101);        // between 0 and 101-1
            int roll5 = dice3.Next(50, 101);    // between 50 and 101-1

            Console.WriteLine($"roll3: {roll3}");
            Console.WriteLine($"roll4: {roll4}");
            Console.WriteLine($"roll5: {roll5}");

            // the dice game
            Random dice4 = new();
            int roll6 = dice4.Next(1, 7);
            int roll7 = dice4.Next(1, 7);
            int roll8 = dice4.Next(1, 7);

            int total = roll6 + roll7 + roll8;
            Console.WriteLine($"Values for dice rolls 6, 7 and 8: {roll6} + {roll7} + {roll8} = {total}");

            // bonus for rolling a treble?
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled a treble! +6 bonus to total!");
                total += 6;
            }
            // bonus for rolling a double?
            else if ((roll6 == roll7) || (roll7 == roll8) || (roll6 == roll8))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }
            else
            {
                Console.WriteLine("no doubles or trebles :(");
                System.Console.WriteLine();
            }

            // results of dice game
            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose.");
            }

            Console.WriteLine("\n############################ Math Max\n");

            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);

            Console.WriteLine("\n############################ Arrays\n");

            string[] fraudulentOrderIDs = new string[3];
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
        }
    }
}