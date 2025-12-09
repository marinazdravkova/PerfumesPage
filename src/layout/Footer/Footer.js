import React from 'react';
import './Footer.scss';
import perfume1 from './../../assets/images/2.jpg';
import perfume2 from './../../assets/images/3.jpg';
import perfume3 from './../../assets/images/4.jpg';
import perfume4 from './../../assets/images/5.jpg';
import perfume5 from './../../assets/images/7.jpg';
import perfume6 from './../../assets/images/9.jpg';
import perfume7 from './../../assets/images/10.jpg';

function Footer() {
    const perfumes = [
        { src: perfume1, alt: 'Perfume 1' },
        { src: perfume2, alt: 'Perfume 2' },
        { src: perfume3, alt: 'Perfume 3' },
        { src: perfume4, alt: 'Perfume 4' },
        { src: perfume5, alt: 'Perfume 5' },
        { src: perfume6, alt: 'Perfume 6' },
        { src: perfume7, alt: 'Perfume 7' },
        
      ];
    const mapSrc = "https://www.google.com/maps/place/%D0%9E%D0%BF%D1%88%D1%82%D0%B8%D0%BD%D0%B0+%D0%A8%D1%82%D0%B8%D0%BF/@41.7161263,21.5569521,10z/data=!3m1!4b1!4m6!3m5!1s0x1355dc183806ea13:0x9110076d06e8cce9!8m2!3d41.7079297!4d22.1907122!16zL20vMGY0OXB4?entry=ttu";
  return (
    <footer className="site-footer">
      <div className="footer-container">
        <div className="footer-block">
          <h4>INFORMATION</h4>
          <ul>
            <li>About Us</li>
            <li>New Products</li>
            <li>Best Sales</li>
            <li>Gift Certificate</li>
            <li>My Account</li>
           
          </ul>
        </div>
        <div className="footer-block">
          <h4>GALLERY</h4>
          <div className="perfumes-container">
            {perfumes.map((perfume,index) => (
              <img key={index} src={perfume.src} alt={perfume.alt} className="perfume-image" />
           ))}
          </div>
        </div>
        <div className="footer-block">
          <h4>LOCATION</h4>
          <div className="map-container">
            <iframe
              title="Location"
              src={mapSrc}
              width="100%"
              height="250"
              style={{ border: 0, borderRadius: '4px' }}
              allowFullScreen=""
              loading="lazy"
              referrerPolicy="no-referrer-when-downgrade"
            ></iframe>
          </div>
        </div>
        <div className="footer-block footer-contact">
          <p>
            Get all types of perfume from us within 2 day delivery. We can even order the perfumes which are not in our database.
          </p>
          <p><strong>Email:</strong> perfume@mail.com</p>
          <p><strong>Phone:</strong> +38972227548</p>
        </div>
      </div>
      <div className="footer-bottom">
        <p>© 2024 Perfume Store Project | All Right Reserved.</p>
        <div className="payment-icons">
          {/* Payment icons would be placed here */}
        </div>
      </div>
    </footer>
  );
}


export default Footer;