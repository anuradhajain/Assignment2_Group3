using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_S19
{
    class Program // rashmi test
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            
            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));
            
            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
            int[] r2 = missingNumbers(arr1, brr);
            Console.Write("\nThe Complete array is: ");
            displayArray(brr);
            Console.Write("\nThe smaller array is: ");
            displayArray(arr1);
            Console.Write("\nThe missing numbers in array are: ");
            displayArray(r2);
            
            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine(findMedian(arr2));

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            
            // Display exit message
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey(true);

        } // end of main

        // method to display array elements
        static void displayArray(int []arr) {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        }

        // method to perform selection sort in ascending order
        public static int[] selectionSort(int[] a)
        {
            // selection is taking each element of the array, comparing it to all other element to find the lowest and swaping the lowest value to the first position of unsorted array
            for (int i = 0; i < a.Length; i++)
            {
                int min = a[i]; // assigning the first element to be the minimum in the begining of sort
                int minindex = i; // keeping track of the position of the minimum element
                // Comparing an element with all other array elements through this array
                for (int j = i + 1; j < a.Length; j++)
                {
                    // If the element is lower then the assigned minimum, swaping, otherwise no swaping 
                    if (a[j] < min)
                    {
                        min = a[j];
                        minindex = j;

                    } // end of if

                } // end of for loop j

                a[minindex] = a[i];
                a[i] = min;

            } // end of for loop i

            // displaying the sorted array            
            return (a);

        } // end of selectionSort(int[] a) method

        // method to find the sum of elements of an array
        static int arraySum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                // calculating the sum and storing the value in variable sum
                sum = sum + a[i];
            } // end of for loop i

            // returns the sum of the array elements to the calling function
            return (sum);

        } // end of method arraySum(int[] a) method

        // rotLeft method that returns an array rotated a specified  number of times
        static int[] rotLeft(int[] a, int d)
        {
            // running for loop d number of times for rotating left
            for (int i = 0; i < d; i++)
            {
                int temp = a[0]; // holding the first array element in temp so that its position can be emptied to move the second element to its place
                // using for loop to shift all array element one position to the left
                for (int j = 0; j < a.Length - 1; j++)
                {
                    a[j] = a[j + 1];
                } // end of for loop j 
                a[a.Length - 1] = temp; // assigning the temp value to the last of array hence completing one left rotation
            } // end of for loop i
            return a;
        } // end of rotLeft method

        // method to find the maximum number of toys that can be bought in a given budget of k dollars
        static int maximumToys(int[] prices, int k)
        {
            // sorting the price array
            int[] sortedprices = selectionSort(prices);
            // if the sum of all prices in the array is less than k amount return all toys
            int sumPrices = arraySum(sortedprices);
            if (sumPrices < k)
            {
                return (sortedprices.Length);
            } //end of if

            else
            {
                int sum = 0; // variable sum holds the addition of prices till it is less than or equal to k amount
                int i = 0; // i is the number of toys
                // Perform while loop till the addition of prices is less than or equal to k amount
                while (sum <= k)
                {
                    sum = sum + sortedprices[i];
                    i++;
                } // end of while loop

                return (i - 1);
            }
        } // end of maximumToys method

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            return "";
        }

        // missing number method
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            // creating an empty array to store the missing elemnts
            int[] missarray = new int[brr.Length];
            // for loop for each array element
            for (int i = 0; i < brr.Length; i++)
            {
                // calculating the frequeny of that array element in array brr
                int freq1 = 0;
                for (int j = 0; j < brr.Length; j++)
                {
                    if (brr[i] == brr[j])
                    {
                        freq1++;
                    } // end of if

                } // end of for loop j

                // calculating the frequeny of that array element in array arr
                int freq2 = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    if (brr[i] == arr[k])
                    {
                        freq2++;
                    } // end of if

                } // end of for loop k 

                // if the frequency of that number in array brr is not equal to its frequency in arr, print it, meaning its missing
                if (freq1 != freq2 || freq1 > freq2)
                {
                    // storing the missing element to missarray
                    missarray[i] = brr[i];
                    //Console.WriteLine(brr[i]);
                }
                else
                {
                    missarray[i] = 500;
                }

            } // end of for loop i
            return missarray.Distinct().ToArray(); ;
        } // end of missingNumbers method

        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            return new int[] { };
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            return 0;
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            return new int[] { };
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            return "";
        }
    } // end of class
} // end of namespace
