# Egg Drop puzzle

## Introduction

The following is a description of the instance of this famous puzzle involving n=2 eggs and a building with k=36 floors.

So we want to know which floors in a 36-story building are safe to drop eggs from. We first make a few assumptions:

  * An egg that survives a fall can be used again for a drop test.
  * A broken egg must be discarded - no point in dropping a broken egg again.
  * The effect of a fall is the same for all eggs - all eggs are created equal.
  * If an egg breaks when dropped from one floor, then it would definitely break if dropped from a higher floor.
  * If an egg survives a fall from a floor, then it would survive a fall from a lower floor.
  * It is not ruled out that the first-floor windows break eggs, nor is it ruled out that the 36th-floor do not cause an egg to break.

In this problem you have to find the minimum number of trials required to find where n eggs would break in a building of k floors.

## Online Resources

  * One of the best video descriptions of the problem can be watched here: [Ted Ed Video on Youtube](https://www.youtube.com/watch?v=NGtt7GJ1uiM).

  * For more details on the problem you could also check out [Dynamic Programming on Wikipedia](https://en.wikipedia.org/wiki/Dynamic_programming#Egg_dropping_puzzle).

  * Another great explanation of the problem description can be found here: [Brilliant.Org - Egg Drop Problem Explained](https://brilliant.org/wiki/egg-dropping/#2-eggs-100-floors)

## Solutions

There are plenty of ways to solve this problem. 
  
  * Recursive method
  * Dynamic programming method
  * Recursion in combination with binary search

### Recursive solution 

![](images/egg-drop-recursive-basics.png)

#### Pseudo code:

```python
def drops(n,h):
    if(n == 1 or k == 0 or k == 1):
        return k
    end if

    minimum = ∞

    for x = 1 to h:
        minimum = min(minimum, 
                      1 + max(drops(n - 1, x - 1), drops(n, h - x))
                      )
    end for

    return minimum
```

Solution Implemented in `EggDropSolverRecrusive`.

