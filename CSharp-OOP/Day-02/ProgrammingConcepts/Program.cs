<<<<<<< HEAD
﻿namespace ProgrammingConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Min and Max value of an array of 10 intergers 

            //int[] arr = new int[10];

            //// Fill the array from the user input
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Number at Index {i}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int min = arr[0], max = arr[0];

            //// Get the Min & Max numbers in the array
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //        min = arr[i];
            //    if (arr[i] > max)
            //        max = arr[i];
            //}

            //// Output result
            //Console.WriteLine($"The Minimum Number In The Array Is {min}");
            //Console.WriteLine($"The Maximum Number In The Array Is {max}");

            #endregion

            #region 2- Ascending sort of an array of 10 intergers

            //int[] arr = new int[10];

            //// Fill the array from the user input
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Number at Index {i}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int temp;

            //// Sorting the array Ascending
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}

            //// Print the sorted array
            //Console.Write("{ ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]);
            //    if (i < arr.Length - 1)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //Console.WriteLine(" }");

            #endregion

            #region 3- Get index of a specific number from an array of 10 intergers

            //int[] arr = new int[10];

            //// Fill the array from the user input
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Number at Index {i}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("What is the number you want to search for? ");
            //int reqNum = int.Parse(Console.ReadLine());

            //string indices = "";
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == reqNum)
            //    {
            //        if (count > 0)
            //        {
            //            indices += ", ";
            //        }
            //        indices += i.ToString();
            //        count++;
            //    }
            //}

            //// Display the results
            //if (count > 0)
            //{
            //    Console.WriteLine($"Number {reqNum} found at {count} position(s):");
            //    Console.WriteLine($"Indices: {indices}");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {reqNum} was not found in the array.");
            //}

            #endregion

            #region 4- (BONUS)matrix  3*2   *  2*1   =3*1

            //int[,] matrixA = new int[3, 2];
            //int[,] matrixB = new int[2, 1];
            //int[,] rsltMatrix = new int[3, 1];

            //// Fill the first matrix (3x2)
            //Console.WriteLine("Enter values for the 3x2 Matrix A:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"Enter value for position [{i},{j}]: ");
            //        matrixA[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("---------------------------");

            //// Fill the second matrix (2x1)
            //Console.WriteLine("Enter values for the 2x1 Matrix B:");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.Write($"Enter value for position [{i},0]: ");
            //    matrixB[i, 0] = int.Parse(Console.ReadLine());
            //}

            //// Calculate the multiplication
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            rsltMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            //        }
            //    }
            //}

            //Console.WriteLine("---------------------------");

            //// Display the output matrices
            //Console.WriteLine("Matrix A (3x2):");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("[ ");
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"{matrixA[i, j]} ");
            //    }
            //    Console.WriteLine("]");
            //}

            //Console.WriteLine("\nMatrix B (2x1):");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"[ {matrixB[i, 0]} ]");
            //}

            //// Display the result
            //Console.WriteLine("\nResult Matrix (3x1):");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"[ {rsltMatrix[i, 0]} ]");
            //}

            #endregion

            #region 5- Calculate age in years, months and days

            //int birthYear = 0, birthMonth = 0, birthDay = 0;
            //int maxDaysInMonth = 31;
            //bool isLeapYear = false;
            //bool isValidDate = false;

            //// Input validation
            //while (!isValidDate)
            //{
            //    Console.Write("Enter your birth year: ");
            //    birthYear = int.Parse(Console.ReadLine());

            //    Console.Write("Enter your birth month: ");
            //    birthMonth = int.Parse(Console.ReadLine());

            //    Console.Write("Enter your birth day: ");
            //    birthDay = int.Parse(Console.ReadLine());

            //    // Validate the date
            //    if (birthYear < 1 || birthYear >= DateTime.Now.Year || birthMonth < 1 || birthMonth > 12 || birthDay < 1)
            //    {
            //        Console.WriteLine("Invalid date. Please enter a valid date.");
            //        continue;
            //    }

            //    if (birthMonth == 4 || birthMonth == 6 || birthMonth == 9 || birthMonth == 11)
            //    {
            //        maxDaysInMonth = 30;
            //    }
            //    else if (birthMonth == 2)
            //    {
            //        isLeapYear = (birthYear % 4 == 0 && (birthYear % 100 != 0 || birthYear % 400 == 0));
            //        maxDaysInMonth = isLeapYear ? 29 : 28;
            //    }

            //    if (birthDay > maxDaysInMonth)
            //    {
            //        Console.WriteLine("Invalid date. Please enter a valid date.");
            //        continue;
            //    }

            //    isValidDate = true;
            //}

            //// Current date
            //int currentYear = DateTime.Now.Year;
            //int currentMonth = DateTime.Now.Month;
            //int currentDay = DateTime.Now.Day;

            //// Calculate age
            //int years = currentYear - birthYear;
            //int months = currentMonth - birthMonth;
            //int days = currentDay - birthDay;

            //// For negative months or days
            //isLeapYear = false;
            //if (days < 0)
            //{
            //    months--;
            //    int previousMonth = currentMonth == 1 ? 12 : currentMonth - 1;
            //    int previousYear = currentMonth == 1 ? currentYear - 1 : currentYear;

            //    int daysInPreviousMonth = 31;

            //    if (previousMonth == 4 || previousMonth == 6 || previousMonth == 9 || previousMonth == 11)
            //    {
            //        daysInPreviousMonth = 30;
            //    }
            //    else if (previousMonth == 2)
            //    {
            //        isLeapYear = (previousYear % 4 == 0 && (previousYear % 100 != 0 || previousYear % 400 == 0));
            //        daysInPreviousMonth = isLeapYear ? 29 : 28;
            //    }

            //    days += daysInPreviousMonth;
            //}

            //if (months < 0)
            //{
            //    years--;
            //    months += 12;
            //}

            //// Display the age
            //Console.WriteLine($"You're {year}y {month} months and {day} days.");

            #endregion

            #region 6- Simple Calculator

            //double num1, num2, result;
            //char op;
            //bool isValidOperation;
            //char continueOperation = 'Y';

            //// Take the input from the user for the first operation
            //do
            //{
            //    Console.Write("Enter the first number: ");
            //    num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the operator (+, -, *, /, %): ");
            //    op = char.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number: ");
            //    num2 = int.Parse(Console.ReadLine());

            //    // Perform the operation
            //    result = 0;
            //    isValidOperation = true;

            //    switch (op)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;

            //        case '-':
            //            result = num1 - num2;
            //            break;

            //        case '*':
            //            result = num1 * num2;
            //            break;

            //        case '/':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Division by zero is not allowed!!");
            //                isValidOperation = false;
            //            }
            //            else
            //            {
            //                result = num1 / num2;
            //            }
            //            break;

            //        case '%':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Modulus by zero is not allowed!!");
            //                isValidOperation = false;
            //            }
            //            else
            //            {
            //                result = num1 % num2;
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operator.");
            //            isValidOperation = false;
            //            break;
            //    }

            //    // Print the result if the operation was valid
            //    if (isValidOperation)
            //    {
            //        Console.WriteLine($"{num1} {op} {num2} = {result}");
            //    }

            //    Console.Write("Do you want to perform another operation? (Y/N): ");
            //    continueOperation = char.Parse(Console.ReadLine());

            //} while (continueOperation == 'Y' || continueOperation == 'y');

            #endregion

            #region Test-1-2

            //int[] arr = { 15, 2, 10, 11, 5, 9, 25, 1, 18, 20 };

            //int temp;
            //int minIndex;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    minIndex = i;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[minIndex])
            //        {
            //            minIndex = j;
            //        }
            //    }

            //    temp = arr[i];
            //    arr[i] = arr[minIndex];
            //    arr[minIndex] = temp;
            //}

            //Console.Write("Sorted Array: {");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(i==arr.Length - 1 ? arr[i] + " ": arr[i] + ",");
            //}
            //Console.WriteLine("}");

            //Console.WriteLine($"The Min Number in the array is: {arr[0]}");
            //Console.WriteLine($"The Max Number in the array is: {arr[arr.Length-1]}");

            #endregion

            #region Test-3

            //int[] arr = { 15, 2, 10, 11, 5, 9, 25, 1, 18, 10 };

            //Console.Write("Enter the number you want to search for: ");
            //int targetNum = int.Parse(Console.ReadLine());

            //string targetIndices = "";
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (targetNum == arr[i])
            //    {
            //        if (count > 0)
            //        {
            //            targetIndices += ", ";
            //        }
            //        targetIndices += i.ToString();
            //        count++;
            //    }
            //}

            //if (count > 0)
            //{
            //    Console.WriteLine($"Number {targetNum} was found at {count} Position(s) at index(es) {targetIndices}");
            //}
            //else
            //{
            //    Console.WriteLine("The number you searched for was not found.");
            //}

            #endregion

            #region Test-4

            int[,] matrixA;
            int[,] matrixB;
            int[,] matrixR;

            int rowsA, colsA, rowsB, colsB;

            // Get the matrices dimensions from the user
            Console.Write("First matrix rows = ");
            rowsA = int.Parse(Console.ReadLine());
            Console.Write("First matrix columns = Second matrix rows = ");
            colsA = rowsB = int.Parse(Console.ReadLine());
            Console.Write("Second matrix columns = ");
            colsB = int.Parse(Console.ReadLine());

            matrixA = new int[rowsA, colsA];
            matrixB = new int[rowsB, colsB];
            matrixR = new int[rowsA, colsB];

            // Fill the first matrix
            Console.WriteLine($"Enter values for {matrixA.GetLength(0)}×{matrixA.GetLength(1)} Matrix A:");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.Write($"Enter value for position [{i},{j}]: ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------");

            // Fill the second matrix
            Console.WriteLine($"Enter values for the {matrixB.GetLength(0)}×{matrixB.GetLength(1)} Matrix B:");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    Console.Write($"Enter value for position [{i},{j}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------");

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        matrixR[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("Matrix A: ");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.Write(j == 0 && matrixA.GetLength(1) == 1 ? "|\t" + matrixA[i, j] + "\t|\n" :
                        j == 0 ? "|\t" + matrixA[i, j] : "\t" + matrixA[i, j] + "\t|\n");
                }
            }

            Console.WriteLine("\n\t×\n");

            Console.WriteLine("Matrix B: ");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    Console.Write(j == 0 && matrixB.GetLength(1) == 1 ? "|\t" + matrixB[i, j] + "\t|\n" :
                        j == 0 ? "|\t" + matrixB[i, j] : "\t" + matrixB[i, j] + "\t|\n");
                }
            }

            Console.WriteLine("\n\t=\n");

            Console.WriteLine("Matrix R: ");
            for (int i = 0; i < matrixR.GetLength(0); i++)
            {
                for (int j = 0; j < matrixR.GetLength(1); j++)
                {
                    Console.Write(j == 0 && matrixR.GetLength(1) == 1 ? "|\t" + matrixR[i, j] + "\t|\n" :
                        j == 0 ? "|\t" + matrixR[i, j] : "\t" + matrixR[i, j] + "\t|\n");
                }
            }

            #endregion
        }
    }
}
=======
﻿namespace ProgrammingConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Min and Max value of an array of 10 intergers 

            //int[] arr = new int[10];

            //// Fill the array from the user input
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Number at Index {i}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int min = arr[0], max = arr[0];

            //// Get the Min & Max numbers in the array
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //        min = arr[i];
            //    if (arr[i] > max)
            //        max = arr[i];
            //}

            //// Output result
            //Console.WriteLine($"The Minimum Number In The Array Is {min}");
            //Console.WriteLine($"The Maximum Number In The Array Is {max}");

            #endregion

            #region 2- Ascending sort of an array of 10 intergers

            //int[] arr = new int[10];

            //// Fill the array from the user input
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Number at Index {i}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int temp;

            //// Sorting the array Ascending
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}

            //// Print the sorted array
            //Console.Write("{ ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]);
            //    if (i < arr.Length - 1)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //Console.WriteLine(" }");

            #endregion

            #region 3- Get index of a specific number from an array of 10 intergers

            //int[] arr = new int[10];

            //// Fill the array from the user input
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Number at Index {i}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("What is the number you want to search for? ");
            //int reqNum = int.Parse(Console.ReadLine());

            //string indices = "";
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == reqNum)
            //    {
            //        if (count > 0)
            //        {
            //            indices += ", ";
            //        }
            //        indices += i.ToString();
            //        count++;
            //    }
            //}

            //// Display the results
            //if (count > 0)
            //{
            //    Console.WriteLine($"Number {reqNum} found at {count} position(s):");
            //    Console.WriteLine($"Indices: {indices}");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {reqNum} was not found in the array.");
            //}

            #endregion

            #region 4- (BONUS)matrix  3*2   *  2*1   =3*1

            //int[,] matrixA = new int[3, 2];
            //int[,] matrixB = new int[2, 1];
            //int[,] rsltMatrix = new int[3, 1];

            //// Fill the first matrix (3x2)
            //Console.WriteLine("Enter values for the 3x2 Matrix A:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"Enter value for position [{i},{j}]: ");
            //        matrixA[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("---------------------------");

            //// Fill the second matrix (2x1)
            //Console.WriteLine("Enter values for the 2x1 Matrix B:");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.Write($"Enter value for position [{i},0]: ");
            //    matrixB[i, 0] = int.Parse(Console.ReadLine());
            //}

            //// Calculate the multiplication
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            rsltMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            //        }
            //    }
            //}

            //Console.WriteLine("---------------------------");

            //// Display the output matrices
            //Console.WriteLine("Matrix A (3x2):");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("[ ");
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"{matrixA[i, j]} ");
            //    }
            //    Console.WriteLine("]");
            //}

            //Console.WriteLine("\nMatrix B (2x1):");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"[ {matrixB[i, 0]} ]");
            //}

            //// Display the result
            //Console.WriteLine("\nResult Matrix (3x1):");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"[ {rsltMatrix[i, 0]} ]");
            //}

            #endregion

            #region 5- Calculate age in years, months and days

            //int birthYear = 0, birthMonth = 0, birthDay = 0;
            //int maxDaysInMonth = 31;
            //bool isLeapYear = false;
            //bool isValidDate = false;

            //// Input validation
            //while (!isValidDate)
            //{
            //    Console.Write("Enter your birth year: ");
            //    birthYear = int.Parse(Console.ReadLine());

            //    Console.Write("Enter your birth month: ");
            //    birthMonth = int.Parse(Console.ReadLine());

            //    Console.Write("Enter your birth day: ");
            //    birthDay = int.Parse(Console.ReadLine());

            //    // Validate the date
            //    if (birthYear < 1 || birthYear >= DateTime.Now.Year || birthMonth < 1 || birthMonth > 12 || birthDay < 1)
            //    {
            //        Console.WriteLine("Invalid date. Please enter a valid date.");
            //        continue;
            //    }

            //    if (birthMonth == 4 || birthMonth == 6 || birthMonth == 9 || birthMonth == 11)
            //    {
            //        maxDaysInMonth = 30;
            //    }
            //    else if (birthMonth == 2)
            //    {
            //        isLeapYear = (birthYear % 4 == 0 && (birthYear % 100 != 0 || birthYear % 400 == 0));
            //        maxDaysInMonth = isLeapYear ? 29 : 28;
            //    }

            //    if (birthDay > maxDaysInMonth)
            //    {
            //        Console.WriteLine("Invalid date. Please enter a valid date.");
            //        continue;
            //    }

            //    isValidDate = true;
            //}

            //// Current date
            //int currentYear = DateTime.Now.Year;
            //int currentMonth = DateTime.Now.Month;
            //int currentDay = DateTime.Now.Day;

            //// Calculate age
            //int years = currentYear - birthYear;
            //int months = currentMonth - birthMonth;
            //int days = currentDay - birthDay;

            //// For negative months or days
            //isLeapYear = false;
            //if (days < 0)
            //{
            //    months--;
            //    int previousMonth = currentMonth == 1 ? 12 : currentMonth - 1;
            //    int previousYear = currentMonth == 1 ? currentYear - 1 : currentYear;

            //    int daysInPreviousMonth = 31;

            //    if (previousMonth == 4 || previousMonth == 6 || previousMonth == 9 || previousMonth == 11)
            //    {
            //        daysInPreviousMonth = 30;
            //    }
            //    else if (previousMonth == 2)
            //    {
            //        isLeapYear = (previousYear % 4 == 0 && (previousYear % 100 != 0 || previousYear % 400 == 0));
            //        daysInPreviousMonth = isLeapYear ? 29 : 28;
            //    }

            //    days += daysInPreviousMonth;
            //}

            //if (months < 0)
            //{
            //    years--;
            //    months += 12;
            //}

            //// Display the age
            //Console.WriteLine($"You're {year}y {month} months and {day} days.");

            #endregion

            #region 6- Simple Calculator

            //double num1, num2, result;
            //char op;
            //bool isValidOperation;
            //char continueOperation = 'Y';

            //// Take the input from the user for the first operation
            //do
            //{
            //    Console.Write("Enter the first number: ");
            //    num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the operator (+, -, *, /, %): ");
            //    op = char.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number: ");
            //    num2 = int.Parse(Console.ReadLine());

            //    // Perform the operation
            //    result = 0;
            //    isValidOperation = true;

            //    switch (op)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;

            //        case '-':
            //            result = num1 - num2;
            //            break;

            //        case '*':
            //            result = num1 * num2;
            //            break;

            //        case '/':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Division by zero is not allowed!!");
            //                isValidOperation = false;
            //            }
            //            else
            //            {
            //                result = num1 / num2;
            //            }
            //            break;

            //        case '%':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Modulus by zero is not allowed!!");
            //                isValidOperation = false;
            //            }
            //            else
            //            {
            //                result = num1 % num2;
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operator.");
            //            isValidOperation = false;
            //            break;
            //    }

            //    // Print the result if the operation was valid
            //    if (isValidOperation)
            //    {
            //        Console.WriteLine($"{num1} {op} {num2} = {result}");
            //    }

            //    Console.Write("Do you want to perform another operation? (Y/N): ");
            //    continueOperation = char.Parse(Console.ReadLine());

            //} while (continueOperation == 'Y' || continueOperation == 'y');

            #endregion

            #region Test-1-2

            //int[] arr = { 15, 2, 10, 11, 5, 9, 25, 1, 18, 20 };

            //int temp;
            //int minIndex;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    minIndex = i;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[minIndex])
            //        {
            //            minIndex = j;
            //        }
            //    }

            //    temp = arr[i];
            //    arr[i] = arr[minIndex];
            //    arr[minIndex] = temp;
            //}

            //Console.Write("Sorted Array: {");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(i==arr.Length - 1 ? arr[i] + " ": arr[i] + ",");
            //}
            //Console.WriteLine("}");

            //Console.WriteLine($"The Min Number in the array is: {arr[0]}");
            //Console.WriteLine($"The Max Number in the array is: {arr[arr.Length-1]}");

            #endregion

            #region Test-3

            //int[] arr = { 15, 2, 10, 11, 5, 9, 25, 1, 18, 10 };

            //Console.Write("Enter the number you want to search for: ");
            //int targetNum = int.Parse(Console.ReadLine());

            //string targetIndices = "";
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (targetNum == arr[i])
            //    {
            //        if (count > 0)
            //        {
            //            targetIndices += ", ";
            //        }
            //        targetIndices += i.ToString();
            //        count++;
            //    }
            //}

            //if (count > 0)
            //{
            //    Console.WriteLine($"Number {targetNum} was found at {count} Position(s) at index(es) {targetIndices}");
            //}
            //else
            //{
            //    Console.WriteLine("The number you searched for was not found.");
            //}

            #endregion

            #region Test-4

            int[,] matrixA;
            int[,] matrixB;
            int[,] matrixR;

            int rowsA, colsA, rowsB, colsB;

            // Get the matrices dimensions from the user
            Console.Write("First matrix rows = ");
            rowsA = int.Parse(Console.ReadLine());
            Console.Write("First matrix columns = Second matrix rows = ");
            colsA = rowsB = int.Parse(Console.ReadLine());
            Console.Write("Second matrix columns = ");
            colsB = int.Parse(Console.ReadLine());

            matrixA = new int[rowsA, colsA];
            matrixB = new int[rowsB, colsB];
            matrixR = new int[rowsA, colsB];

            // Fill the first matrix
            Console.WriteLine($"Enter values for {matrixA.GetLength(0)}×{matrixA.GetLength(1)} Matrix A:");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.Write($"Enter value for position [{i},{j}]: ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------");

            // Fill the second matrix
            Console.WriteLine($"Enter values for the {matrixB.GetLength(0)}×{matrixB.GetLength(1)} Matrix B:");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    Console.Write($"Enter value for position [{i},{j}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------");

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        matrixR[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("Matrix A: ");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.Write(j == 0 && matrixA.GetLength(1) == 1 ? "|\t" + matrixA[i, j] + "\t|\n" :
                        j == 0 ? "|\t" + matrixA[i, j] : "\t" + matrixA[i, j] + "\t|\n");
                }
            }

            Console.WriteLine("\n\t×\n");

            Console.WriteLine("Matrix B: ");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    Console.Write(j == 0 && matrixB.GetLength(1) == 1 ? "|\t" + matrixB[i, j] + "\t|\n" :
                        j == 0 ? "|\t" + matrixB[i, j] : "\t" + matrixB[i, j] + "\t|\n");
                }
            }

            Console.WriteLine("\n\t=\n");

            Console.WriteLine("Matrix R: ");
            for (int i = 0; i < matrixR.GetLength(0); i++)
            {
                for (int j = 0; j < matrixR.GetLength(1); j++)
                {
                    Console.Write(j == 0 && matrixR.GetLength(1) == 1 ? "|\t" + matrixR[i, j] + "\t|\n" :
                        j == 0 ? "|\t" + matrixR[i, j] : "\t" + matrixR[i, j] + "\t|\n");
                }
            }

            #endregion
        }
    }
}
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
