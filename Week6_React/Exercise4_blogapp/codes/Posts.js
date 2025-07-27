//parent component
import React, {Component} from 'react';        //for creating a class based component

import Post from './Post';  //import child component
class Posts extends Component {
    constructor(props){          //initialize the state
        super(props);      //pass props in base class constructor
        this.state = {   //state is used to stor dynamic data: belongs to current instance of component class
            posts: [],       //empty array that will store fetched posts
            hasError: false         //track fetching errors
        };
    }

    loadPosts = () => { 
        fetch('https://jsonplaceholder.typicode.com/posts')  //dummy REST API
        .then(response => response.json())   //HTML response to JSON
        .then(data => this.setState({posts: data}))     //update posts array with new data
        .catch(err =>{
            console.error('Error fetching posts:', err);
            this.setState({hasError: true});
        });
    };

    componentDidMount() {    //lifecycle methd called when component is first rendered
        this.loadPosts();         //fetches posts from external API
    }

    componentDidCatch(error, info){
        alert("Something went wrong: " + error);
    }

    render() {
        const {posts, hasError} = this.state;

        if (hasError) {
            return <h3>Error loading posts.</h3>;
        }

        return (
            <div>
                <h1>Blog Posts</h1>
                {posts.slice(0,10).map(post => (          
                    <Post key={post.id} title={post.title} body={post.body} />         
                ))}
            </div>
        );
    }
}

export default Posts;

