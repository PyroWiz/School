import { useState, createContext } from 'react'

const ShopContext = createContext()
export const ShopProvider = ({ children }) => {
  const [Sum, SetSum] = useState(0.0)
  const [cartItems, setCartItems] = useState([])

  const [products, setProducts] = useState([
    { id: 'shirt', name: 'Shirt', price: 50, quantity: 10, imgSrc: '' },
    { id: 'pants', name: 'Pants', price: 30, quantity: 5, imgSrc: '' },
    { id: 'hat', name: 'Hat', price: 15, quantity: 8, imgSrc: '' }
  ])

  const addProduct = (newProduct) => {
    setProducts(prev => [...prev, newProduct])
  }

  const addItem = (itemId, name, price) => {
    SetSum(prevSum => prevSum + price)
    setCartItems(prev => [...prev, { id: itemId, name: name, price: price }])
  }
  const removeItem = (itemId, price) => {
    SetSum(prevSum => prevSum - price)
    setCartItems(prev => prev.filter(item => item.id !== itemId))
  }

  const handlePurchase = () => {
    if (cartItems.length === 0) {
      alert('Your cart is empty!')
      return
    }

    // Clear cart and reset total
    setCartItems([])
    SetSum(0.0)

    // Show popup
    alert('Purchase Complete!')
  }

  return (
    <ShopContext.Provider value={{
      Sum,
      SetSum,
      cartItems,
      setCartItems,
      products,
      addProduct,
      addItem,
      removeItem,
      handlePurchase
    }}>
      {children}
    </ShopContext.Provider>
  )
}

export { ShopContext }
