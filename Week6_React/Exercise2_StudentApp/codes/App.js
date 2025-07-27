import {Home} from './Components/Home';    //named import of Home
import {About} from './Components/About';
import {Contact} from './Components/Contact';

function App(){           //functional component App
  return(          //no render method because App is a JS function: it itself returns JSX
    <div className="container">  {/*using div for multiple HTML-like elements*/}
      <Home />   {/*calling the custom components to render whatever UI it returns*/}
      <About />
      <Contact />
    </div>
  );
}

export default App;          //default export
