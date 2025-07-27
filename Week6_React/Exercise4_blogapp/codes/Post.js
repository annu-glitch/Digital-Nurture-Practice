import React from 'react';

function Post({title, body}){      //to display each individual blog post
    return(
        <div style={{border: '1px solid gray', padding: '10px', margin:'10px'}}>
            <h2>{title}</h2>
            <h2>{body}</h2>
        </div>
    );
}

export default Post;
