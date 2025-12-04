// --- 2. Functional Component: Cart ---
// Displays the list of added items and the total.
const Cart = (props) => {
  const { cartItems, onRemove, onPay } = props;

  // Calculate total
  const total = cartItems.reduce((acc, item) => acc + item.price, 0);

  return (
    <div style={{ border: '1px solid black', margin: '10px', padding: '10px' }}>
      <h2>my Cart:</h2>

      <ul>
        {cartItems.map((item) => (
          <li key={item.id}>
            {item.name} -- {item.price}$
            {' '}
            {/* Remove Button */}
            <button onClick={() => onRemove(item.id)}>
              Remove (X)
            </button>
          </li>
        ))}
      </ul>

      <hr />
      <h3>Total: {total}$</h3>

      <button onClick={onPay}>
        pay (reset shop)
      </button>
    </div>
  );
};
