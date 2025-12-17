import React from 'react';

const Square = ({ color, text, setText }) => {
  const squareStyle = {
    width: '200px',
    height: '200px',
    backgroundColor: color,
    border: '2px solid #333',
    margin: '20px auto',
    transition: 'background-color 0.3s ease',
  };

  return (<div style={squareStyle}>
    <br />
    <input
      type="text"
      value={text}
      onChange={(e) => setText(e.target.value)} />
  </div>
  )
};

export default Square;



