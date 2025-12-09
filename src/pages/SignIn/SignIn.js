import './SignIn.scss';
import perfumeImage from './../../assets/images/7.jpg';
import PerfumeService from "../../services/perfume.js";
import LoginSuccessModal from '../../components/LoginSuccessModal/LoginSuccessModal';
import { useDispatch } from 'react-redux';
import { loginSuccess } from '../../store/userSlice';
import React, { useState } from 'react';


function LoginForm() {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [showSuccessModal, setShowSuccessModal] = useState(false);
    const [loggedInUsername, setLoggedInUsername] = useState('');
    const [errorMessage, setErrorMessage] = useState('');
    const dispatch = useDispatch();

    const handleUsernameChange = (e) => setUsername(e.target.value);
    const handlePasswordChange = (e) => setPassword(e.target.value);
  
    const handleSubmit = async (e) => {
        e.preventDefault();
       
        try {
          const token = await PerfumeService.loginUser(username, password);

          // Defensive check: ensure token is present
          if (!token) {
            setErrorMessage('Invalid username or password.');
            return;
          }

          // Store username in localStorage and Redux
          localStorage.setItem('username', username);
          dispatch(loginSuccess({ username, token }));

          setLoggedInUsername(username);
          setShowSuccessModal(true);
          setErrorMessage('');

          // Reset form
          setUsername('');
          setPassword('');

        } catch (error) {
          // Show server-provided message when possible
          console.error('Login error (SignIn):', error);
          setErrorMessage(error?.message || 'Invalid username or password. Please try again.');
        }
          
    
     };

    return (
        <>
        
    <div>
      {errorMessage && <div className="error-message"><p>{errorMessage}</p></div>}
      {showSuccessModal && <LoginSuccessModal username={loggedInUsername} onClose={() => setShowSuccessModal(false)} />}
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
                                    value={username}
                  onChange={handleUsernameChange}
                  required
                />
              </div>
              <div className="form-group">
                
                <input
                  type="password"
                  id="password"
                  placeholder="Password"
                                    value={password}
                  onChange={handlePasswordChange}
                  required
                />
               
              </div>
              <button type="submit" onSubmit={handleSubmit} className="signin-button">Continue</button>
                          {errorMessage && <div className="form-error-message"><p>{errorMessage}</p></div>}
            </form>
          </div>
        </div>
        </>
      );
}
    export default LoginForm;
