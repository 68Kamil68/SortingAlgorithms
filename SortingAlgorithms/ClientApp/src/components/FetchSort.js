import React, { Component } from "react";

export class FetchSort extends Component {
    static displayName = FetchSort.name;

    constructor(props) {
        super(props);
        this.state = { array: [] };
        this.unsortedArray = [];
        this.size = 10;
        this.getUnsortedArray = this.getUnsortedArray.bind(this);
    }
    //TODO: DRAGGABLE SIZE, SHOWING ARRAY
    render() {
        return (
            <div>
                <h1>Sorting Algorithms</h1>
                Size of an array: <input type="number" id="num" defaultValue="100"/>
                <button className="btn btn-primary" onClick={() => this.getUnsortedArray(11)}>Generate unsorted array</button>
            </div>
        );
    }

    async getUnsortedArray(data) {
        const response = await fetch('sort', {
            method: 'POST',
            headers: {
                'Content-Type': 'text/plain',
            },
            body: data,
        });
        //const response = await fetch('sort', {
        //    method: "POST",
        //    headers: {
        //        'Accept': 'application/json',
        //        'Content-Type': 'application/json',
        //    },
        //    body: Size = '10'
        //});
        //console.log(size);
        const array = await response.json();
        console.log(array);
        this.unsortedArray = array;
        //this.setState({ array: data });
    }
}