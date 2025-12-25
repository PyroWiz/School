import { useContext } from "react";
import Products from "./Products";
import Cart from "./Cart";
import { ShopContext } from "./ShopContext";
import { Link } from 'react-router-dom'



const Shop = () => {
  return (
    <div>
      <h1>Shop</h1>
      <div style={{ border: '2px solid #ff0000ff', padding: '10px', display: 'flex', gap: '20px' }}>
        <Products />
        <Cart />
        <Link to="/add-item">Add New Item</Link>
      </div>
    </div>
  )
}

export default Shop
