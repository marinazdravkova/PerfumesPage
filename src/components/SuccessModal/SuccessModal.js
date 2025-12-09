import React, { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import './SuccessModal.scss';
import logoPerfume from '../../assets/images/logoPerfume.png';

function SuccessModal({ username, onClose }) {
  const navigate = useNavigate();

  useEffect(() => {
    // Auto-close modal after 10 seconds
    const timer = setTimeout(() => {
      onClose();
    }, 10000);

    return () => clearTimeout(timer);
  }, [onClose]);

  const handleLoginClick = () => {
    onClose();
    navigate('/signin');
  };

  return (
    <div className="success-modal-overlay">
      <div className="success-modal">
        <div className="success-modal-content">
          <img src={logoPerfume} alt="Perfume Logo" className="success-modal-logo" />
          <div className="success-modal-message">
            <h2>Success!</h2>
            <p>The user <strong>{username}</strong> is registered in the Perfume team members</p>
          </div>
        </div>
        
        <div className="success-modal-actions">
          <button className="login-button" onClick={handleLoginClick}>
            Login Now
          </button>
        </div>

        <div className="success-modal-timer">
          <p>This message will close automatically in 10 seconds</p>
        </div>
      </div>
    </div>
  );
}

export default SuccessModal;
