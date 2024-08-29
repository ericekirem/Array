Array Operations Project
This project is a simple application in C# that demonstrates various operations on an array. The project includes adding data to an array, sorting the array, and updating the array by adding a new value provided by the user.

Project Steps
1. Step: Array Declaration
The application defines an array (int[]) to hold 10 integer values.
2. Step: Populate and Display the Array
The array is populated with random numbers using the Random class.
The array elements are then printed to the console using a foreach loop.
3. Step: Add a New Element
The user is prompted to enter a new integer value, which is added as the 11th element of the array.
A new array is created to accommodate this additional element, and the existing array elements are copied into this new array.
4. Step: Sort the Array
The array is sorted in descending order and displayed on the console.
The sorting is done using the Array.Sort and Array.Reverse methods.
Usage
Running the Project:

When the project is run, the program first populates the array with random integers and prints them to the console.
Next, the user is asked to input a number, which is then added to the array.
Finally, the updated array is sorted in descending order and printed.
Code Structure:

The Main method in the Program class handles all operations.
Basic C# classes and methods like Random, Array.Sort, and Array.Reverse are used.
Development
This project is a good starting point for understanding array operations and working on simple algorithms. Possible enhancements include:

Finding the average of the array elements.
Displaying the largest and smallest elements in the array.
Counting the occurrences of the user-provided value within the array.
Requirements
.NET Framework (or .NET Core)
A C# IDE (Visual Studio, Visual Studio Code, etc.)
