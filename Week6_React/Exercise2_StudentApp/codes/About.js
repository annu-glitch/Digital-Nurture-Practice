import React, {Component} from 'react'; //imports react library, and named import of Component base-class to be extended

export class About extends Component{  //named export; extends base class Component
    render(){ //method that returns what to display in UI
        return( //returns JSX
            <div>    
                <h3>Welcome to the About Page of Student Management Portal</h3>
            </div>
        );
    }
}
