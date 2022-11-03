import React,{useState} from 'react';
import LoginForm from './components/LoginForm';
function App(){
  const adminUser={
    email:"admin@gmail.com",
    password:"12345"
    
  }
  const[user,setUser]=useState({name:"",email:""});
  const[error,setError]=useState("");
  const Login=details=>{
    console.log(details);
    if(details.email==adminUser.email&&details.password==adminUser.password){
    console.log("Logged in");
    setUser({
      name:details.name,
      email:details.email,
      password:details.password
    });
  } else {
    
      console.log("Incorrect email or password!");
      setError("Incorrect email or password!");
    }
  }
  const Logout=()=>{
    setUser({name:"",email:""});
  }
  return(
    <div className="App">
      {(user.email !="")?(
        <div className="Welcome to HouseBooking System">
          <h2>HouseBooking System Welcome's You,<span>{user.name}</span></h2>
          <button onClick={Logout}>Logout</button>
          </div>
      ):(
        <LoginForm Login={Login}error={error}/>
      )}
      </div>
      );
}
export default App;