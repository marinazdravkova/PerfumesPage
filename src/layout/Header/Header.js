import {NavLink} from 'react-router-dom';
import { useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import './Header.scss';
import logo from './../../assets/images/logoPerfume.png'
import { logout } from '../../store/userSlice';

function Header() {
    const [isMenuOpen, setIsMenuOpen] = useState(false);
    const dispatch = useDispatch();
    const { isLoggedIn, username } = useSelector(state => state.user);

    const toggleMenu = () => {
        setIsMenuOpen(!isMenuOpen);
    };

    const handleLogout = () => {
        dispatch(logout());
        setIsMenuOpen(false);
    };

    return (
        <header className="header">
            <div className='links'>
            <NavLink to='/'><img id='logo' src={logo} alt='logo'/></NavLink>
            </div>
            <button className="menu-toggle" onClick={toggleMenu} aria-label="Toggle menu">
                <span></span>
                <span></span>
                <span></span>
            </button>
            <div className={`links navigate ${isMenuOpen ? 'open' : ''}`}>
            <NavLink to='/perfumes' onClick={() => setIsMenuOpen(false)}>Perfumes</NavLink>
            <NavLink to='/brands' onClick={() => setIsMenuOpen(false)}>Brands</NavLink>
            <NavLink to='/register' onClick={() => setIsMenuOpen(false)}>Register</NavLink>
            {!isLoggedIn ? (
                <NavLink to='/signin' onClick={() => setIsMenuOpen(false)}>Login</NavLink>
            ) : null}
            <NavLink to='/card' onClick={() => setIsMenuOpen(false)}>Card</NavLink>
            <NavLink to='/orders' onClick={() => setIsMenuOpen(false)}>Orders</NavLink>
            {isLoggedIn && (
                <div className="user-section">
                    <span className="username">Logged as <strong>{username}</strong></span>
                    <button className="logout-button" onClick={handleLogout}>Logout</button>
                </div>
            )}
            </div>
        </header>
     );
}

export default Header;