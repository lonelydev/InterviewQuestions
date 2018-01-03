# Queue

A queue is an abstract data type that maintains the order in which elements were added to it, allowing the oldest elements to be removed from the front and new elements to be added to the rear. This is called a First-In-First-Out (FIFO) data structure because the first element added to the queue (i.e., the one that has been waiting the longest) is always the first one to be removed.

## Operations on a Queue

A basic queue has the following operations:

    Enqueue: add a new element to the end of the queue.
    Dequeue: remove the element from the front of the queue and return it.

In this challenge, you must first implement a queue using two stacks. Then process queries, where each query is one of the following types:

    1 x: Enqueue element into the end of the queue.
    2: Dequeue the element at the front of the queue.
    3: Print the element at the front of the queue.

## Input Format

The first line contains a single integer, , denoting the number of queries.
Each line of the subsequent lines contains a single query in the form described in the problem statement above. All three queries start with an integer denoting the query , but only query is followed by an additional space-separated value, , denoting the value to be enqueued.

### Constraints

    It is guaranteed that a valid answer always exists for each query of type .

## Output Format

For each query of type , print the value of the element at the front of the queue on a new line.

## Sample Input

10
1 42
2
1 14
3
1 28
3
1 60
1 78
2
2

## Sample Output

14
14

## Explanation

We perform the following sequence of actions:

  1. Enqueue 42; queue = {42}.
  1. Dequeue the value at the head of the queue, 42; queue = {}.
  1. Enqueue 14; queue = {14}.
  1. Print the value at the head of the queue, 14; queue = {14}.
  1. Enqueue 28; queue = {14 <- 28}.
  1. Print the value at the head of the queue, 14; {14 <- 28}.
  1. Enqueue 60; queue = {14 <- 28 <- 60}.
  1. Enqueue 78; queue = {14 <- 28 <- 60 <- 78}.
  1. Dequeue the value at the head of the queue, 14; queue = {28 <- 60 <- 78}.
  1. Dequeue the value at the head of the queue, 28; queue = {60 <- 78}.

This question is from [Hackerrank](https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem)