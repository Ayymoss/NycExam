# NycExam


This is my attempt at the below. I took creative license in the design and doesn't stick to a few of the requested rules. :shrug:

```
Create a Student grading system for a class size of 5, using inheritance.
You should create a person base class (stores the name and age of the person).
Derive a student class from the person class.  The student class stores the student ID.

The student class should also store the students 3 exams (Test 1, Test 2, and Test 3).  You can use an array or 3 variables for this.
The student class should have a printInfo function which outputs, the student name, age, and letter grade.
The letter grade is derived by using the 3 test scores,  taking the average and outputing a letter grade based on the 
grading system below:
A - 90-100
B - 80-89
C - 70-79
D - 64-69
F < 64

Since there are 5 students in the class, you will need to create an array, which each array element storing a student object. 

Obviously you will need to create constructors for each class (student should call the base class person), make all member data private and create accessor/Mutator functions.
For the printInfo, you will need to use Person's assessor methods for name and age.

To enter the test exams for each student, you will need to implement a input function, which will 
prompt (via keyboard) the user to enter 3 scores, for each student.

The other member data (name, age, ID) can be supplied using literals during the constructor call.

You will be looping through your array a few times - once to instantiate each student object (calling the constructor),
then again to perform the input (for each student),
and finally to call the printInfo.  Note that you should perform the grade calculation as the last step within the input function.
```
