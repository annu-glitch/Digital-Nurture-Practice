import React, { useState } from 'react';
import './App.css';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [selectedComponent, setSelectedComponent] = useState('book');
  const isLoggedIn = true; // just for demonstration

  return (
    <div className="App">
      <h1>Blogger App</h1>

      {/* 1. if/else rendering using ternary */}
      <div>
        <p>{isLoggedIn ? "Welcome Back!" : "Please log in"}</p>
      </div>

      {/* 2. Element variables */}
      <div>
        <button onClick={() => setSelectedComponent('book')}>Show Book</button>
        <button onClick={() => setSelectedComponent('blog')}>Show Blog</button>
        <button onClick={() => setSelectedComponent('course')}>Show Course</button>
      </div>

      <div>
        {
          selectedComponent === 'book' ? (
            <BookDetails />
          ) : selectedComponent === 'blog' ? (
            <BlogDetails />
          ) : (
            <CourseDetails />
          )
        }
      </div>

      {/* 3. Short-circuit (&&) rendering */}
      <div>
        {isLoggedIn && <p>You have access to premium content.</p>}
      </div>
    </div>
  );
}

export default App;

