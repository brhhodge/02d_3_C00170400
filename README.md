# 02d_3_C00170400
CMPS358_Assignment8

Programming Assignment:

1. Create a C# console project in Visual Studio Code and name it “02d_3_your-clid”. When the project
runs correctly, clean the project, zip the project folder and upload it in Moodle.

2. Do the following exercises.

(a) (20 points) First, copy the following code into the Main method of the default class. Next, write the
required method NameThatPerson - without using if , switch or ternary statements – so that it
outputs

i. the length of the name passed to it, but length is not output if null is passed to it.

ii. the name passed to it or “Anonymous” if null is passed to it.


String name = "Bob E.";
NameThatPerson(name);
name = null;
NameThatPerson(name);


(b) (10 points) First, copy the following static method into the default class. Method Populate returns an
array of elements of type int?[] of random length between 10 and 20 elements. Write the code in
method Main to call method Populate 10 times and output the average length of the 10 arrays
returned.


static int?[] Populate()
{
Random random = new Random();
int?[] a = new int?[random.Next(10) + 10];
for(int i = 0; i < a.Length; i++)
if (random.Next(2) == 1)
a[i] = random.Next(10) + 1;
return a;
}


(c) (20 points) Using the method Populate as copied into the default class in (b), write the code in
method Main to call method Populate 20 times and output the combined sum of all elements in all
twenty arrays. Note that method Populate has the peculiar habit of randomly assigning integer
values in the range of [1,10] or null to the array elements. This code must be written without the use
of if , switch or ternary statements.

3. Example output (and remember (b) and (c) call a method that returns random results):

(a) example output of (a):


Length: 6
Bob E.
Length:
anonymous


(b) example output of (b):


Average Length: 15


(c) example output of (c):


Sum of non-null elements: 809
