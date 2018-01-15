# Encrypted Message

## Problem description

A top secret message containing letters from `A-Z` is being encoded to numbers using the following mapping:

    'A' -> 1
    'B' -> 2
    ...
    'Z' -> 26

You are an FBI agent. You have to determine the total number of ways that message can be decoded.

    Note: An empty digit sequence is considered to have one decoding. 

  * It may be assumed that the input contains valid digits from 0 to 9 
  * If there are leading 0’s, extra trailing 0’s and two or more consecutive 0’s then it is an invalid string.

## Online Resources

  * Solution and explanation: https://www.geeksforgeeks.org/count-possible-decodings-given-digit-sequence/
  * https://www.topcoder.com/community/data-science/data-science-tutorials/dynamic-programming-from-novice-to-advanced/#!
  * https://www.hackerrank.com/domains/algorithms/dynamic-programming

## Example

Given encoded message "123",  it could be decoded as:

  * `"ABC" (1 2 3)`
  * `"LC" (12 3)`
  * `"AW" (1 23)`

So in total there are 3 ways of decoding the message.

### Input

First line contains the test cases T.  1<=T<=1000
Each test case have two lines
First is length of string N.  1<=N<=40
Second line is string S of digits from '0' to '9' of N length.

### Sample

#### Input

    2
    3
    123
    4
    2563

#### Output

    3
    2
