import React, { Component } from 'react';
import Post from './Post';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  loadPosts = () => {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(data => {
        const postList = data.map(post => new Post(post.userId, post.id, post.title, post.body));
        this.setState({ posts: postList });
      })
      .catch(error => {
        console.error('Error fetching posts:', error);
        this.setState({ hasError: true });
      });
  };

  componentDidMount() {
    this.loadPosts();
  }

  componentDidCatch(error, info) {
    alert("An error occurred: " + error.toString());
    this.setState({ hasError: true });
  }

  render() {
    return (
      <div>
        <h1>Posts</h1>
        {this.state.posts.map(post => (
          <div key={post.id}>
            <h3>{post.title}</h3>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
