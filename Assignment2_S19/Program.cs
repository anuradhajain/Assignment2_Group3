using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_S19
{
    class Program 
    {
        static void Main(string[] args)
        {
            // --------------------- Question 1 --------------------
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine("The Original Array is: ");
            displayArray(a);
            Console.WriteLine("\nThe Left Roatated Array is: ");
            int[] r = rotLeft(a, d);
            displayArray(r);
            Console.WriteLine("\n------------------------------------------------------");
            // --------------------- Question 2 --------------------
            // Maximum toys
            Console.WriteLine("\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            Console.WriteLine("\n------------------------------------------------------");
            // --------------------- Question 3 --------------------
            // Balanced sums
            Console.WriteLine("\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3, 3 };
            Console.WriteLine(balancedSums(arr));
            Console.WriteLine("\n------------------------------------------------------");
            // --------------------- Question 4 --------------------
            // Missing numbers
            Console.WriteLine("\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
            int[] r2 = missingNumbers(arr1, brr);
            Console.WriteLine("\nThe Complete array is: ");
            displayArray(brr);
            Console.WriteLine("\nThe smaller array is: ");
            displayArray(arr1);
            Console.WriteLine("\nThe missing numbers in array are: ");
            displayArray(r2);
            Console.WriteLine("\n------------------------------------------------------");
            // --------------------- Question 5 --------------------
            // calling gradingstudent method by passing the array of student grades

            // grading students
            Console.WriteLine("\nGrading students");
            int[] grades = { 73, 67, 38, 33, 82, 46, 74, 48, 98, 59 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);
            Console.WriteLine("\n------------------------------------------------------");
            // --------------------- Question 6 --------------------
            // find the median
            Console.WriteLine("\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine("median is :" + findMedian(arr2));

            Console.WriteLine("\n------------------------------------------------------");
            // --------------------- Question 7 --------------------
            // closest numbers
            Console.WriteLine("\nClosest numbers");
            int[] arr3 = { 1, 2, 4, 5, 9, 7, 11, 8, 9, 10 };
            Console.WriteLine("The Test array is as below :");
            displayArray(arr3);
            Console.WriteLine("\n");
            Console.WriteLine("The Closest Pair array is as below: ");
            int[] r4 = closestNumbers(arr3);

            displayArray(r4);

            Console.WriteLine("\n------------------------------------------------------");
            // --------------------- Question 8 --------------------
            // calling Day of Programmer method by passing the array of student grades
            // Day of programmer
            Console.WriteLine("\nDay of Programmer");
            int year = 1978;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey();
           

            
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
        //-------------------------------------------------------------------------------------------------------------------
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
        //---------------------------------------------------------------------------------------------------------------
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
        //-----------------------------------------------------------------------------------------------------------------
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
        //----------------------------------------------------------------------------------------------------------------
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
        //-------------------------------------------------------------------------------------------------------------------
        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            int n = arr.Count;

            int[] arr2 = arr.ToArray();

            //Calculate total sum of array
            int totalsum = 0;
            for (int i = 0; i < n; i++)
            {
                totalsum = totalsum + arr2[i];

            }

            //initiate a new array to store sum
            int[] sum = new int[n];
            sum[0] = arr2[0];
            for (int i = 1; i < n; i++)
            {
                sum[i] = sum[i - 1] + arr2[i];
            }
            //initiate new boolean
            bool balanced = false;

            //if there is only one number in a array
            if (n == 1)
                balanced = true;
            //check for sum of both side
            if (totalsum > 0)
            {
                for (int i = 1; i < n; i++)
                {
                    long leftsum = sum[i - 1];
                    long rightsum = sum[n - 1] - sum[i];
                    if (leftsum == rightsum)
                    {
                        balanced = true;
                        break;
                    }
                }
            }
            else
                balanced = true;

            // if there is only one number and rest are zero
            for (int i = 0; i < n; i++)
            {
                if (totalsum == arr2[i])
                {
                    balanced = true;
                }
            }

                if (balanced)
                {

                    return "YES";
                }
                else

                    return "No";
        }


        //------------------------------------------------------------------------------------------------------------------
        // missing number method
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            // ===========
            // creating an empty a list to store the missing elements
            ArrayList l = new ArrayList();
            // ===========

            // for loop for each array element
            for (int i = 0; i < brr.Length; i++)
            {
                // calculating the frequency of that array element in array brr
                int freq1 = 0;
                for (int j = 0; j < brr.Length; j++)
                {
                    if (brr[i] == brr[j])
                    {
                        freq1++;
                    } // end of if

                } // end of for loop j

                // calculating the frequency of that array element in array arr
                int freq2 = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    if (brr[i] == arr[k])
                    {
                        freq2++;
                    } // end of if

                } // end of for loop k 

                // if the frequency of that number in array brr is not equal to its frequency in arr, add it to the missing element array, meaning its missing
                if (freq1 != freq2 || freq1 > freq2)
                {
                    // ========
                    // storing the missing element in the list
                    l.Add(brr[i]);
                    // ==========
                }

            } // end of for loop i

            //============
            // creating an empty array to store missing numbers from list to this array
            int[] missarray = new int[l.Count];

            // copying each number from the list to the array
            int ind = 0;
            foreach (int i in l)
            {
                missarray[ind] = i;
                ind++;
            } // end of foreach loop
            //=============

            return missarray.Distinct().ToArray();
        } // end of missingNumbers method

        //-------------------------------------------------------------------------------------------------------------
        // Complete the gradingStudents function below.
        private static int[] gradingStudents(int[] grades)
        // The below piece of code will display the array of the grades decaled in the main fucntion.
        //This will provide a good reference for the rounded up grades to compare later
        {
            Console.Write("The Grades of Students are:");
            displayArray(grades);
            Console.WriteLine("\n");


            //The main piece of code does not round off these scores.
            for (int i = 0; i < grades.Length; i++)
            {
                while (grades[i] < 0 || grades[i] > 100)//Here We are checking if the grades entered into the array are between 0 to 100 only

                {
                    Console.WriteLine("Please enter valid grades betweeen 0 to 100 for : " + grades[i]);//For Any grades grater than 100 or less than 0, the code prints user to enter valid grades corresponding to those grades.
                    break;
                }
            }
            //This is the round off piece of code
            for (int j = 0; j < grades.Length; j++)
            {
                int a = 5 * (int)Math.Round((grades[j] / 5.0) + 0.5); //This line checks for every elements in array and perform operation to get a next possible number who is multiple of 5
                if (a - grades[j] < 3 && grades[j] >= 38) //We check the 2 conditions; if no is greater that 38 and difference between original no. and 'a' is less than 3 as per rounding off rule
                {
                    grades[j] = a;//if the condition is true we update the value of current array with rounded of multiple of five i.e.'a'
                }
                else
                {
                    grades[j] = grades[j];//else the number of array is kept as is
                }
            }
            //The rounded off grades are provided here.
            Console.Write("The Rounded off Grades of Students are as below:");
            return grades;
        }//End of Grading Student method

        //------------------------------------------------------------------------------------------------------------------
        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            int[] arr3 = arr;

            int count = arr3.Length;

          selectionSort(arr3);

            int median = 0;

            if (count % 2 == 0)

            {

                // count is even, need to get the middle two elements, add them together, then divide by 2

                int middle1 = arr3[(count / 2) - 1]; //left middle element

                int middle2 = arr3[(count / 2)]; //right middle element

                median = (middle1 + middle2) / 2;

            }

            else if (count % 2 != 0)

            {

                median = (arr3[(count / 2)]);  // count is odd, get the middle element.
                
            }
            else if (count == 0)

                Console.WriteLine("exception occure");

            return median;
        }
        //------------------------------------------------------------------------------------------------------------
        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            int[] arr3 = arr;  //Define new array
            int n = arr3.Length; //store length into a variable
            selectionSort(arr3); //Sort the array



            int[] sub = new int[n - 1]; //initiate new array for subtraction
            for (int i = 0; i < n - 1; i++)
            {
                sub[i] = arr3[i + 1] - arr3[i]; // Subtract each element from its previous element

            }
            selectionSort(sub);   //sort new array
            int[] sub1 = new int[n - 1];  //initiate new array to store the subtraction of elements of previous array
            List<int> pair = new List<int>(); //create new list
            int[] pair1 = new int[2 * (n - 1)]; // Initiate new array to store final values from the list
            for (int i = 0; i < n - 1; i++)
            {
                sub1[i] = arr3[i + 1] - arr3[i]; // Subtract each element from its previous element from the new array
                if (sub1[i] == sub[0]) //if element of array is equal to smallest element
                {
                    //Console.WriteLine( arr3[i] + "," + arr3[i + 1]);
                    int temp1 = arr3[i]; // store 1st element of a pair
                    int temp2 = +arr3[i + 1]; //store 2nd element of a pair
                    pair.Add(temp1); //add element to list
                    pair.Add(temp2);
                }
            }
            pair1 = pair.ToArray(); //convert list to array
            return pair1;
        }
            


           
        
        //---------------------------------------------------------------------------------------------------------------
                // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        // The below piece of code will display the Day of Programer i.e. 256th Date of year. 
        {
            Console.WriteLine("The Year input is : " + year); //The year inout given in main method is displayed
            int a = year;
            string b;
            if (a >= 1700 && a <= 1917)//Condition for year value is checked here.
            {
                Console.WriteLine("This is year of Julian Calender");//If above condtion is true the code prints Julian Calender
                if (a % 4 == 0)//Condition for leap year for Julian calnder is checked,if above condition is true then bewlo value is updated in 'b'
                {
                    b = "12.09"; 
                    Console.WriteLine("The day of Programmer is : " + b + "." + a);
                }
                else //If the above condition is not met then Below date is stored in 'b'
                {
                    b = "13.09";
                    Console.WriteLine("The day of Programmer is : " + b + "." + a);
                }
            }
            else if (a > 1918 && a <= 2700)//Condition for year value is checked here.
            {
                Console.WriteLine("This is year of Gregorian Calender");//If above condtion is true the code prints Gregorian Calender
                if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))//Condition for Gregorian leap year is checked here
                {
                    b = "12.09";
                    Console.WriteLine("The day of Programmer is : " + b + "." + a);
                }
                else//If not leap year then below value is stored in 'b'
                {
                    b = "13.09";
                    Console.WriteLine("The day of Programmer is : " + b + "." + a);
                }
            }
            else if (a == 1918) //This is a particular case of Calender Transformation year
            {
                Console.WriteLine("This is Transition year of Russian Calender System");
                b = "26.09";
                Console.WriteLine("The day of Programmer is : " + b + "." + a);
            }
            else// If the year range is not as specified above, then below code is executed
            {
                Console.WriteLine("The year " + a + " entered is out of range");
            }

            return "";
        }//End of Day of programmer  

    } // end of class
} // end of namespace
