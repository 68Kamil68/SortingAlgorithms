import React, { Component } from "react";

export class FetchSort extends Component {
    static displayName = FetchSort.name;

    constructor(props) {
        super(props);
        this.state = { array: [], noArrayReceived: true, sorted: false, sorting: true };
        this.unsortedArray = [];
        this.size = 10;
        this.getUnsortedArray = this.getUnsortedArray.bind(this);
    }
    //TODO: DRAGGABLE SIZE

    render() {
        let contents = this.state.noArrayReceived
            ? <p><em>Set size and generate an array</em></p>
            : FetchSort.renderArray(this.state.array);
        let sortButtons = this.state.noArrayReceived
            ? <p>.</p>
            : <><button className="btn btn-primary" onClick={() => this.bubbleSort()}>Use bubble sort</button>
            <button className="btn btn-primary" onClick={() => this.selectionSort()}>Use selection sort</button>
            <button className="btn btn-primary" onClick={() => this.mergeSort()}>Use merge sort</button>
            <button className="btn btn-primary" onClick={() => this.quickSort()}>Use quick sort</button></>;

        let sortedNotification = this.state.sorted 
            ? <p><em>sorted</em></p>
            : <p><em>not sorted</em></p>

        let sortingInfo = this.state.sorting 
            ? <br></br>
            : <p><em>sorting...</em></p>
        return (
            <div>
                <h1>Sorting Algorithms</h1>
                Size of an array: <input type="number" id="num" defaultValue="100"/>
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

    async quickSort() {
        this.setState({ array: this.unsortedArray, sorted: false, sorting: true });
        const response = await fetch('Sort/QuickSort', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.unsortedArray),
        });
        const array = await response.json();
        this.setState({ array: array, sorted: true, sorting: false });
    }

    async mergeSort() {
        this.setState({ array: this.unsortedArray, sorted: false, sorting: true });
        const response = await fetch('Sort/MergeSort', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.unsortedArray),
        });
        const array = await response.json();
        this.setState({ array: array, sorted: true, sorting: false });
    }

    async bubbleSort() {
        this.setState({ array: this.unsortedArray, sorted: false, sorting: true });
        const response = await fetch('Sort/BubbleSort', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.unsortedArray),
        });
        const array = await response.json();
        this.setState({ array: array, sorted: true, sorting: false });
    }

    async selectionSort() {
        this.setState({ array: this.unsortedArray, sorted: false, sorting: true });
        const response = await fetch('Sort/SelectionSort', {
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
        if (array.length > 25) {
            return (
                <h4>Loaded array but it's too big to show. Check console</h4>
            );
        }
        var array1 = array.toString();
        return (
            <h4>{array1}</h4>
                );
    }
}