//-- default vscode snippets
// cl-> class FileName {}
// svm-> static void Main(string[] args) (only when inside a class or struct)
// cw-> System.Console.WriteLine();

//-- my vscode snippets
// wl-> Console.WriteLine(""); 
// wi-> Console.WriteLine($"{val}"); 
// swl-> System.Console.WriteLine(""); 
// swi-> System.Console.WriteLine($"{val}"); 

namespace Program
{
    class Prog
    {
        // tuple return type (tuple can contain different types)
        static (decimal, string) getStudentGrade(int[] studentScores)
        {
            int examAssignments = 5;
            int sumAssignmentScores = 0;
            int gradedAssignments = 0;
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

            string currentStudentLetterGrade;
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
            Console.WriteLine("");
            Console.WriteLine("############################ Calc Grades of Students\n");

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

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Calc Sophia's GPA\n");

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

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ If/Else Challenge\n");

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

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Decimal Type\n");

            decimal x = 7 / 5;
            Console.WriteLine($"x={x}");

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Dice Game with Random and Next\n");

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

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Math Max\n");

            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine($"The two numbers are {firstValue} and {secondValue}");
            Console.WriteLine($"The largest is: {largerValue}");

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Arrays\n");

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
            foreach (int itms in inventory)
            {
                sum += itms;
                bin++;
                Console.WriteLine($"Bin {bin} = {itms} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Nested Iteration\n");
            string[] fraudulentOrderID3 = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
            foreach (string s in fraudulentOrderID3)
            {
                if (s.StartsWith("B"))
                {
                    Console.WriteLine($"The name {s} starts with 'B'!");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Code Readability\n");

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

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Calc Student Scores Simply\n");

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
            decimal andrewScore;
            decimal emmaScore;
            decimal loganScore;

            sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
            int emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
            int loganSum = logan1 + logan2 + logan3 + logan4 + logan5;
            sophiaScore = (decimal)sophiaSum / currentAssignments;
            andrewScore = (decimal)andrewSum / currentAssignments;
            emmaScore = (decimal)emmaSum / currentAssignments;
            loganScore = (decimal)loganSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
            Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
            Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Calc Student Scores Using Arrays, Foreach & Function\n");

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

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Student Extra Credits\n");

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

            Console.WriteLine("\nPress the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Boolean Expressions\n");

            // ternary operator with boolean expression
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");

            // boolean expressions
            string permission = "Admin|Manager";
            int level = 53;
            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }

            // looking for a number
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int tot = 0;
            bool found = false;
            foreach (int number in numbers)
            {
                tot += number;
                if (number == 42)
                    found = true;
            }
            if (found)
                Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {tot}");

            Console.WriteLine("\nPress the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Switch Statement\n");

            int employeeLevel = 100;
            string employeeName = "John Smith";
            string title;
            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }
            Console.WriteLine($"{employeeName}, {title}");

            // stock codes parse via switch
            string stockKeepingUnit = "01-MN-L";
            string[] product = stockKeepingUnit.Split('-');
            string type;
            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            string color;
            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            string size;
            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");

            Console.WriteLine("\nPress the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ For Loops\n");

            // fizzbuzz
            for (int i = 1; i < 101; ++i)
            {
                // index printed with "space" padding width 3
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine($"{i,3} - FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i,3} - Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine($"{i,3} - Buzz");
                else
                    Console.WriteLine($"{i,3}");
            }

            Console.WriteLine("\nPress the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Do While Statement\n");

            int hero = 10;
            int monster = 10;
            Random dice = new Random();
            do
            {
                int roll = dice.Next(1, 11);
                monster -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

                if (monster <= 0) continue;

                roll = dice.Next(1, 11);
                hero -= roll;
                Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

            Console.WriteLine("\nPress the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Project 1\n");

            // project 1
            string valueEnteredStr;
            Console.WriteLine("Enter an integer value between 5 and 10");
            int numValue;
            bool isValidNumber;
            do
            {
                // simplify for testing
                //
                // string? readResultStr = Console.ReadLine(); //return value can possibly be null
                // if (readResultStr != null)
                // {
                //     valueEnteredStr = readResultStr;
                // }
                Console.WriteLine("(hit enter to select the number 8)");
                Console.ReadLine();
                valueEnteredStr = "8";

                isValidNumber = int.TryParse(valueEnteredStr, out numValue);

                if (isValidNumber)
                {
                    if (numValue <= 5 || numValue >= 10)
                    {
                        isValidNumber = false;
                        Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                }
            } while (isValidNumber == false);

            Console.WriteLine($"Your input value ({numValue}) has been accepted.");

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Project 2\n");

            // project 2
            string? readResult2; // is a nullable type (string?)
            string roleName = "";
            bool validEntry = false;
            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                // readResult2 = Console.ReadLine();
                // simplify for testing
                Console.WriteLine("(hit enter to select 'user')");
                Console.ReadLine();
                readResult2 = "user";
                if (readResult2 != null)
                {
                    roleName = readResult2.Trim();
                }
                // simplify for testing

                if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
                {
                    validEntry = true;
                }
                else
                {
                    Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
                }

            } while (validEntry == false);
            Console.WriteLine($"Your input value ({roleName}) has been accepted.");

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Project 3\n");

            // project 3
            string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
            int stringsCount = myStrings.Length;
            for (int i = 0; i < stringsCount; ++i)
            {
                string myString = myStrings[i];
                int periodLocation = myString.IndexOf(".");
                string mySentence;
                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {
                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);
                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);
                    // remove any leading white-space from myString
                    myString = myString.TrimStart();
                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");
                    Console.WriteLine(mySentence);
                }
                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Data Types\n");

            Console.WriteLine("Signed integral types:");
            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");
            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine("");

            // int to string conversion
            int first = 5;
            int second = 7;
            string msg = first.ToString() + second.ToString();
            Console.WriteLine(msg);

            // string to int conversion
            string firstOne = "5";
            string secondOne = "7";
            int sumRes = int.Parse(firstOne) + int.Parse(secondOne);
            Console.WriteLine(sumRes);

            // the Convert class
            string value11 = "5";
            string value22 = "7";
            int result33 = Convert.ToInt32(value11) * Convert.ToInt32(value22);
            Console.WriteLine(result33);
            Console.WriteLine("");

            // cast or convert?
            int valueX = (int)1.5m; // casting truncates
            Console.WriteLine(valueX);
            int valueY = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(valueY);
            Console.WriteLine("");

            // TryParse, try parsing a string to a variable (usually use out keyword too)
            string value = "102";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");
            Console.WriteLine("");

            // combining string array values as strings and as integers
            Console.WriteLine("grabbing possible numbers in an array of strings:");
            string[] valuesAA = { "12.3", "45", "ABC", "11", "DEF" };
            decimal totalAA = 0m;
            string messageAA = "";
            foreach (var valueAA in valuesAA)
            {
                decimal numberAA; // stores the TryParse "out" value
                                  // attempt to convert element to a number
                if (decimal.TryParse(valueAA, out numberAA))
                {
                    totalAA += numberAA;
                }
                // treat as string
                else
                {
                    messageAA += valueAA;
                }
            }
            Console.WriteLine($"Message: {messageAA}");
            Console.WriteLine($"Total: {totalAA}");
            Console.WriteLine("");

            // output math operations as specific number types
            Console.WriteLine("Output math operations as specific number types:");
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;
            // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
            // Convert.ToInt32() rounds up the way you would expect.
            int result1 = Convert.ToInt32((decimal)value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Array Methods Sort and Reverse\n");

            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("Original...");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("");
            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Array Methods Clear and Resize\n");

            string[] pallets2 = { "B14", "A11", "B12", "A13" };
            Console.WriteLine($"Before: {pallets2[0]}");
            Array.Clear(pallets2, 0, 2);
            Console.WriteLine($"After: {pallets2[0]}");
            Console.WriteLine($"Clearing 2 ... count: {pallets2.Length}");
            foreach (var pallet in pallets2)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("");

            // resize the array to remove elements
            string[] pallets3 = { "B14", "A11", "B12", "A13" };
            Array.Clear(pallets3, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets3.Length}");
            foreach (var pallet in pallets3)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("");
            Array.Resize(ref pallets3, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets3.Length}");
            pallets3[4] = "C01";
            pallets3[5] = "C02";
            foreach (var pallet in pallets3)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("");
            Array.Resize(ref pallets3, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets3.Length}");
            foreach (var pallet in pallets3)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("");
            Console.WriteLine("Search for nulls in the array now of size 3");
            for (int j = 0; j < pallets3.Length; ++j)
            {
                if (pallets3[j] == null)
                {
                    Console.WriteLine("-- null");
                }
                else
                {
                    Console.WriteLine($"-- {pallets3[j]}");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Array Methods Split and Join\n");

            Console.WriteLine("String to char array, reverse, then back to string");
            string val = "abc123";
            char[] valueArray = val.ToCharArray();
            Array.Reverse(valueArray);
            // string res = new string(valueArray);
            string res = String.Join(",", valueArray);
            Console.WriteLine(res);
            Console.WriteLine("");

            Console.WriteLine("Split comma-separated-value string into an array of strings");
            string dumpyStr = "abc123";
            Console.WriteLine(dumpyStr);
            // to char array
            char[] dumpyCharArr = dumpyStr.ToCharArray();
            Array.Reverse(dumpyCharArr);
            // create csv string from char array
            string dumpyStr2 = String.Join(",", dumpyCharArr);
            Console.WriteLine(dumpyStr2);
            // create array of strings by splitting at the commas
            string[] items = dumpyStr2.Split(',');
            foreach (string item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Array Methods Reverse the Words in a Sentence\n");
            string pangram = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(pangram);
            // Step 1
            string[] messageR = pangram.Split(' ');
            //Step 2
            string[] newMessageR = new string[messageR.Length];
            // Step 3
            for (int k = 0; k < messageR.Length; ++k)
            {
                char[] lettersR = messageR[k].ToCharArray();
                Array.Reverse(lettersR);
                newMessageR[k] = new string(lettersR);
            }
            //Step 4
            string resultR = String.Join(" ", newMessageR);
            Console.WriteLine(resultR);

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Array Methods Parse Orders, Sort Orders and Tag Errors\n");

            // error if order doesn't have four characters
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            Console.WriteLine(orderStream);
            string[] itemsOrder = orderStream.Split(',');
            Array.Sort(itemsOrder);
            foreach (var item in itemsOrder)
            {
                if (item.Length == 4)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(item + "\t- Error");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            Console.WriteLine("############################ Composite Formatting\n");

            string strHi = "Hello";
            string strWld = "World";
            string strCombo = string.Format("{0} {1}!", strHi, strWld);
            Console.WriteLine(strCombo);
        }
    }
}