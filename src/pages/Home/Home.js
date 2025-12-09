import { Link } from 'react-router-dom';
//import React, { Suspense, useState } from 'react';
import perfumes from '../../assets/images/perfumes.png';
//import Loading from '../components/Loading.js';
import './Home.scss';
//const UserData = React.lazy(() => import('./../components/UserData.js'));

function Home () {
    //const [loggedIn, setLoggedIn] = useState(false);
    const containerStyle = {
        backgroundImage: `url(${perfumes})`
    };
    
    return (
        <div id='home'>
            <div className='container' style={containerStyle}>
                <div className='content'>
                    <h1>Smell is a word, Perfume is literature...Choose Your!</h1>
                    <Link className='btn btn-secondary' to='/perfumes'>Buy your favourite</Link>
                </div>
            </div>
        </div>);
}

export default Home;
