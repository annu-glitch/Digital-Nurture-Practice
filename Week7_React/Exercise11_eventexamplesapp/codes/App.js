import React, { useState } from 'react';
import './App.css';

function App() {
  const [count, setCount] = useState(0);         //useState hook: sets initial count to 0
  const [amount, setAmount] = useState('');           
  const [currency, setCurrency] = useState('');

  // 1.a & 1.b Increment and greet
  const handleIncrement = () => {         //increments count to 1
    setCount(count + 1);        //updates the current value of count
    alert('Hello Member1');
  };

  const handleDecrement = () => {
    setCount(count - 1);
  };

  // 2. Say Welcome
  const sayMessage = (msg) => {
    alert(msg);
  };

  // 3. Synthetic Event
  const handleClick = () => {
    alert('I was clicked');
  };

  // 4. Currency Convertor
  const handleSubmit = (e) => {
    e.preventDefault();
    if (!isNaN(amount) && amount !== '') {
      const converted = (amount / 90).toFixed(2); // Example rate: 1 EUR = 90 INR
      setCurrency(`€${converted}`);
    } else {
      setCurrency('Invalid amount');
    }
  };

  return (
    <div className="App">
      <p>{count}</p>
      <button onClick={handleIncrement}>Increment</button>        {/*triggers handleIncrement function on clicking*/}
      <br />
      <button onClick={handleDecrement}>Decrement</button>
      <br />
      <button onClick={() => sayMessage('welcome')}>Say welcome</button>
      <br />
      <button onClick={handleClick}>Click on me</button>

      <h2 className="green-heading">Currency Convertor!!!</h2>
      <form onSubmit={handleSubmit}>
        <label>Amount: </label>
        <input
          type="text"
          value={amount}
          onChange={(e) => setAmount(e.target.value)}
        />
        <br />
        <label>Currency: </label>
        <textarea value={currency} readOnly />
        <br />
        <button type="submit">Submit</button>
      </form>
    </div>
  );
}

export default App;
