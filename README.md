# NET.W.2016.01.Lioshyn.04

1. Develop a unit-tests using either NUnit Framework, and MS Unit Test Framework (here it is desirable to try to approach Data Driven Testing, an example in UnitTesting.zip archive projects and DDT.Demo DDT.Demo.Tests) to test the method of problem 5.
2. To develop a unit-tests for the methods of testing tasks 6, 7.
3. Develop a method to calculate the root of the n-th degree of the number of Newton's method with the specified accuracy. Develop unit-tests to test the resulting method.
4. Implement an extension method for the binary representation of a real number in the IEEE double precision format 754. Develop unit tests.
5. Given an array of integers. Find the array and return an index n, such that the sum of the elements on the left of it is the sum of the right elements. If such an index does not return null (-1).

For example.
* For an array {1,2,3,4,3,2,1} function returns the index of 3 as the 3rd
 array positions, the amount left of the index ({1,2,3}) and right index ({3,2, 1})
  6 are equal.
* For an array {1,100,50, -51,1,1} function returns the index 1, since the 1st
array position from the sum of the left index ({1}) and right index ({50} -51,1,1)
equal to 1.
Input: An integer array of length 0 <length <1000. The numbers in the array can be any positive or negative integer.
Output: The smallest index for which the left side is the right side. If such an index does not exist return -1 (null).

6. For two strings that contain only characters from 'a' to 'z', to return a concatenated string sorted in alphabetical order, except for recurring characters.

For example.

a = "xyaabbbccccdefww"

b = "xxxxyyyyabklmopq"

Longest (a, b) -> "abcdefklmopqwxy"


a = "abcdefghijklmnopqrstuvwxyz"

Longest (a, a) -> "abcdefghijklmnopqrstuvwxyz

7. Given two iconic four-byte integer number and two bit positions i and j (i <j). Implement an algorithm inserts one number to the other so that the second number took a position with the bit by bit i j (bits are numbered from right to left).
For example.
Insertion (8,15,0,0) -> 9
Insertion (0, 15, 30, 30) -> 1073741824
Insertion (0, 15, 0, 30) -> 15
Insertion (15, -15, 0, 4) -> 31
Insertion (15, int.MaxValue, 3, 5) -> 63
