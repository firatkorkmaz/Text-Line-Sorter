# Text Line Sorter
A simple program to sort text lines of an input file and save them in a new text file.

## General Information
This is a simple C# program that takes a filename from the input, reads all its lines and gives those options to the user:

1. Remove Duplicate Lines? (Y/N)
2. Order the Lines? (Y/N)
3. Order by Ascending/Descending? (A/D)
4. Trim Lines? (Y/N)

Then, the text lines in the input file are processed by those choices, and the newly sorted lines are saved in a new text file.

There are 2 different input files given:

* **data1.txt**: This has 50 different clean names of actors with 3 repetitions each, and there are 150 lines of names in total.
* **data2.txt**: This also has 50 different names of actors with 3 repetitions each, and there are 150 lines of names in total, but each name has additional unnecessary characters to be trimmed.

## Technologies
This project is created with:
* Microsoft Visual Studio
  * C# Console Application

## Setup & Run
To run this project, open the **SortTextLines.sln** solution file with Visual Studio, then build and run this solution, or use C# compiler to directly compile the **Program.cs** file and run the created executable (.exe) file:
```
csc Program.cs
```
The input files related to this program are given in both the root directory and the execution working directory of this solution: **.../bin/Debug/net6.0/**
