import React, { Component } from "react";

export class Sort extends Component {
    static displayName = Sort.name;

    constructor(props) {
        super(props);
        this.data = [];
    }

    render() {
        return (
            <div>
                <h1>Sorting Algorithms</h1>

                <button className="btn btn-primary" onClick={this.getUnsortedArray}>Generate unsorted array</button>
            </div>
        );
    }

    async getUnsortedArray() {
        const response = await fetch('sort');
        const dataa = response.json();
        this.data = dataa;
    }
}