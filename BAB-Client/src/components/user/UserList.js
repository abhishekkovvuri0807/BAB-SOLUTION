import React, { Component } from 'react';
import axios from "axios";



class UserList extends Component {

    state = {
        userList: []
    }

    constructor(props) {
        super(props);
    }

    componentDidMount() {
        this.getUsers();
    }


    getUsers = () => {
        axios.get("https://localhost:44353/tblEmployees").then(res => {
            if (res.status !== 200) {
                alert(res.data);
                this.setState({
                    loading: false,
                    sentences: [],
                    error: res.data,
                });
                return;
            } else {
                console.log("result");
                console.log(res);
            }
        })
    }


    render() {
        return  <h1>User List</h1>
    }
}

export default UserList