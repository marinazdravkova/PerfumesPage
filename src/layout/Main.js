import { Outlet } from "react-router-dom";
import Header from "./Header/Header.js";
import Footer from "./Footer/Footer.js";

function Main() {
    return ( 
    <>
        <Header/>
        <Outlet/>
        <Footer/>
    </>
    );
}

export default Main;