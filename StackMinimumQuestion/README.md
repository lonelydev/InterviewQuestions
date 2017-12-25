Implement a Stack in which you can get min element in O(1) time and O(1) space.

Input (To be used for Expected Output):
The first line of the input contains an integer 'T' denoting the number of test cases. Then T test cases follow.
First line of each test case contains an integer Q denoting the number of queries . 
A Query Q is of 3 Types
(i)   1 x (a query of this type means  pushing 'x' into the stack)
(ii)  2 (a query of this type means to pop element from stack and print the poped element)
(iii) 3 (a query of this type means to print the minimum element from the stack)

The second line of each test case contains Q queries seperated by space.

Output:

The output for each test case will  be space separated integers having -1 if the stack is empty else the element poped out  or min element from the stack .
You are required to complete the three methods push which take one argument an integer 'x' to be pushed into the stack , pop which returns a integer poped out from the stack and getMin which returns the min element from the stack.

Constraints:
1<=T<=100
1<=Q<=100
1<=x<=100

Example:
Input
1
6
1 2 1 3 2 3 1 1 3    

Output
3 2 1

