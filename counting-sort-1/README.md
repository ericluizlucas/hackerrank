# Counting Sort

## Comparison Sorting

Quicksort usually has a running time of , but is there an algorithm that can sort even faster? In general, this is not possible. Most sorting algorithms are comparison sorts, i.e. they sort a list just by comparing the elements to one another. A comparison sort algorithm cannot beat  (worst-case) running time, since  represents the minimum number of comparisons needed to know where to place each element.

For more details, you can see "<a href="http://www.cs.cmu.edu/~avrim/451f11/lectures/lect0913.pdf">these notes</a>" (PDF)

## Alternative Sorting

Another sorting method, the counting sort, does not require comparison. Instead, you create an integer array whose index range covers the entire range of values in your array to sort. Each time a value occurs in the original array, you increment the counter at that index. At the end, run through your counting array, printing the value of each non-zero valued index that number of times.

### Example
arr = [1,1,3,2,1]

All of the values are in the range [0...3], so create an array of zeros, result = [0,0,0,0]. The results of each iteration follow:

i&emsp;arr[i]&emsp;&emsp;result<br/>
0&emsp;1&emsp;&emsp;[0, 1, 0, 0]<br/>
1&emsp;1&emsp;&emsp;[0, 2, 0, 0]<br/>
2&emsp;3&emsp;&emsp;[0, 2, 0, 1]<br/>
3&emsp;2&emsp;&emsp;[0, 2, 1, 1]<br/>
4&emsp;1&emsp;&emsp;[0, 3, 1, 1]<br/>

The frequency array is [0,3,1,1]. These values can be used to create the sorted array as well: sorted = [1,1,1,2,3].

### Note
For this exercise, always return a frequency array with 100 elements. The example above shows only the first 4 elements, the remainder being zeros.

### Challenge
Given a list of integers, count and return the number of times each value appears as an array of integers.

### Function Description

Complete the countingSort function in the editor below.

countingSort has the following parameter(s):

&#x2022; arr[n]: an array of integers
Returns

&#x2022; int[100]: a frequency array

### Input Format

The first line contains an integer n, the number of items in 'arr'.
Each of the next n lines contains an integer arr[i] where 0 <= i < n.

### Constraints

100 <= n <= 10⁶<br/>
0 <= arr[i] < 100

