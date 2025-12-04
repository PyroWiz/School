import React from 'react';

// --- 1. Functional Component: Product ---
// Displays one item. Logic: If 'isInCart' is true, disable the button.
const Product = (props) => {
  const { id, name, price, isInCart, onAdd } = props;

  return (
    <div style={{ border: '1px solid black', margin: '10px', padding: '10px' }}>
      <h3>{name}</h3>
      <p>Price: {price}$</p>

      {/* If in cart, we disable the button and show text instead of the Red X */}
      <button onClick={() => onAdd(id)} disabled={isInCart}>
        {isInCart ? "ALREADY IN CART" : "add2Cart"}
      </button>
    </div>
  );
};