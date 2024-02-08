//-- default vscode snippets
// cl-> class FileName {}
// svm-> static void Main(string[] args) (only when inside a class or struct)
// cw-> System.Console.WriteLine();

//-- my vscode snippets
// wl-> Console.WriteLine(""); 
// wi-> Console.WriteLine($"{}");           // <ctrl>-<space> helpful for setting value 
// swl-> System.Console.WriteLine(""); 
// swi-> System.Console.WriteLine($"{}");   // <ctrl>-<space> helpful for setting value 

internal class Program
{
    private static void Main(string[] args)
    {
        void TellFortune(int luck, string[] good, string[] bad, string[] neutral, string[] text)
        {
            Console.WriteLine("A fortune teller whispers the following words:");
            string[] fortune = luck > 75 ? good : (luck < 25 ? bad : neutral);
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }
            Console.WriteLine("");
        }

        bool ValidateLength(string[] address)
        {
            return address.Length == 4;
        };

        bool ValidateZeroes(string[] address)
        {
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith('0'))
                {
                    return false;
                }
            }
            return true;
        }

        bool ValidateRange(string[] address)
        {
            foreach (string number in address)
            {
                int value = int.Parse(number);
                if (value < 0 || value > 255)
                {
                    return false;
                }
            }
            return true;
        }

        // tuple return type (tuple can contain different types)
        (decimal, string) GetStudentGrade(int[] studentScores)
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

        // generic function
        void PrintArray<T>(T[] arr)
        {
            foreach (T e in arr)
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
        int[] MyAppendArr(int[] arrIn, int[] newVals, string name)
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
            PrintArray(arrOut);
            Console.WriteLine();
            return arrOut;
        }

        decimal GetStudentScore(int[] arr, int len, int curAss)
        {
            int sum = 0;
            foreach (int e in arr)
            {
                sum += e;
            }
            return (decimal)sum / curAss;
        }

        string CalcGrade(decimal val)
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

        void PauseHitEnterToContinue()
        {
            Console.WriteLine("");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }

        void DisplayTimes(int[] times)
        {
            // Format and display medicine times
            //  800 ->  8:00
            // 1200 -> 12:00
            //   35 ->  0:35
            //    1 ->  0:01
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }
            Console.WriteLine();
        }

        void AdjustTimes(int[] times, int diff)
        {
            /* Adjust the times by adding the difference, keeping the value within 24 hours */
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = (times[i] + diff) % 2400;
            }
        }

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
        Console.WriteLine("Sophia:\t\t " + sophiaScore + "\t" + CalcGrade(sophiaScore));
        Console.WriteLine("Nicolas:\t " + nicolasScore + "\t" + CalcGrade(nicolasScore));
        Console.WriteLine("Zahirah:\t " + zahirahScore + "\t" + CalcGrade(zahirahScore));
        Console.WriteLine("Jeong:\t\t " + jeongScore + "\t" + CalcGrade(jeongScore));

        PauseHitEnterToContinue();

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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ If/Else Challenge\n");

        Random random = new();
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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Decimal Type\n");

        decimal x = 7 / 5;
        Console.WriteLine($"x={x}");

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Dice Game with Random() and Next()\n");

        // random values
        // Random dice1 = new Random();
        Random dice1 = new(); // simplified new expression
        int roll1 = dice1.Next(1, 7);           // between 1 and 7-1
        Console.WriteLine($"roll1 = {roll1}");
        Random dice2 = new();
        int roll2 = dice2.Next(1, 7);           // between 1 and 7-1

        Console.WriteLine($"roll2 = {roll2}");

        Random dice3 = new();
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
        if (roll1 == roll2 && roll2 == roll3)
        {
            Console.WriteLine("You rolled a treble! +6 bonus to total!");
            total += 6;
        }
        // bonus for rolling a double?
        else if (roll6 == roll7 || roll7 == roll8 || roll6 == roll8)
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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Math Max\n");

        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);
        Console.WriteLine($"The two numbers are {firstValue} and {secondValue}");
        Console.WriteLine($"The largest is: {largerValue}");

        PauseHitEnterToContinue();

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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Nested Iteration\n");
        string[] fraudulentOrderID3 = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
        foreach (string s in fraudulentOrderID3)
        {
            if (s.StartsWith('B'))
            {
                Console.WriteLine($"The name {s} starts with 'B'!");
            }
        }

        PauseHitEnterToContinue();

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

        string newMessage = new(message);

        Console.WriteLine(originalMessage);
        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {letterCount} times.");

        PauseHitEnterToContinue();

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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Calc Student Scores Using Arrays, Foreach and a Function\n");

        int[] sophiaScoresArr = [90, 86, 87, 98, 100];
        int[] andrewScoresArr = [92, 89, 81, 96, 90];
        int[] emmaScoresArr = [90, 85, 87, 98, 68];
        int[] loganScoresArr = [90, 95, 87, 88, 96];

        sophiaScore = GetStudentScore(sophiaScoresArr, sophiaScoresArr.Length, currentAssignments);
        andrewScore = GetStudentScore(andrewScoresArr, andrewScoresArr.Length, currentAssignments);
        emmaScore = GetStudentScore(emmaScoresArr, emmaScoresArr.Length, currentAssignments);
        loganScore = GetStudentScore(loganScoresArr, loganScoresArr.Length, currentAssignments);

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\t?");
        Console.WriteLine("Andrew:\t\t" + andrewScore + "\t?");
        Console.WriteLine("Emma:\t\t" + emmaScore + "\t?");
        Console.WriteLine("Logan:\t\t" + loganScore + "\t?");

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Student Extra Credits\n");

        // existing students, appending extra credits
        sophiaScoresArr = MyAppendArr(sophiaScoresArr, [94, 90], "sophia");
        andrewScoresArr = MyAppendArr(andrewScoresArr, [89], "andrew");
        emmaScoresArr = MyAppendArr(emmaScoresArr, [89, 89, 89], "emma ");
        loganScoresArr = MyAppendArr(loganScoresArr, [96], "logan");
        // new students just added
        // simplifying collection initialisation via collection expression
        // int[] beckyScoresArr = new int[] {92, 91, 90, 91, 92, 92, 92};
        int[] beckyScoresArr = [92, 91, 90, 91, 92, 92, 92];
        int[] chrisScoresArr = [84, 86, 88, 90, 92, 94, 96, 98];
        int[] ericScoresArr = [80, 90, 100, 80, 90, 100, 80, 90];
        int[] gregorScoresArr = [91, 91, 91, 91, 91, 91, 91];

        // existing students (tuple returns!)
        Console.WriteLine("Student\t\tGrade\tGrade Letter");
        (decimal sophiaGrade, string sophiaLetterGrade) = GetStudentGrade(sophiaScoresArr);
        Console.WriteLine($"sophia\t\t{sophiaGrade}\t{sophiaLetterGrade}");
        (decimal andrewGrade, string andrewLetterGrade) = GetStudentGrade(andrewScoresArr);
        Console.WriteLine($"sophia\t\t{andrewGrade}\t{andrewLetterGrade}");
        (decimal emmaGrade, string emmaLetterGrade) = GetStudentGrade(emmaScoresArr);
        Console.WriteLine($"emma\t\t{emmaGrade}\t{emmaLetterGrade}");
        (decimal loganGrade, string loganLetterGrade) = GetStudentGrade(loganScoresArr);
        Console.WriteLine($"logan\t\t{loganGrade}\t{loganLetterGrade}");

        // new students (tuple returns!)
        (decimal beckyGrade, string beckyLetterGrade) = GetStudentGrade(beckyScoresArr);
        Console.WriteLine($"becky\t\t{beckyGrade}\t{beckyLetterGrade}");
        (decimal chrisGrade, string chrisLetterGrade) = GetStudentGrade(chrisScoresArr);
        Console.WriteLine($"chris\t\t{chrisGrade}\t{chrisLetterGrade}");
        (decimal ericGrade, string ericLetterGrade) = GetStudentGrade(ericScoresArr);
        Console.WriteLine($"eric\t\t{ericGrade}\t{ericLetterGrade}");
        (decimal gregorGrade, string gregorLetterGrade) = GetStudentGrade(gregorScoresArr);
        Console.WriteLine($"gregor\t\t{gregorGrade}\t{gregorLetterGrade}");

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Boolean Expressions\n");

        // ternary operator with boolean expression
        Random coin = new();
        int flip = coin.Next(0, 2);
        Console.WriteLine(flip == 0 ? "heads" : "tails");

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
        int[] numbers = [4, 8, 15, 16, 23, 42];
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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Switch Statement and Switch Expression\n");

        int employeeLevel = 100;
        string employeeName = "John Smith";
        string title;
        // a switch expression
        title = employeeLevel switch
        {
            100 or 200 => "Senior Associate",
            300 => "Manager",
            400 => "Senior Manager",
            _ => "Associate",
        };

        Console.WriteLine($"{employeeName}, {title}");

        // stock codes parse via switch
        string stockKeepingUnit = "01-MN-L";
        string[] product = stockKeepingUnit.Split('-');
        string type;
        // a switch expression
        type = product[0] switch
        {
            "01" => "Sweat shirt",
            "02" => "T-Shirt",
            "03" => "Sweat pants",
            _ => "Other",
        };

        // string color;
        // switch (product[1])
        // {
        //     case "BL":
        //         color = "Black";
        //         break;
        //     case "MN":
        //         color = "Maroon";
        //         break;
        //     default:
        //         color = "White";
        //         break;
        // }
        // converted switch statement to a switch expression
        string color = product[1] switch
        {
            "BL" => "Black",
            "MN" => "Maroon",
            _ => "White",
        };

        string size;
        // a switch expression
        size = product[2] switch
        {
            "S" => "Small",
            "M" => "Medium",
            "L" => "Large",
            _ => "One Size Fits All",
        };

        Console.WriteLine($"Product: {size} {color} {type}");

        PauseHitEnterToContinue();

        Console.WriteLine("############################ For Loops\n");

        // fizzbuzz
        for (int i = 1; i < 101; ++i)
        {
            // index printed with "space" padding width 3
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine($"{i,3} - FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine($"{i,3} - Fizz");
            else if (i % 5 == 0)
                Console.WriteLine($"{i,3} - Buzz");
            else
                Console.WriteLine($"{i,3}");
        }

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Do While Statement\n");

        int hero = 10;
        int monster = 10;
        Random dice = new();
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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Project 1\n");

        // project 1
        string valueEnteredStr;
        Console.WriteLine("Enter an integer value between 5 and 10");
        int numValue;
        bool isValidNumber;
        do
        {
            // simplify for testing (no user input)
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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Project 2\n");

        // project 2
        string? readResult2; // is a nullable type (string?)
        string roleName = "";
        bool validEntry = false;
        do
        {
            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
            // simplify for testing (no user input)
            // readResult2 = Console.ReadLine();
            Console.WriteLine("(hit enter to select 'user')");
            Console.ReadLine();
            readResult2 = "user";
            if (readResult2 != null)
            {
                roleName = readResult2.Trim();
            }
            // using Equals() and CurrentCultureIgnoreCase instead of ToLower() and == (an Intellisense suggested fix)
            if (roleName.Equals("administrator", StringComparison.CurrentCultureIgnoreCase) || roleName.Equals("manager", StringComparison.CurrentCultureIgnoreCase) || roleName.Equals("user", StringComparison.CurrentCultureIgnoreCase))
            {
                validEntry = true;
            }
            else
            {
                Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
            }

        } while (validEntry == false);
        Console.WriteLine($"Your input value ({roleName}) has been accepted.");

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Project 3\n");

        // project 3
        string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
        int stringsCount = myStrings.Length;
        for (int i = 0; i < stringsCount; ++i)
        {
            string myString = myStrings[i];
            int periodLocation = myString.IndexOf('.');
            string mySentence;
            // extract sentences from each string and display them one at a time
            while (periodLocation != -1)
            {
                // first sentence is the string value to the left of the period location
                mySentence = myString.Remove(periodLocation);
                // the remainder of myString is the string value to the right of the location
                // using the range.. operator (2..5 is 2 to 5, ..5 is start to 5, 5.. is 5 to end)
                myString = myString[(periodLocation + 1)..];
                // remove any leading white-space from myString
                myString = myString.TrimStart();
                // update the comma location and increment the counter
                periodLocation = myString.IndexOf('.');
                Console.WriteLine(mySentence);
            }
            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
        }

        PauseHitEnterToContinue();

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
        string[] valuesAA = ["12.3", "45", "ABC", "11", "DEF"];
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
        int result1 = Convert.ToInt32(value1 / value2);
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
        decimal result2 = value2 / (decimal)value3;
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
        float result3 = value3 / value1;
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Array Methods Sort() and Reverse()\n");

        string[] pallets = ["B14", "A11", "B12", "A13"];
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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Array Methods Clear() and Resize()\n");

        string[] pallets2 = ["B14", "A11", "B12", "A13"];
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
        string[] pallets3 = ["B14", "A11", "B12", "A13"];
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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Array Methods Split() and Join()\n");

        Console.WriteLine("String to char array, reverse, then back to string");
        string strOrig = "abc123";
        char[] charArray = strOrig.ToCharArray();
        Array.Reverse(charArray);
        string strJoined = string.Join(",", charArray);
        Console.WriteLine(strJoined);
        Console.WriteLine("");

        Console.WriteLine("Split comma-separated-value string into an array of strings");
        string dumpyStr = "abc123";
        Console.WriteLine(dumpyStr);
        // to char array
        char[] dumpyCharArr = dumpyStr.ToCharArray();
        Array.Reverse(dumpyCharArr);
        // create csv string from char array
        string dumpyStr2 = string.Join(",", dumpyCharArr);
        Console.WriteLine(dumpyStr2);
        // create array of strings by splitting at the commas
        string[] items = dumpyStr2.Split(',');
        foreach (string item in items)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("");

        PauseHitEnterToContinue();

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
        string resultR = string.Join(" ", newMessageR);
        Console.WriteLine(resultR);

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Array Methods, Parse Orders, Sort Orders and Tag Errors\n");

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

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Composite Formatting\n");
        // local currency {value:C}
        // number with two decimal places {value:N} (default number of decimal places)
        // number with three decimal places {value:N3}
        // percentage to two decimal places {value:P2}

        Console.WriteLine("String.Format():");
        string strHi = "Hello";
        string strWld = "World";
        string strCombo = string.Format("Formatting via string.Format('') {0} {1}!", strHi, strWld);
        Console.WriteLine(strCombo);
        Console.WriteLine("");

        Console.WriteLine("Formatting currency to local currency {C}:");
        decimal price = 123.45m;
        int discount = 50;
        // the C format specifier is for currency - will format to 
        // the currency associated with the *culture* setting for the
        // computer (which also defines the language used by computer) 
        // en-US=$, en-GB=£
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");
        Console.WriteLine("");

        Console.WriteLine("Commas in large numbers");
        Console.WriteLine("Number {value:N} defaults to two decimal places");
        Console.WriteLine("Number five decimal places {value:N5}");
        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N} units");
        // default precision {val:N} is two decimal places, but can set more (eg: four decimal places)
        Console.WriteLine($"Measurement: {measurement:N4} units");
        Console.WriteLine("");

        Console.WriteLine("Percentage to two decimal places {value:P2}:");
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");
        Console.WriteLine("");

        Console.WriteLine("Combining formatting approaches:");
        decimal priceVal = 67.55m;
        decimal salePriceVal = 59.99m;
        string yourDiscountVal = string.Format("You saved {0:C2} off the regular {1:C2} price. ", priceVal - salePriceVal, priceVal);
        Console.WriteLine(yourDiscountVal);
        Console.WriteLine("");

        Console.WriteLine("Combining multiple formatting approaches:");
        decimal myPrice = 67.55m;
        decimal mySalePrice = 59.99m;
        string theDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", myPrice - mySalePrice, myPrice);
        // appending the formatted string using interpolation
        theDiscount += $"A discount of {(myPrice - mySalePrice) / myPrice:P2}!"; //inserted
        Console.WriteLine(theDiscount);
        Console.WriteLine("");

        Console.WriteLine("Create invoice combining multiple formatting approaches:");
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal totalNow = 3185.19m;
        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"   Shares: {productShares:N3} Product");
        Console.WriteLine($"     Sub Total: {subtotal:C}");
        Console.WriteLine($"           Tax: {taxPercentage:P2}");
        Console.WriteLine($"     Total Billed: {totalNow:C}");

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Padding and Alignment\n");

        // "pig".padLeft(6,'.') - take up six spaces total and pad the left: ...pig
        Console.WriteLine("{0}", "pig".PadLeft(6, '.'));
        Console.WriteLine("");

        Console.WriteLine("Pad left with twelve spaces:");
        string input = "Pad this')";
        Console.WriteLine("1        10        20        30        40");
        Console.WriteLine("1234567890123456789012345678901234567890123456789"); // easily see output padding
        Console.WriteLine(input.PadLeft(12));
        Console.WriteLine("");

        Console.WriteLine("Pad with twelve hyphens '-', first left then right):");
        Console.WriteLine("1        10        20        30        40");
        Console.WriteLine("1234567890123456789012345678901234567890123456789"); // easily see output padding
        Console.WriteLine(input.PadLeft(12, '-'));
        Console.WriteLine(input.PadRight(12, '-'));
        Console.WriteLine("");

        Console.WriteLine("Padded strings (pad right 6, pad right 24 then pad left 10):");
        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";
        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);
        Console.WriteLine("1        10        20        30        40");
        Console.WriteLine("1234567890123456789012345678901234567890123456789"); // easily see output padding
        Console.WriteLine(formattedLine);

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Apply string interpolation to a form letter\n");

        string customerName = "Ms. Barros";
        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;
        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;
        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

        Console.WriteLine("Here's a quick comparison:\n");
        string comparisonMessage = currentProduct.PadRight(20);
        comparisonMessage += string.Format("{0:P}", currentReturn).PadRight(10);
        comparisonMessage += string.Format("{0:C}", currentProfit).PadRight(20);

        comparisonMessage += "\n";
        comparisonMessage += newProduct.PadRight(20);
        comparisonMessage += string.Format("{0:P}", newReturn).PadRight(10);
        comparisonMessage += string.Format("{0:C}", newProfit).PadRight(20);

        Console.WriteLine(comparisonMessage);

        PauseHitEnterToContinue();

        Console.WriteLine("############################ IndexOf() and Substring()\n");

        Console.WriteLine("00        10        20        30        40");
        Console.WriteLine("01234567890123456789012345678901234567890123456789"); // easily see string index
        string messageY = "Find what is (inside the parentheses)";
        Console.WriteLine(messageY);
        Console.WriteLine("");
        int openingPositionY = messageY.IndexOf('(');
        int closingPositionY = messageY.IndexOf(')');
        Console.WriteLine($"\topening ( index = {openingPositionY}");
        Console.WriteLine($"\tclosing ) index = {closingPositionY}");
        openingPositionY += 1;
        int lengthY = closingPositionY - openingPositionY;
        Console.WriteLine(string.Concat("\t", messageY.Substring(openingPositionY, lengthY)));
        Console.WriteLine("");

        Console.WriteLine("00        10        20        30        40        50");
        Console.WriteLine("012345678901234567890123456789012345678901234567890123456789"); // easily see string index
        string messageSpan = "What are the words <span>between the tags</span>?";
        Console.WriteLine(messageSpan);
        Console.WriteLine("");
        const string openSpan = "<span>";
        const string closeSpan = "</span>";
        int openingPositionSpan = messageSpan.IndexOf(openSpan);
        int closingPositionSpan = messageSpan.IndexOf(closeSpan);
        openingPositionSpan += openSpan.Length;
        int lengthSpan = closingPositionSpan - openingPositionSpan;
        Console.WriteLine(messageSpan.Substring(openingPositionSpan, lengthSpan));

        PauseHitEnterToContinue();

        Console.WriteLine("############################ IndexOfAny() and LastIndexOf()\n");

        // easily see string index
        Console.WriteLine("00        10        20        30        40        50        60        70");
        Console.WriteLine("01234567890123456789012345678901234567890123456789012345678901234567890123456789");
        string messageLast = "(What if) I am (only interested) in the last (set of parentheses)?";
        Console.WriteLine(messageLast);
        Console.WriteLine("");
        int openingPositionLast = messageLast.LastIndexOf('(');
        Console.WriteLine($"openingPositionLast = {openingPositionLast}");
        openingPositionLast += 1;
        int closingPositionLast = messageLast.LastIndexOf(')');
        Console.WriteLine($"closingPositionLast = {closingPositionLast}");
        int lengthLast = closingPositionLast - openingPositionLast;
        Console.WriteLine(messageLast.Substring(openingPositionLast, lengthLast));
        Console.WriteLine("");

        Console.WriteLine("00        10        20        30        40        50        60        70");
        Console.WriteLine("01234567890123456789012345678901234567890123456789012345678901234567890123456789");
        string messageAll = "(What if) there are (more than) one (set of parentheses)?";
        Console.WriteLine(messageAll);
        Console.WriteLine("");
        while (true)
        {
            int openingPosition = messageAll.IndexOf('(');
            if (openingPosition == -1) break;
            openingPosition += 1;
            int closingPosition = messageAll.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(messageAll.Substring(openingPosition, length));
            // Substring(startPos) defaults to the end, or can use Substring(startPos, length)
            // messageAll = messageAll.Substring(closingPosition + 1);
            // 
            // use range.. operator to simplify Substring
            messageAll = messageAll[(closingPosition + 1)..];
        }
        Console.WriteLine("");

        Console.WriteLine("00        10        20        30        40        50        60        70        80        90");
        Console.WriteLine("0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
        string messageDiff = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        Console.WriteLine(messageDiff);
        Console.WriteLine("");
        // IndexOfAny() requires a char array of characters - look for:
        char[] openSymbolsDiff = { '[', '{', '(' };
        // use a slightly different technique for iterating through 
        // the characters in the string. this time, use the closing 
        // position of the previous iteration as the starting index for the 
        // next open symbol. so, initialize closingPosition to zero
        int closingPositionDiff = 0;
        while (true)
        {
            int openingPositionDiff = messageDiff.IndexOfAny(openSymbolsDiff, closingPositionDiff);
            Console.WriteLine($"openingPositionDiff = {openingPositionDiff}");
            if (openingPositionDiff == -1) break;
            string currentSymbolDiff = messageDiff.Substring(openingPositionDiff, 1);
            // find the matching closing symbol
            char matchingSymbolDiff = ' ';
            switch (currentSymbolDiff)
            {
                case "[":
                    matchingSymbolDiff = ']';
                    break;
                case "{":
                    matchingSymbolDiff = '}';
                    break;
                case "(":
                    matchingSymbolDiff = ')';
                    break;
            }
            // to find the closingPosition, use an overload of the IndexOf method to specify 
            // that the search for the matchingSymbol should start at the openingPosition in the string. 
            openingPositionDiff += 1;
            closingPositionDiff = messageDiff.IndexOf(matchingSymbolDiff, openingPositionDiff);
            Console.WriteLine($"closingPositionDiff = {closingPositionDiff}");
            // display the sub-string:
            int lengthDiff = closingPositionDiff - openingPositionDiff;
            Console.WriteLine($"lengthDiff = {lengthDiff}");
            Console.WriteLine(messageDiff.Substring(openingPositionDiff, lengthDiff));
        }

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Remove() and Replace()\n");

        Console.WriteLine("Remove():");
        Console.WriteLine("00        10        20        30        ");
        Console.WriteLine("0123456789012345678901234567890123456789");
        string dataMv = "12345John Smith          5000  3  ";
        Console.WriteLine(dataMv);
        string updatedDataMv = dataMv.Remove(5, 4);
        Console.WriteLine("Remove(5, 5)");
        Console.WriteLine(updatedDataMv);
        Console.WriteLine("");

        Console.WriteLine("Replace():");
        string messageRep = "This--is--ex-amp-le--da-ta";
        Console.WriteLine(messageRep);
        messageRep = messageRep.Replace("--", "_");
        messageRep = messageRep.Replace("-", "");
        Console.WriteLine("Replace('--', '_')");
        Console.WriteLine("Replace('-', '')");
        Console.WriteLine(messageRep);

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Extract, Replace, and Remove Data from an Input String\n");

        Console.WriteLine("Grab value between the span tags, replace '&trade' with '&reg' and remove the div tags");
        Console.WriteLine("");
        const string inputH = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
        string quantity = "";
        string output = "";
        // Extract the "quantity"
        const string openSpanH = "<span>";
        const string closeSpanH = "</span>";
        int quantityStart = inputH.IndexOf(openSpanH) + openSpanH.Length; // + length of <span> so index at end of <span> tag
        int quantityEnd = inputH.IndexOf(closeSpanH);
        int quantityLength = quantityEnd - quantityStart;
        quantity = inputH.Substring(quantityStart, quantityLength);
        quantity = $"Quantity: {quantity}";
        // Set output to input, replacing the trademark symbol with the registered trademark symbol
        const string tradeSymbol = "&trade;";
        const string regSymbol = "&reg;";
        output = inputH.Replace(tradeSymbol, regSymbol);
        // Remove the opening <div> tag
        const string openDiv = "<div>";
        int divStart = output.IndexOf(openDiv);
        output = output.Remove(divStart, openDiv.Length);
        // Remove the closing </div> tag and add "Output:" to the beginning
        const string closeDiv = "</div>";
        int divCloseStart = output.IndexOf(closeDiv);
        output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);
        Console.WriteLine($"Input: {inputH}");
        Console.WriteLine(quantity);
        Console.WriteLine(output);

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Functions\n");

        int[] times = [800, 1200, 1600, 2000];
        int diff = 0;
        int currentGMT = 10;
        int newGMT = 9;

        // simplify for testing (no user input)
        // bool successGMT = false;
        // do
        // {
        //     Console.WriteLine("Enter current GMT");
        //     string? readGMT = Console.ReadLine();
        //     if (readGMT != null && readGMT != "")
        //     {
        //         currentGMT = Convert.ToInt32(readGMT);
        //         if (currentGMT != 0)
        //         {
        //             successGMT = true;
        //         }
        //     }
        // } while (!successGMT);

        Console.WriteLine($"CurrentGMT = {currentGMT}, newGMT = {newGMT}");
        Console.WriteLine("Current Medicine Schedule:");
        DisplayTimes(times);

        // simplify for testing (no user input)
        // bool successNewGMT = false;
        // do
        // {
        //     Console.WriteLine("Enter new GMT");
        //     string? readNewGMT = Console.ReadLine();
        //     if (readNewGMT != null && readNewGMT != "")
        //     {
        //         newGMT = Convert.ToInt32(readNewGMT);
        //         if (newGMT != 0)
        //         {
        //             successNewGMT = true;
        //         }
        //     }
        // } while (!successNewGMT);

        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            AdjustTimes(times, diff);
        }
        else
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            AdjustTimes(times, diff);
        }

        Console.WriteLine("New Medicine Schedule:");
        DisplayTimes(times);
        Console.WriteLine("");

        Console.WriteLine("Functions to validate IP address");
        string[] ipv4Input = ["107.31.1.5", "255.0.0.255", "555..0.555", "255...255"];
        Console.Write($"List of addresses to check: ");
        PrintArray<string>(ipv4Input);
        string[] address;
        bool validLength = false;
        bool validZeroes = false;
        bool validRange = false;

        foreach (string ip in ipv4Input)
        {
            address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            validLength = ValidateLength(address);
            validZeroes = ValidateZeroes(address);
            validRange = ValidateRange(address);

            if (validLength && validZeroes && validRange)
            {
                Console.WriteLine($"{ip} is a valid IPv4 address");
            }
            else
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }
        Console.WriteLine("");

        Console.WriteLine("Fortune Teller:");
        Random rand = new();
        int luck = rand.Next(100);
        string[] text = ["You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"];
        string[] good = ["look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"];
        string[] bad = ["fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."];
        string[] neutral = ["appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."];
        Console.WriteLine("Two random fortunes:");
        TellFortune(luck, good, bad, neutral, text);
        luck = rand.Next(100);
        TellFortune(luck, good, bad, neutral, text);
        Console.WriteLine("");
        Console.WriteLine("Bad, neutral and good fortunes (hardcoded):");
        TellFortune(10, good, bad, neutral, text);
        TellFortune(50, good, bad, neutral, text);
        TellFortune(90, good, bad, neutral, text);

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Functions With Parameters\n");

        double pi = 3.14159;
        PrintCircleInfo(12);
        Console.WriteLine("");
        PrintCircleInfo(24);
        Console.WriteLine("");

        void PrintCircleArea(int radius)
        {
            double area = pi * (radius * radius);
            Console.WriteLine($"Area = {area}");
        }

        void PrintCircleCircumference(int radius)
        {
            double circumference = 2 * pi * radius;
            Console.WriteLine($"Circumference = {circumference}");
        }

        void PrintCircleInfo(int radius)
        {
            Console.WriteLine($"Circle with radius {radius}");
            PrintCircleArea(radius);
            PrintCircleCircumference(radius);
        }

        Console.WriteLine("-------Strings are immutable but they are also reference types in C#");
        string status = "Healthy";
        Console.WriteLine($"Start: {status}");
        SetHealth(status, false);
        Console.WriteLine($"End: {status}");
        Console.WriteLine("");

        // common mistake, status will remain "Healthy" outwith the function
        void SetHealth(string status, bool isHealthy)
        {
            status = isHealthy ? "Healthy" : "Unhealthy";
            Console.WriteLine($"Middle: {status}");
        }

        Console.WriteLine("-------RSVP Application");
        string[] guestList = ["Rebecca", "Nadia", "Noor", "Jonte"];
        string[] rsvps = new string[10];
        int count = 0;

        RSVP("Rebecca");
        RSVP("Nadia", 2, "Nuts");
        RSVP(name: "Linh", partySize: 2, inviteOnly: false);
        RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
        RSVP("Noor", 4, inviteOnly: false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPs();
        Console.WriteLine("");

        //void RSVP(string name, int partySize, string allergies, bool inviteOnly)
        void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) // optional parameters
        {
            if (inviteOnly)
            {
                bool found = false;
                foreach (string guest in guestList)
                {
                    if (guest.Equals(name))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"Sorry, {name} is not on the guest list");
                    return;
                }
            }

            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            count++;
        }

        void ShowRSVPs()
        {
            Console.WriteLine("Total RSVPs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rsvps[i]);
            }
        }

        Console.WriteLine("-------Display Email Addresses");
        string[,] corporate =
        {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

        string[,] external =
        {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };

        string externalDomain = "hayworth.com";

        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
        }

        for (int i = 0; i < external.GetLength(0); i++)
        {
            DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
        }

        void DisplayEmail(string first, string last, string domain = "contoso.com")
        {
            string email = first.Substring(0, 2) + last;
            email = email.ToLower();
            Console.WriteLine($"{email}@{domain}");
        }

        PauseHitEnterToContinue();

        Console.WriteLine("############################ Functions With Parameters and Returns\n");

        double totalR = 0;
        double minimumSpend = 30.00;

        double[] itemsR = [15.97, 3.50, 12.25, 22.99, 10.98];
        double[] discounts = [0.30, 0.00, 0.10, 0.20, 0.50];

        for (int i = 0; i < itemsR.Length; i++)
        {
            totalR += GetDiscountedPrice(i);
        }

        totalR -= TotalMeetsMinimum() ? 5.00 : 0.00;

        Console.WriteLine($"totalR: ${FormatDecimal(totalR)}");
        Console.WriteLine("");

        double GetDiscountedPrice(int itemIndex)
        {
            return itemsR[itemIndex] * (1 - discounts[itemIndex]);
        }

        bool TotalMeetsMinimum()
        {
            return totalR >= minimumSpend;
        }

        string FormatDecimal(double input)
        {
            return input.ToString().Substring(0, 5);

        }

        Console.WriteLine("Functions Returning Strings\n");
        string inputSnakes = "there are snakes at the zoo";

        Console.WriteLine(inputSnakes);
        Console.WriteLine(ReverseSentence(inputSnakes));

        string ReverseSentence(string inputSnakes)
        {
            string result = "";
            string[] words = inputSnakes.Split(" ");
            foreach (string word in words)
            {
                result += ReverseWord(word) + " ";
            }
            return result.Trim();
        }

        string ReverseWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }

        Console.WriteLine("Functions Returning Arrays\n");
        int target = 30;
        int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
        int[,] resultT = TwoCoins(coins, target);

        if (resultT.Length == 0)
        {
            Console.WriteLine("No two coins make change");
        }
        else
        {
            Console.WriteLine("Change found at positions:");
            for (int i = 0; i < resultT.GetLength(0); i++)
            {
                if (resultT[i, 0] == -1)
                {
                    break;
                }
                Console.WriteLine($"{resultT[i, 0]},{resultT[i, 1]}");
            }
        }
        Console.WriteLine("");

        int[,] TwoCoins(int[] coins, int target)
        {
            int[,] resultT = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
            int count = 0;

            for (int curr = 0; curr < coins.Length; curr++)
            {
                for (int next = curr + 1; next < coins.Length; next++)
                {
                    if (coins[curr] + coins[next] == target)
                    {
                        resultT[count, 0] = curr;
                        resultT[count, 1] = next;
                        count++;
                    }
                    if (count == resultT.GetLength(0))
                    {
                        return resultT;
                    }
                }
            }
            return (count == 0) ? new int[0, 0] : resultT;
        }

        Console.WriteLine("Game With Functions");
        Random randomX = new();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }
        Console.WriteLine("");

        bool ShouldPlay()
        {
            // simplify for testing (run once with no user input)
            return true;
            /*
            bool readSuccess = false;
            string? response;
            string resDefer = "";
            do
            {
                response = Console.ReadLine();
                if (response != null && response != "")
                {
                    readSuccess = true;
                    resDefer = response;
                }
            } while (!readSuccess);
            return resDefer.ToLower().Equals("y");
            */
        }

        void PlayGame()
        {
            var play = true;

            while (play)
            {
                var target = GetTarget();
                var roll = RollDice();

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(roll, target));
                Console.WriteLine("\nPlay again? (Y/N)");

                // simplify for testing (run once with no user input)
                //play = ShouldPlay();
                play = false;
            }
        }

        int GetTarget()
        {
            return randomX.Next(1, 6);
        }

        int RollDice()
        {
            return randomX.Next(1, 7);
        }

        string WinOrLose(int roll, int target)
        {
            if (roll > target)
            {
                return "You win!";
            }
            return "You lose!";
        }

        Console.WriteLine("############################ Petting Zoo\n");

        string[] pettingZoo =
        [
            "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
            "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
            "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
        ];

        void PlanSchoolVisit(string schoolName, int groups = 6)
        {
            RandomizeAnimals();
            string[,] group1 = AssignGroup(groups);
            Console.WriteLine(schoolName);
            PrintGroup(group1);
        }

        void RandomizeAnimals()
        {
            Random random = new Random();

            for (int i = 0; i < pettingZoo.Length; i++)
            {
                int r = random.Next(i, pettingZoo.Length);

                string temp = pettingZoo[r];
                pettingZoo[r] = pettingZoo[i];
                pettingZoo[i] = temp;
            }
        }

        string[,] AssignGroup(int groups = 6)
        {
            string[,] result = new string[groups, pettingZoo.Length / groups];
            int start = 0;

            for (int i = 0; i < groups; i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = pettingZoo[start++];
                }
            }

            return result;
        }

        void PrintGroup(string[,] groups)
        {
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                Console.Write($"Group {i + 1}: ");
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    Console.Write($"{groups[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        PlanSchoolVisit("School A");
        PlanSchoolVisit("School B", 3);
        PlanSchoolVisit("School C", 2);
        Console.WriteLine("");

        Console.WriteLine("############################ Debug Section\n");
        /* 
            This code uses a names array and corresponding methods to display
            greeting messages

        */
        /*
            \n is the next line in unix (line feed, historically means move carriage down) 
            \r is the next line in mac (carriage return, historically means go back to the start of the line)
            \n\r is the next line in windows (needs both)
            Use "Environment.NewLine" variable as this will select the appropriate newline symbol for the underlying system
            These days, can just use \n all the time and carriage down carriage start will be implmented
        */

        string[] namesDebug = ["Sophia", "Andrew", "AllGreetings"];
        string messageText = "";
        foreach (string name in namesDebug)
        {
            if (name == "Sophia")
                messageText = SophiaMessage();
            else if (name == "Andrew")
                messageText = AndrewMessage();
            else if (name == "AllGreetings")
            {
                messageText = SophiaMessage() + Environment.NewLine + AndrewMessage();
            }

            Console.WriteLine(messageText + "\n\r");
        }

        static string SophiaMessage()
        {
            return "Hello, my name is Sophia.";
        }

        static string AndrewMessage()
        {
            return "Hi, my name is Andrew. Good to meet you.";
        }

        

    }
}
