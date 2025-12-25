import { useContext } from "react";
import { ShopContext } from "./ShopContext";

const Cart = () => {
  const { Sum, cartItems, removeItem, handlePurchase } = useContext(ShopContext)
  return (
    <div style={{ border: '2px solid #ff0000ff', padding: '10px' }}>
      <h3>Cart</h3>
      {cartItems.length === 0 ? (
        <p>Your cart is empty</p>
      ) : (
        <div>
          <ul style={{ listStyle: 'none', padding: 0 }}>
            {cartItems.map((item, index) => (
              <li
                key={index}
                style={{
                  marginBottom: '10px',
                  fontSize: '16px',
                  display: 'flex',
                  alignItems: 'center',
                  gap: '10px'
                }}
              >
                <span>{item.name} - ${item.price}</span>
                <button
                  onClick={() => removeItem(item.id, item.price)}
                  style={{
                    background: 'transparent',
                    color: 'red',
                    border: 'none',
                    cursor: 'pointer',
                    fontSize: '20px',
                    padding: '0 5px'
                  }}
                >
                  ×
                </button>
              </li>
            ))}
          </ul>
          <div style={{ marginTop: '20px', fontWeight: 'bold', fontSize: '18px' }}>
            Total: ${Sum}
          </div>
        </div>
      )}
      <button onClick={handlePurchase}>Buy</button>
    </div>
  )
}

export default Cart