// vscode snippets
// cl-> class FileName {}
// svm-> static void Main(string[] args) (only when inside a class or struct)
// cw-> System.Console.WriteLine();
// wl-> Console.WriteLine(); (my own snippet)

using System.Linq.Expressions;

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
            int curAssignments = 5;

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
            decimal sophiaScore = (decimal)sophiaSum / curAssignments;
            decimal nicolasScore = (decimal)nicolasSum / curAssignments;
            decimal zahirahScore = (decimal)zahirahSum / curAssignments;
            decimal jeongScore = (decimal)jeongSum / curAssignments;

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

            Console.WriteLine("\n############################ If/else challenge\n");

            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration < 1)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration}.\nRenew now and save 10%!");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }

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
                Console.WriteLine();
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

            string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            // change an elements value
            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            // array initialisation
            string[] fraudulentOrderIDs2 = ["A123", "B456", "C789"];
            Console.WriteLine($"There are {fraudulentOrderIDs2.Length} fraudulent orders to process.");

            // looping through array with foreach
            string[] names = ["Rowena", "Robin", "Bao"];
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            int[] inventory = [200, 450, 700, 175, 250];
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");

            Console.WriteLine("\n############################ Nested Iteration\n");
            string[] fraudulentOrderID3 = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
            foreach (string s in fraudulentOrderID3)
            {
                if (s.StartsWith("B"))
                {
                    Console.WriteLine($"The name {s} starts with 'B'!");
                }
            }

            Console.WriteLine("\n############################ Code Readability\n");

            /*
                This code reverses a message, counts the number of times 
                a particular character appears, then prints the results
                to the console window.
             */

            string originalMessage = "The quick brown fox jumps over the lazy dog.";

            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }

            string newMessage = new String(message);

            Console.WriteLine(originalMessage);
            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");

            Console.WriteLine("\n############################ Calc Student Scores Simply\n");

            // initialize variables - graded assignments 
            int currentAssignments = 5;

            sophia1 = 90;
            sophia2 = 86;
            sophia3 = 87;
            sophia4 = 98;
            sophia5 = 100;

            int andrew1 = 92;
            int andrew2 = 89;
            int andrew3 = 81;
            int andrew4 = 96;
            int andrew5 = 90;

            int emma1 = 90;
            int emma2 = 85;
            int emma3 = 87;
            int emma4 = 98;
            int emma5 = 68;

            int logan1 = 90;
            int logan2 = 95;
            int logan3 = 87;
            int logan4 = 88;
            int logan5 = 96;

            sophiaSum = 0;
            int andrewSum = 0;
            int emmaSum = 0;
            int loganSum = 0;

            decimal andrewScore;
            decimal emmaScore;
            decimal loganScore;

            sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
            emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
            loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

            sophiaScore = (decimal)sophiaSum / currentAssignments;
            andrewScore = (decimal)andrewSum / currentAssignments;
            emmaScore = (decimal)emmaSum / currentAssignments;
            loganScore = (decimal)loganSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
            Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
            Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("\n############################ Calc Student Scores Using Arrays, Foreach & Function\n");

            int[] sophiaScoresArr = [90, 86, 87, 98, 100];
            int[] andrewScoresArr = [92, 89, 81, 96, 90];
            int[] emmaScoresArr = [90, 85, 87, 98, 68];
            int[] loganScoresArr = [90, 95, 87, 88, 96];

            sophiaScore = getStudentScore(sophiaScoresArr, sophiaScoresArr.Length, currentAssignments);
            andrewScore = getStudentScore(andrewScoresArr, andrewScoresArr.Length, currentAssignments);
            emmaScore = getStudentScore(emmaScoresArr, emmaScoresArr.Length, currentAssignments);
            loganScore = getStudentScore(loganScoresArr, loganScoresArr.Length, currentAssignments);

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\t?");
            Console.WriteLine("Andrew:\t\t" + andrewScore + "\t?");
            Console.WriteLine("Emma:\t\t" + emmaScore + "\t?");
            Console.WriteLine("Logan:\t\t" + loganScore + "\t?");

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("\n############################ Extra Credits\n");

            // existing students, appending extra credits
            sophiaScoresArr = myAppendArr(sophiaScoresArr, [94, 90], "sophia");
            andrewScoresArr = myAppendArr(andrewScoresArr, [89], "andrew");
            emmaScoresArr = myAppendArr(emmaScoresArr, [89, 89, 89], "emma ");
            loganScoresArr = myAppendArr(loganScoresArr, [96], "logan");
            // new students just added
            int[] beckyScoresArr = new int[] { 92, 91, 90, 91, 92, 92, 92 };
            int[] chrisScoresArr = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
            int[] ericScoresArr = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
            int[] gregorScoresArr = new int[] { 91, 91, 91, 91, 91, 91, 91 };

            // existing students (tuple returns!)
            Console.WriteLine("Student\t\tGrade\tGrade Letter");
            (decimal sophiaGrade, string sophiaLetterGrade) = getStudentGrade(sophiaScoresArr);
            Console.WriteLine($"sophia\t\t{sophiaGrade}\t{sophiaLetterGrade}");
            (decimal andrewGrade, string andrewLetterGrade) = getStudentGrade(andrewScoresArr);
            Console.WriteLine($"sophia\t\t{andrewGrade}\t{andrewLetterGrade}");
            (decimal emmaGrade, string emmaLetterGrade) = getStudentGrade(emmaScoresArr);
            Console.WriteLine($"emma\t\t{emmaGrade}\t{emmaLetterGrade}");
            (decimal loganGrade, string loganLetterGrade) = getStudentGrade(loganScoresArr);
            Console.WriteLine($"logan\t\t{loganGrade}\t{loganLetterGrade}");

            // new students (tuple returns!)
            (decimal beckyGrade, string beckyLetterGrade) = getStudentGrade(beckyScoresArr);
            Console.WriteLine($"becky\t\t{beckyGrade}\t{beckyLetterGrade}");
            (decimal chrisGrade, string chrisLetterGrade) = getStudentGrade(chrisScoresArr);
            Console.WriteLine($"chris\t\t{chrisGrade}\t{chrisLetterGrade}");
            (decimal ericGrade, string ericLetterGrade) = getStudentGrade(ericScoresArr);
            Console.WriteLine($"eric\t\t{ericGrade}\t{ericLetterGrade}");
            (decimal gregorGrade, string gregorLetterGrade) = getStudentGrade(gregorScoresArr);
            Console.WriteLine($"gregor\t\t{gregorGrade}\t{gregorLetterGrade}");

            Console.WriteLine("\n\rPress the Enter key to continue");
            Console.ReadLine();
        }

        // tuple return type (tuple can contain different types)
        static (decimal, string) getStudentGrade(int[] studentScores)
        {
            int examAssignments = 5;
            int sumAssignmentScores = 0;
            int gradedAssignments = 0;
            string currentStudentLetterGrade = "Z";

            foreach (int score in studentScores)
            {
                gradedAssignments += 1;
                if (gradedAssignments <= examAssignments)
                    // add the exam score to the sum
                    sumAssignmentScores += score;
                else
                    // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                    sumAssignmentScores += score / 10;
            }
            // initialize/reset the calculated average of exam + extra credit scores
            decimal currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";

            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";

            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";

            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";

            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";

            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";

            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";

            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";

            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";

            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";

            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";

            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F";

            return (currentStudentGrade, currentStudentLetterGrade);

        }

        static void printArray(int[] arr)
        {
            foreach (int e in arr)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }

        // append an array by converting it to a list and concatenting a new list onto it.
        //
        // arrays are passed by reference to functions. the reference is COPIED (ie:
        // "refFuncLocal" stores the same "address" as "refArgIn") - "refFuncLocal" and
        // "refArgIn" reference the SAME object and we can change this object in and out
        // of the function. but if we CHANGE what "refFuncLocal" is referencing, then 
        // the change won't be seen outwith the function by "refArgIn" 
        static int[] myAppendArr(int[] arrIn, int[] newVals, string name)
        {
            var list = arrIn.ToList();
            List<int> tempAdd = [.. newVals]; // spread operator 
            Console.Write($"{name}'s original scores:\t");
            list.ForEach(e => Console.Write(e + " "));  // lambda
            Console.WriteLine();
            list.AddRange(tempAdd);
            // arrIn is "refFuncLocal" and it's getting reassigned here. "refFuncLocal"
            // and "refArgIn" are now referencing different arrays. the appending of 
            // "refFuncLocal" will not be seen outwith this function by "refArgIn"!
            //arrIn = list.ToArray(); 
            var arrOut = list.ToArray();
            Console.Write($"{name}'s extra credit scores:\t");
            printArray(arrOut);
            Console.WriteLine();
            return arrOut;
        }

        static decimal getStudentScore(int[] arr, int len, int curAss)
        {
            int sum = 0;
            foreach (int e in arr)
            {
                sum += e;
            }
            return (decimal)sum / curAss;
        }

    }
}