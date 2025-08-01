// src/App.js
import React, { useState } from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
  const [selected, setSelected] = useState('');
  const [showAll, setShowAll] = useState(false);

  const showBook = selected === 'book';
  const showBlog = selected === 'blog';
  const showCourse = selected === 'course';

  return (
    <div style={{ padding: '20px' }}>
      <h1>📌 BloggerApp - Conditional Rendering Demo</h1>

      <div style={{ marginBottom: '15px' }}>
        <button onClick={() => setSelected('book')}>Show Book</button>{' '}
        <button onClick={() => setSelected('blog')}>Show Blog</button>{' '}
        <button onClick={() => setSelected('course')}>Show Course</button>{' '}
        <button onClick={() => setShowAll(!showAll)}>
          {showAll ? 'Hide All' : 'Show All'}
        </button>
      </div>

      {/* Using if-else style logic */}
      {showBook ? <BookDetails /> : null}

      {/* Using ternary operator */}
      {showBlog ? <BlogDetails /> : <></>}

      {/* Using logical && */}
      {showCourse && <CourseDetails />}

      {/* Bonus: Map + key usage */}
      {showAll &&
        [
          { id: 1, type: 'book', component: <BookDetails /> },
          { id: 2, type: 'blog', component: <BlogDetails /> },
          { id: 3, type: 'course', component: <CourseDetails /> },
        ].map((item) => (
          <div key={item.id} style={{ marginTop: '10px' }}>
            {item.component}
          </div>
        ))}
    </div>
  );
}

export default App;
