import React, { Component } from 'react';

class Product extends Component {
  render() {
    const { name, price, onAddToCart, isSelected } = this.props;
    
    return (
      <div className={`product ${isSelected ? 'selected' : ''}`}>
        {isSelected && (
          <div className="product-x-overlay">
            <div className="product-x">✕</div>
          </div>
        )}
        <h3>{name}</h3>
        <p>{price}$</p>
        <div className="product-icon">^</div>
        <button 
          className="add-to-cart-btn" 
          onClick={onAddToCart}
          disabled={isSelected}
        >
          add2Cart
        </button>
      </div>
    );
  }
}

export default Product;
