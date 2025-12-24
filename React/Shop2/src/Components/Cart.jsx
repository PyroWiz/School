import React, { useState } from "react";

const Cart = ({Sum}) => {
  return (
    <div style={{ border: '2px solid #ff0000ff', padding: '10px' }}>
      Cart<br/>
      Total: {Sum}
    </div>
  )
}

export default Cart