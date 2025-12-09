import React, { useState } from 'react';
import { useSelector } from "react-redux";
import PerfumeCard from "../../components/Perfume/PerfumeCard";
import './Card.scss'; 
import { v4 as uuidv4 } from 'uuid';
import { reset } from '../../store/cardSlice';
import { useDispatch } from 'react-redux';

function Card() {
  const dispatch = useDispatch();
    const products = useSelector(state => state.card);
    let count = 1;
  console.log(products);

  const handleReset = () => {
    dispatch(reset());
  };

    const handleCheckout = async () => {
      const token = localStorage.getItem('token');
      const cartTotalPrice = calculateTotal();
      const cardData = {
        id: uuidv4(),
        totalPrice: cartTotalPrice,
        items: products.map(product => ({
          
          quantity: product.quantity,
          price: product.price,
          totalPrice: product.price * product.quantity,
          perfumeId: product.id,
  
        }))
      };
  
      try {
        const response = await fetch('https://localhost:7009/card/addCard', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
           
            'Authorization': `Bearer ${token}`,
          },
          body: JSON.stringify(cardData)
        });
  
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
  
        const responseData = await response.json();
        console.log(responseData);
        dispatch(reset);
      } catch (error) {
       return('Checkout error:', error.json);
      }
  };

    const handleRemoveItem = (itemId) => {
        products.filter(item => item.id !== itemId);
      };

      const calculateTotal = () => {
        return products.reduce((acc, item) => acc + item.price * item.quantity, 0);
      };
    return ( 
    <>
        
    <div className="card-page">
        {products.length > 0 ? (
      <table className="card-table">
        <thead>
          <tr>
            <th>#</th>
            <th></th>
            <th>PRODUCT</th>
            <th>PRICE</th>
            <th>QUANTITY</th>
            <th>TOTAL</th>
            <th></th> 
          </tr>
        </thead>
        <tbody>
          {products.map((item) => (
            <tr key={item.id}>
              <td data-label="#">{count++}</td>
              <td data-label=""><img src={item.imageURL} alt={item.name} className="card-item-image" /></td>
              <td data-label="Product">{item.name}</td>
              <td data-label="Price">${item.price.toFixed(2)}</td>
              <td data-label="Quantity">{item.quantity}</td>
              <td data-label="Total">${(item.price * item.quantity).toFixed(2)}</td>
              <td data-label="Action">
                <button onClick={() => handleRemoveItem(item.id)} className="remove-item-button">
                  X
                </button>
              </td>
            </tr>
          ))}
        </tbody>
        <tfoot>
        <tr>
          <td colSpan="3"></td> 
          <td>Total:</td>
          <td>{calculateTotal().toFixed(2)}</td>
          <td>
            <button  onClick={handleCheckout} className="checkout-button">Confirm order</button>
          </td>
          <td><button onClick={handleReset} className="checkout-button">Reset Cart</button></td>
        </tr>
      </tfoot>
      </table>
      ) : (
        <div className="empty-card-message">
          Your card is empty.
        </div>
      )}
    </div>

    </> );
}

export default Card;