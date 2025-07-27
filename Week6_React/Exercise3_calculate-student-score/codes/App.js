import {CalculatorScore} from '../src/Components/CalculatorScore';

function App(){         //functional component
  return(
    <div>
      {/*using variable props*/}
      <CalculatorScore Name = {"Annu"}             
      School={"KIIT DU"} 
      total={284}
      goal={3} />
    </div>
  )
}

export default App;           //default export
