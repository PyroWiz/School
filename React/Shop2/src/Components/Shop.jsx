import React, { useState } from "react";
import Products from "./Products";
import Cart from "./Cart";

const Shop = () => {
  const [Sum, SetSum] = useState(0.0)
  const [addedItems, setAddedItems] = useState(new Set())
  const addItem = (itemId, price) => {
    SetSum(prevSum => prevSum + price)
    setAddedItems(prev => new Set([...prev, itemId]))
  }
  return (
    <div>
      <h1>Shop</h1>
      <div style={{ border: '2px solid #ff0000ff', padding: '10px', display: 'flex', gap: '20px' }}>
        <Products SetSum={SetSum} Sum={Sum} addItem={addItem} addedItems={addedItems} />
        <Cart Sum={Sum} />
      </div>
    </div>
  )
}

export default Shop
