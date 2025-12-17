import './App.css';
import React, { useState } from 'react';
import { Routes, Route, NavLink, Outlet } from 'react-router-dom';
import Square from './Square.jsx';

const Layout = () => (
  <div className="app-container">
    <div className="page-content">
      <Outlet />
    </div>
    <nav className="bottom-nav">
      <NavLink
        to="/"
        end
        className={({ isActive }) => `nav-link ${isActive ? 'active' : ''}`}
      >
        Home
      </NavLink>
      <NavLink
        to="/a"
        className={({ isActive }) => `nav-link ${isActive ? 'active' : ''}`}
      >
        Page A
      </NavLink>
    </nav>
  </div>
);

const HomePage = ({ color, text, setText, newText, generateRandomColor }) => (
  <div className="color-page">
    <h1>Color Changer</h1>

    <Square color={color} text={text} setText={setText} />

    <button onClick={generateRandomColor}>Change Color</button>

    <div className="delivery-text">
      Delivery: {newText}
    </div>
  </div>
);

const APage = () => (
  <div className="a-page">
    A
  </div>
);

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
    <Routes>
      <Route element={<Layout />}>
        <Route
          index
          element={(
            <HomePage
              color={color}
              text={text}
              setText={setText}
              newText={newText}
              generateRandomColor={generateRandomColor}
            />
          )}
        />
        <Route path="a" element={<APage />} />
      </Route>
    </Routes>
  );
};

export default App;