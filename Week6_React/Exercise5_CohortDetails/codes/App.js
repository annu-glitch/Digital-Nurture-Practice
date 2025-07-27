import React from 'react';
import CohortDetails from './CohortDetails';

function App() {    //functional component
  return (
    <div>
      <CohortDetails
        cohortName="React Developer Bootcamp"           {/*props using variables*/}
        status="ongoing"
        startDate="2025-06-01"
        endDate="2025-08-01"
      />
      <CohortDetails
        cohortName="Java Fullstack Track"
        status="completed"
        startDate="2025-02-01"
        endDate="2025-04-01"
      />
    </div>
  );
}

export default App;
