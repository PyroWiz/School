import { useContext } from "react";
import RedXOverlay from "./Utils";
import { ShopContext } from "./ShopContext";

const Products = () => {
  const { cartItems, addItem, products } = useContext(ShopContext)


  const handleAdd = (product) => {
    const isInCart = cartItems.some(item => item.id === product.id)
    if (!isInCart) {
      addItem(product.id, product.name, product.price);
    }
  };

  return (
    <div style={{ border: '2px solid #ff0000ff', padding: '10px', fontSize: '20px' }}>
      Products:<br />
      {products.map(product => {
        const isInCart = cartItems.some(item => item.id === product.id)
        return (
          <div key={product.id}>
            <RedXOverlay isActive={isInCart}>
              {product.name} - {product.price}$
              <button
                style={{ fontSize: '15px' }}
                onClick={() => handleAdd(product)}
                disabled={isInCart}
              >
                Add
              </button>
            </RedXOverlay>
            <br />
          </div>
        )
      })}
    </div>
  )
}

export default Products