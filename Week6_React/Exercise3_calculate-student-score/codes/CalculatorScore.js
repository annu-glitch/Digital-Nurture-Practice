import '../Stylesheets/mystyle.css'      //for styling

const percentToDecimal = (decimal)=>{      //utility function
    return(decimal.toFixed(2)+ '%');
}

const calcScore = (total, goal)=>{        //uses helper function defined above
    return percentToDecimal(total/goal);
}


export const CalculatorScore = ({Name,School,total,goal}) =>(    //get props
    <div className="formatStyle">
        <h1 style={{color:"brown"}}>Student Details:</h1>
        <div className="Name">
            <b><span>Name:</span></b>     {/*using span for inline display structure*/}
            <span>{Name}</span>
        </div>
        <div className="School">
            <b><span>School:</span></b>    
            <span>{School}</span>
        </div>
        <div className="Total">
            <b><span>Total:</span></b>
            <span>{total}</span>
            <span>Marks</span>
        </div>
        <div className="Score">
            <b>Score:</b>
            <span>
                {/*calling the JavaScript function definition from above using curly braces*/}
                {calcScore(            
                    total, goal
                )}
            </span>
        </div>
    </div>
)

