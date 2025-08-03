import React from 'react';

function BookDetails() {
  return (
    <div>
      <h2>Book Details</h2>
      <ul>      {/*returns an undordered list with the title, author, pages of a particular book*/}
        <li>Title: Clean Code</li>
        <li>Author: Robert C. Martin</li>
        <li>Pages: 464</li>
      </ul>
    </div>
  );
}
  
export default BookDetails;        //default export 
