# Merge Sort

There are several sorting algorithms and **merge sort** is just one of them. 
It uses a [Divide and Conquer](https://en.wikipedia.org/wiki/Divide_and_conquer_algorithm) strategy to sorting. What that means is given a set of objects, merge sort attempts to sort the set by dividing the set into smaller groups and sorting each individual group by applying the same divide strategy recursively. 

That might have been a lot of words to understand the concept. 
Let us look at it using an example. 

## Algorithm

Conceptually, a merge sort works as follows:

  1. Divide the unsorted list into `n` sublists, each containing 1 element (a list of 1 element is considered sorted).
  1. Repeatedly merge sublists to produce new sorted sublists until there is only 1 sublist remaining. This will be the sorted list.
 
## Complexity analysis

When sorting `n` objects merge sort has a worst case complexity of `O(n log n)`.

I wouldn't want to repeat the wonderful analysis done at [Khan Academy](https://www.khanacademy.org/computing/computer-science/algorithms/merge-sort/a/analysis-of-merge-sort). Please refer their analysis and you will know how the value is derived. 

## Problems:

I thought I'd take this opportunity to implement merge sort for different types of data structures. 

  * ArrayMergeSort - sorts and integer array in ascending order using merge sort
  * LinkedListMergeSort - sorts a linked list with integers in ascending order. 