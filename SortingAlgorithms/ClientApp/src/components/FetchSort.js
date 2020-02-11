import React, { Component } from "react";

export class FetchSort extends Component {
    static displayName = FetchSort.name;

    constructor(props) {
        super(props);
        this.state = { array: [], noArrayReceived: true, sorted: false, sorting: false };
        this.unsortedArray = [];
    }
    //TODO: DRAGGABLE SIZE

    render() {
        let contents = this.state.noArrayReceived
            ? <p><em>Set size and generate an array</em></p>
            : FetchSort.renderArray(this.state.array);
        let sortButtons = this.state.noArrayReceived
            ? <br></br>
            : <><button className="btn btn-primary" onClick={() => this.Sort('BubbleSort')}>Use bubble sort</button>
            <div class="divider" />
            <button className="btn btn-primary" onClick={() => this.Sort('SelectionSort')}>Use selection sort</button>
            <div class="divider" />
            <button className="btn btn-primary" onClick={() => this.Sort('MergeSort')}>Use merge sort</button>
            <div class="divider" />
            <button className="btn btn-primary" onClick={() => this.Sort('QuickSort')}>Use quick sort</button></>;

        let sortedNotification = this.state.sorted 
            ? <p><em>sorted</em></p>
            : <></>

        let sortingInfo = this.state.sorting 
            ? <p><em>sorting...</em></p>
            : <br></br>
        return (
            <div>
                <h1>Sorting Algorithms</h1>
                Size of an array: <input type="number" id="num" defaultValue="10" />
                <div class="divider"/>
                <button className="btn btn-primary" onClick={() => this.getUnsortedArray()}>Generate unsorted array</button>
                {contents}
                {sortButtons}
                {sortedNotification}
                {sortingInfo}
            </div>
        );
    }

    async getUnsortedArray() {
        const size = document.getElementById("num").value;
        const response = await fetch('Sort/Generate', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(size),
        });
        const array = await response.json();
        console.log(array);
        this.setState({ array: array, noArrayReceived: false, sorted: false });
        this.unsortedArray = array;
    }


    async Sort(algorithm) {
        this.setState({ array: this.unsortedArray, sorted: false, sorting: true });
        const response = await fetch(`Sort/${algorithm}`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.unsortedArray),
        });
        const array = await response.json();
        this.setState({ array: array, sorted: true, sorting: false });
    }

    static renderArray(array) {
        if (array.length > 20) {
            return (
                <h4>Generated and loaded the array but it's too big to show. Check the console in order to see it.<br></br> Set a size not higher than 20 in order to see the array.</h4>
            );
        }
        var array1 = array.toString();
        return (
            <h4>{array1}</h4>
                );
    }
}