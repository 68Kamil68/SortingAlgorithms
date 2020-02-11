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
                        <td></td>
                        <td><b>O(N^2)</b></td>
                    </tr>
                    <tr>
                        <td>Selection Sort</td>
                        <td></td>
                        <td><b>O(N^2)</b></td>
                    </tr>
                    <tr>
                        <td>Merge Sort</td>
                        <td></td>
                        <td><b>&Theta;(nLogn)</b></td>
                    </tr>
                    <tr>
                        <td>Quick Sort</td>
                        <td></td>
                        <td><b>&Theta;(nLogn)</b></td>
                    </tr>
                </tbody>
            </table>
            <h2>If you want to test any of them, <a href='/fetch-sort/'>click here</a> or click the link in the top right corner.</h2>
      </div>
    );
  }
}
