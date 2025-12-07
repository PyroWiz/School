import React, { Component } from 'react';
import Product from './Product';
import Cart from './Cart';

class Shop extends Component {
  constructor(props) {
    super(props);
    this.state = {
      cart: [],
      selectedProducts: []
    };
  }

  products = [
    { name: 'pants', price: 50 },
    { name: 'hat', price: 20 },
    { name: 'tshirt', price: 30 }
  ];

  addToCart = (product) => {
    if (!this.state.selectedProducts.includes(product.name)) {
      this.setState({
        cart: [...this.state.cart, product],
        selectedProducts: [...this.state.selectedProducts, product.name]
      });
    }
  };

  removeFromCart = (index) => {
    const removedItem = this.state.cart[index];
    const newCart = this.state.cart.filter((item, i) => i !== index);
    this.setState({
      cart: newCart,
      selectedProducts: this.state.selectedProducts.filter(name => name !== removedItem.name)
    });
  };

  handlePay = () => {
    const total = this.state.cart.reduce((sum, item) => sum + item.price, 0);
    alert(`Total payment: ${total}$`);
    this.setState({
      cart: [],
      selectedProducts: []
    });
  };

  resetShop = () => {
    this.setState({
      cart: [],
      selectedProducts: []
    });
  };

  render() {
    return (
      <div className="app">
        <div className="shop-section">
          <h1 className="shop-title">my shop</h1>
          <div className="products">
            {this.products.map((product, index) => (
              <Product
                key={index}
                name={product.name}
                price={product.price}
                isSelected={this.state.selectedProducts.includes(product.name)}
                onAddToCart={() => this.addToCart(product)}
              />
            ))}
          </div>
        </div>
        
        <Cart
          cartItems={this.state.cart}
          onRemoveItem={this.removeFromCart}
          onPay={this.handlePay}
          onReset={this.resetShop}
        />
      </div>
    );
  }
}

export default Shop;
