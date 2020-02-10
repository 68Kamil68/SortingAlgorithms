import React, { Component } from "react";

export class FetchSort extends Component {
    static displayName = FetchSort.name;

    constructor(props) {
        super(props);
        this.state = { array: [] };
        this.unsortedArray = [];
    }

    render() {
        return (
            <div>
                <h1>Sorting Algorithms</h1>
                <button className="btn btn-primary" onClick={() => this.getUnsortedArray()}>Generate unsorted array</button>
            </div>
        );
    }

    async getUnsortedArray() {
        const response = await fetch('sort');
        const data = await response.json();
        console.log(data);
        this.unsortedArray = data;
        //this.setState({ array: data });
    }
}