import React, { useEffect } from 'react';
import './LoginSuccessModal.scss';
import logoPerfume from '../../assets/images/logoPerfume.png';

function LoginSuccessModal({ username, onClose }) {
  useEffect(() => {
    // Auto-close modal after 10 seconds
    const timer = setTimeout(() => {
      onClose();
    }, 10000);

    return () => clearTimeout(timer);
  }, [onClose]);

  return (
    <div className="login-success-modal-overlay">
      <div className="login-success-modal">
        <div className="login-success-modal-content">
          <img src={logoPerfume} alt="Perfume Logo" className="login-success-modal-logo" />
          <div className="login-success-modal-message">
            <h2>Welcome!</h2>
            <p>Successfully logged in as <strong>{username}</strong></p>
          </div>
        </div>

        <div className="login-success-modal-close">
          <button className="close-button" onClick={onClose} aria-label="Close modal">
            ✕
          </button>
        </div>

        <div className="login-success-modal-timer">
          <p>This message will close automatically in 10 seconds</p>
        </div>
      </div>
    </div>
  );
}

export default LoginSuccessModal;
