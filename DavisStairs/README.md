# Davis climbing stairs

Davis is the name of a very curious child. 

He lives in a large mansion with his parents and they have plenty of stairs to get to the different floors. 

Davis loves to climb stairs. Being a small child, climbing stairs help him look at the world from a higher position. 

But being an only child, he finds very different games to play on the stairs. One such game is what Davis calls, `3 ways of climbing stairs`.

His rules are simple:
  * He can climb a stair of `n` steps in three different ways
    * climb 1 step at a time
    * climb 2 steps at a time
    * climb 3 steps at a time. 

Now could you write a program that can find out all possible ways in which Davis can climb `n` steps in a stair?

## Input 

`n` - the number of steps to climb

    Note:
    There are various flavours of this problem. 
    Some of them give you a number of stairs, `x` and each of them would have `n` steps. 
    The question could be to find the number of ways to climb each stair. 


## Output

The total number of ways Davis can climb the stairs.

## Example inputs and outputs

If Davis had to climb `1` step, there is only `1` way to do it. Climb one step.

If Davis had to climb `2` steps, he has two ways to do it:
  * Climb 1 step and then another. 
  * Climb 2 steps in one go. 
  * A set based representation: `[{1, 1}, {2}]`
  * That is a total of `2` ways to climb

If Davis had to climb `3` steps, he could:
  * `[{1, 1, 1}, {1, 2}, {2, 1}, {3}]`
  * That is a total of `4` ways to climb 

## Online resources

There are a variety of problems that are similar to this one.
  * [GeeksForGeeks - Number of ways to get to the n'th step](https://www.geeksforgeeks.org/count-ways-reach-nth-stair/)
  * [Hackerrank - Davis staircase](https://www.hackerrank.com/challenges/ctci-recursive-staircase/problem)
  * [TutorialHorizon - Stair climbing puzzle](http://algorithms.tutorialhorizon.com/dynamic-programming-stairs-climbing-puzzle/)

## Tests

As the number of projects in this solution is growing like crazy, I would like to keep tests and question for a problem in the same project from now on. 

I will be moving other test projects into the question project as I go. 

## Solution

The easiest way to solve this is by recursion. 

We know that the child can climb stairs in three ways. The child gets to make that choice at every step. 

  * If the child decides to take `1` step, then we have to find number of ways to climb `n-1 steps  + 1`. 
  * If the child decides to climb `2` steps, then we have to find number of ways to climb `n-2 steps + 1`.
  * If the child decides to climb `3` steps, then we have to find number of ways to climb `n-3 steps + 1`.

Thus total number of ways to climb `n` steps would be:

    numberOfWays(n-1) + numberOfWays(n-2) + numberOfWays(n-3) + 1

