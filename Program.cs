string calcGrade(decimal val) {
    if (val >= 97.0m) { 
        return "A+"; 
    }
    else if (val >= 93.0m) { 
        return "A"; 
    }
    else if (val >= 90.0m) { 
        return "A-"; 
    }
    else if (val >= 87.0m) { 
        return "B+"; 
    }
    else if (val >= 83.0m) { 
        return "B"; 
    }
    else {
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
sophiaSum = sophia1+sophia2+sophia3+sophia4+sophia5;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
nicolasSum = nicolas1+nicolas2+nicolas3+nicolas4+nicolas5;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
zahirahSum = zahirah1+zahirah2+zahirah3+zahirah4+zahirah5;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
jeongSum = jeong1+jeong2+jeong3+jeong4+jeong5;

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
Console.WriteLine("Nicolas:\t " + nicolasScore+"\t" + calcGrade(nicolasScore));
Console.WriteLine("Zahirah:\t " + zahirahScore+"\t" + calcGrade(zahirahScore));
Console.WriteLine("Jeong:\t\t " + jeongScore+"\t" + calcGrade(jeongScore));


