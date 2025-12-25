import './App.css'
import Shop from './Components/Shop'
import { ShopProvider } from './Components/ShopContext'
import AddItem from './Components/AddItem'
import { BrowserRouter, Routes, Route } from 'react-router-dom'

function App() {
  return (
    <BrowserRouter>
      <ShopProvider>
        <Routes>
          <Route path="/" element={<Shop />} />
          <Route path="/add-item" element={<AddItem />} />
        </Routes>
      </ShopProvider>
    </BrowserRouter>
  )
}

export default App