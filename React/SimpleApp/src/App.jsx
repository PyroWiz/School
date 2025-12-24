import './App.css';
import React, { useState } from 'react';
import Square from './Square.jsx';

const App = () => {
  const [color, setColor] = useState('');
  const [text, setText] = useState('');
  const [newText, setNewText] = useState('');

  const generateRandomColor = () => {
    const randomColor = `#${Math.floor(Math.random() * 0xffffff).toString(16).padStart(6, '0')}`;
    setColor(randomColor);
    setNewText(text);
  };

  return (
    <div className="app-container">
      <div className="page-content">
        <div className="color-page">
          <h1>Color Changer</h1>

          <Square color={color} setText={setText} />

          <button onClick={generateRandomColor}>Change Color</button>

          <div className="delivery-text">
            Delivery: {newText}
          </div>
        </div>
      </div>
    </div>
  );
};

export default App;