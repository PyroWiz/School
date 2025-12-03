import { useState } from "react"

export default function Person(props) {
  const [count, setCount] = useState(0);
  const [count2, setCount2] = useState(2);

  const [names, setNames] = useState({ name1: 'avi', name2: 'ben' })

  const chgname1 = () => {
    //setNames({ name1: 'charlie' ,name2: 'a'})
    setNames({ ...names, name1: 'charlie' })
  }


  return (
    <div>
      Person <br />
      <button onClick={() => setCount(0)}>0</button> <br />
      <button onClick={() => setCount(preC => preC + 1)}>+</button> <br />
      count = {count} <br />
      <button onClick={() => setCount2(preC2 => preC2 + 2)}>++</button> <br />
      count2={count2} <br />

      name1 = {names.name1} <br />
      name2 = {names.name2} <br />

      <button onClick={chgname1}>change name1</button>
    </div>
  )
}