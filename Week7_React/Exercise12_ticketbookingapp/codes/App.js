import React, { useState } from 'react';
import './App.css';

function GuestPage() {        //returns guest page
  return (
    <div>
      <h2>Welcome Guest!</h2>
      <p>Browse available flight details below:</p>
      <ul>        {/*returns unordered list of flights*/}
        <li>Flight AI101 - Delhi to Mumbai</li>
        <li>Flight AI102 - Mumbai to Bengaluru</li>
        <li>Flight AI103 - Hyderabad to Chennai</li>
      </ul>
    </div>
  );
}

function UserPage() {             {/*displays when logged in*/}
  return (
    <div>
      <h2>Welcome User!</h2>
      <p>You are now logged in and can book tickets.</p>
      <button>Book Ticket</button>
    </div>
  );
}

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLoginClick = () => setIsLoggedIn(true);      //handles login state
  const handleLogoutClick = () => setIsLoggedIn(false);

  let pageContent;
  let button;

  if (isLoggedIn) {
    pageContent = <UserPage />;
    button = <button onClick={handleLogoutClick}>Logout</button>;       {/*present on user page to logout*/}
  } else {
    pageContent = <GuestPage />;
    button = <button onClick={handleLoginClick}>Login</button>;           {/*present on guest page to login*/}
  }

  return (
    <div className="App">
      <h1> Flight Ticket Booking App</h1>
      {button}
      <hr />
      {pageContent}
    </div>
  );
}

export default App;
