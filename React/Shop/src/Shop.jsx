// --- 3. Class Component: App ---
// Holds the State and Methods.
export default class Shop extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      products: [
        { id: 1, name: 'pants', price: 50 },
        { id: 2, name: 'hat', price: 20 },
        { id: 3, name: 'tshirt', price: 30 }
      ],
      cart: []
    };
  }

  addToCart = (productId) => {
    // 1. Find product
    const product = this.state.products.find(p => p.id === productId);
    // 2. Update state (append to cart array)
    this.setState({
      cart: [...this.state.cart, product]
    });
  };

  removeFromCart = (productId) => {
    // Filter out the item with the matching ID
    this.setState({
      cart: this.state.cart.filter(p => p.id !== productId)
    });
  };

  pay = () => {
    // Reset cart to empty array
    this.setState({ cart: [] });
  };

  render() {
    return (
      <div>
        <h1>My Shop (Barebones)</h1>

        {/* Section: Product List */}
        <div>
          <h2>Products</h2>
          {this.state.products.map((p) => {
            // Check if this product is currently in the cart
            const isAdded = this.state.cart.some(item => item.id === p.id);
            
            return (
              <Product 
                key={p.id}
                id={p.id}
                name={p.name} 
                price={p.price}
                isInCart={isAdded} // Pass true/false down to child
                onAdd={this.addToCart} // Pass function down to child
              />
            );
          })}
        </div>

        {/* Section: Cart */}
        <Cart 
          cartItems={this.state.cart} 
          onRemove={this.removeFromCart} 
          onPay={this.pay} 
        />
      </div>
    );
  }
}