import './SignIn.scss';
import perfumeImage from './../../assets/images/7.jpg';
import PerfumeService from "../../services/perfume.js";


import React, { useState } from 'react';


function LoginForm() {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const [message, setMessage] = useState('');
    //const [loader, setLoader] = useState(false);


    const handleUsernameChange = (e) => setUsername(e.target.value);
    const handlePasswordChange = (e) => setPassword(e.target.value);
  
    const handleSubmit = async (e) => {
        e.preventDefault();
       
        try {
            await PerfumeService.loginUser(username,password);
            
            setIsLoggedIn(true);
            setMessage('Login successful!');

            
        }catch (error) {
            setMessage('Error logging in. Please try again.');
          }
          
     };

    return (
        <>
        
    <div>
      {message && <p>{message}</p>}
      {isLoggedIn ? <p>User is logged in</p> : ""}
    </div>
    
        <div className="signin-page">
            <div className="perfume-image-container">
        <img src={perfumeImage} alt="Perfume" className="perfume-image" />
      </div>
          <div className="signin-container">
            <h1>Login</h1>
            <form onSubmit={handleSubmit}>
              <div className="form-group">
                <input
                  type="text"
                  id="username"
                  placeholder="Username"
                  onChange={handleUsernameChange}
                  required
                />
              </div>
              <div className="form-group">
                
                <input
                  type="password"
                  id="password"
                  placeholder="Password"
                  onChange={handlePasswordChange}
                  required
                />
               
              </div>
              <button type="submit" onSubmit={handleSubmit} className="signin-button">Continue</button>
            </form>
          </div>
        </div>
        </>
      );
}
    export default LoginForm;
