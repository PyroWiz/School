import React from 'react';

function Cart({ cartItems, onRemoveItem, onPay, onReset }) {
  const total = cartItems.reduce((sum, item) => sum + item.price, 0);
  
  return (
    <div className="cart-container">
      <div className="cart">
        <h2>my Cart:</h2>
        <div className="cart-items">
          {cartItems.map((item, index) => (
            <div key={index} className="cart-item">
              <span>{item.name} -- {item.price}$</span>
              <button className="remove-btn" onClick={() => onRemoveItem(index)}>
                ✕
              </button>
            </div>
          ))}
        </div>
        <div className="cart-total">
          <span>total -- {total}$</span>
        </div>
        <button className="pay-btn" onClick={onPay}>
          pay
        </button>
      </div>
      <button className="reset-btn" onClick={onReset}>
      </button>
    </div>
  );
}

export default Cart;
