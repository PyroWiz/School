import React, { useState } from "react";
import RedXOverlay from "./Utils";

const Products = ({ SetSum, Sum, addItem, addedItems }) => {
  const products = [
    { id: 'shirt', name: 'Shirt', price: 50 },
    { id: 'pants', name: 'Pants', price: 30 },
    { id: 'hat', name: 'Hat', price: 15 }
  ];

  const handleAdd = (product) => {
    if (!addedItems.has(product.id)) {
      addItem(product.id, product.price);
    }
  };

  return (
    <div style={{ border: '2px solid #ff0000ff', padding: '10px', fontSize: '20px' }}>
      Products:<br />
      {products.map(product => (
        <div key={product.id}>
          <RedXOverlay isActive={addedItems.has(product.id)}>
            {product.name} - {product.price}$
            <button
              style={{ fontSize: '15px' }}
              onClick={() => handleAdd(product)}
              disabled={addedItems.has(product.id)}
            >
              Add
            </button>
          </RedXOverlay>
          <br />
        </div>
      ))}
    </div>
  )
}

export default Products