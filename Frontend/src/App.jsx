
import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { useState } from 'react'
import NavBarEdunova from './components/NavBarEdunova';

function App() {

  const [x,setX] = useState(0);

  return (
    <>

    <NavBarEdunova/>
      
    </>
  )
}

export default App
