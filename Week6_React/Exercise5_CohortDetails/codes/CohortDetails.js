import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({cohortName, status, startDate, endDate}){
    //conditional inline style
    const headingStyle = {
        color: status === 'ongoing' ? 'green' : 'blue'  //blue for complete, green for ongoing
    };

    return (
        <div className={styles.box}>
            <h3 style={headingStyle}>{cohortName}</h3>     
            <dl>
                <dt>Status:</dt>
                <dd>{status}</dd>
                <dt>Start Date:</dt>
                <dd>{startDate}</dd>
                <dt>End Date:</dt>
                <dd>{endDate}</dd>
            </dl>
        </div>
    );
}

export default CohortDetails;
