import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Algorithm name</th>
                        <th>Description</th>
                        <th>Time complexity</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Bubble Sort</td>
                        <td>Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.&nbsp;
                            <a href="https://www.geeksforgeeks.org/bubble-sort/">Source</a>
                        </td>
                        <td><b>O(N^2)</b></td>
                    </tr>
                    <tr>
                        <td>Selection Sort</td>
                        <td>The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning.&nbsp;
                            <a href="https://www.geeksforgeeks.org/selection-sort/">Source</a>
                            </td>
                        <td><b>O(N^2)</b></td>
                    </tr>
                    <tr>
                        <td>Merge Sort</td>
                        <td>Merge sort works on the principle of Divide and Conquer. Merge sort repeatedly breaks down a list into several sublists until each sublist consists of a single element and merging those sublists in a manner that results into a sorted list.&nbsp;
                            <a href="https://www.interviewbit.com/tutorial/merge-sort-algorithm/">Source</a>
                            </td>
                        <td><b>&Theta;(nLogn)</b></td>
                    </tr>
                    <tr>
                        <td>Quick Sort</td>
                        <td>QuickSort is one of the most efficient sorting algorithms and is based on the splitting of an array into smaller ones. The name comes from the fact that, quick sort is capable of sorting a list of data elements significantly faster than any of the common sorting algorithms. And like Merge sort, Quick sort also falls into the category of divide and conquer approach of problem-solving methodology.&nbsp; 
                            <a href="https://www.interviewbit.com/tutorial/quicksort-algorithm/">Source</a>
                            </td>
                        <td><b>&Theta;(nLogn)</b></td>
                    </tr>
                </tbody>
            </table>
            <h2>If you want to test any of them, <a href='/fetch-sort/'>click here</a> or click the link in the top right corner.</h2>
      </div>
    );
  }
}
