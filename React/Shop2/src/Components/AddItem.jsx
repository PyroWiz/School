import { useState, useContext } from 'react'
import { ShopContext } from './ShopContext'
import { useNavigate } from 'react-router-dom'

const AddItem = () => {
  const { addProduct } = useContext(ShopContext)
  const navigate = useNavigate()
  
  const [formData, setFormData] = useState({
    id: '',
    name: '',
    price: '',
    quantity: '',
    imgSrc: ''
  })

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    })
  }

  const handleSubmit = (e) => {
    e.preventDefault()
    // Convert price and quantity to numbers
    const newProduct = {
      id: formData.id,
      name: formData.name,
      price: Number(formData.price),
      quantity: Number(formData.quantity),
      imgSrc: formData.imgSrc
    }
    addProduct(newProduct)
    navigate('/')  // Go back to shop page
  }

  return (
    <div style={{ padding: '20px', maxWidth: '500px', margin: '0 auto' }}>
      <h1>Add New Item</h1>
      <form onSubmit={handleSubmit}>
        <div style={{ marginBottom: '15px' }}>
          <label>ID: </label>
          <input
            type="text"
            name="id"
            value={formData.id}
            onChange={handleChange}
            required
            style={{ width: '100%', padding: '8px' }}
          />
        </div>
        
        <div style={{ marginBottom: '15px' }}>
          <label>Name: </label>
          <input
            type="text"
            name="name"
            value={formData.name}
            onChange={handleChange}
            required
            style={{ width: '100%', padding: '8px' }}
          />
        </div>
        
        <div style={{ marginBottom: '15px' }}>
          <label>Price: </label>
          <input
            type="number"
            name="price"
            value={formData.price}
            onChange={handleChange}
            required
            style={{ width: '100%', padding: '8px' }}
          />
        </div>
        
        <div style={{ marginBottom: '15px' }}>
          <label>Quantity: </label>
          <input
            type="number"
            name="quantity"
            value={formData.quantity}
            onChange={handleChange}
            required
            style={{ width: '100%', padding: '8px' }}
          />
        </div>
        
        <div style={{ marginBottom: '15px' }}>
          <label>Image URL: </label>
          <input
            type="text"
            name="imgSrc"
            value={formData.imgSrc}
            onChange={handleChange}
            style={{ width: '100%', padding: '8px' }}
          />
        </div>
        
        <button
          type="submit"
          style={{
            padding: '10px 20px',
            fontSize: '16px',
            backgroundColor: '#4CAF50',
            color: 'white',
            border: 'none',
            borderRadius: '5px',
            cursor: 'pointer'
          }}
        >
          Add Item
        </button>
      </form>
    </div>
  )
}

export default AddItem