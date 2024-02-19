import React, { useState } from 'react';
import './Register.scss';
import perfumeImage from './../../assets/images/7.jpg';
import PerfumeService from "../../services/perfume.js";

function Register() {
    const [username, setUsername] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [confirmPassword, setConfirmPassword] = useState('');
    const [country, setCountry] = useState('');
    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const [message, setMessage] = useState('');
  
    const handleUsernameChange = (e) => setUsername(e.target.value);
    const handlePasswordChange = (e) => setPassword(e.target.value);
    const handleConfirmPasswordChange = (e) => setConfirmPassword(e.target.value);
    const handleEmailChange = (e) => setEmail(e.target.value);
    const handleCountryChange = (e) => setCountry(e.target.value);
    
      // const handleChange = (e) => {
      //   setFormData({ ...formData, [e.target.name]: e.target.value });
      // };
    
      const handleSubmit = async (e) => {
        e.preventDefault();
        try{
           await PerfumeService.registerUser(username,password,country,email,confirmPassword)
          
          setIsLoggedIn(true);
          setMessage(`The user ${username} is registered successfuly!`);
          
          
        }catch (error) {
          console.error('Registration error:', error);
          setMessage(error);
          
     }};
    return ( 
      <>
     <div>
      {message && <p>{message}</p>}
      {isLoggedIn ? <p>User is registered</p> : ""}
    </div>
      <div className="register-page">
      <div className="perfume-image-container">
        <img src={perfumeImage} alt="Perfume" className="perfume-image" />
      </div>
      <div className="register-container">
          <h1>Registration Page</h1>
          <form onSubmit={handleSubmit}>
          <div className="form-group"> 
      <input
        type="text"
        name="username"
        placeholder="Username"
        //value={formData.username}
        onChange={handleUsernameChange}
        required
      />
      </div>
      <div className="form-group">
      <input
        type="password"
        name="password"
        placeholder="Password"
        //value={formData.password}
        onChange={handlePasswordChange}
        required
      />
      </div>
      <div className="form-group">
      <input
        type="password"
        name="confirmPassword"
        placeholder="Confirm Password"
        //value={formData.confirmPassword}
        onChange={handleConfirmPasswordChange}
        required
      />
      </div>
      <div className="form-group">
      <input
        type="text"
        name="country"
        placeholder="Country"
        //value={formData.country}
        onChange={handleCountryChange}
        required
      />
      </div>
      <div className="form-group">
      <input
        type="email"
        name="email"
        placeholder="Email"
        //value={formData.email}
        onChange={handleEmailChange}
        required
      />
      </div>
      <button type="submit" onSubmit={handleSubmit} className="register-button">Register</button>
      </form>
    </div>
    </div>
    </>
     );
}
export default Register;
