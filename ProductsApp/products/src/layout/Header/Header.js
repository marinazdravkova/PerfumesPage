import {NavLink} from 'react-router-dom';
import './Header.scss';
import logo from './../../assets/images/logoPerfume.png'

function Header() {
    return (
        <header className="header">
            <div className='links'>
            <NavLink to='/'><img id='logo' src={logo} alt='logo'/></NavLink>
            </div>
            <div className='links navigate'>
            <NavLink to='/perfumes'>Perfumes</NavLink>
            <NavLink to='/brands'>Brands</NavLink>
            <NavLink to='/register'>Register</NavLink>
            <NavLink to='/signin'>Login</NavLink>
            <NavLink to='/card'>Card</NavLink>
            <NavLink to='/orders'>Orders</NavLink>
            </div>
        </header>
     );
}

export default Header;