import React, { Component } from "react";

export class Sort extends Component {
    static displayName = Sort.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <h1>Sorting Algorithms</h1>

                <button className="btn btn-primary">Generate unsorted array</button>
            </div>
        );
    }
}