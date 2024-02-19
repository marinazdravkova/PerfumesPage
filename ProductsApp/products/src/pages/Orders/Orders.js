import React, { useState,useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import PerfumeService from "../../services/perfume.js";
import { getAll } from '../../store/brandSlice.js';
import '../Orders/Orders.scss';


function OrderPage ()  {
    const order = useSelector(state => state.order);
    const dispatch = useDispatch();
    const [orders, setOrders] = useState([]);
    const [expandedRows, setExpandedRows] = useState({});

  const handleRowClick = (orderId) => {
    setExpandedRows(prevExpandedRows => ({
      ...prevExpandedRows,
      [orderId]: !prevExpandedRows[orderId]
    }));
  };
  const [currentPage, setCurrentPage] = useState(1);
  const [ordersPerPage] = useState(5);


  const indexOfLastOrder = currentPage * ordersPerPage;
  const indexOfFirstOrder = indexOfLastOrder - ordersPerPage;
  const currentOrders = orders.slice(indexOfFirstOrder, indexOfLastOrder);

 
  const paginate = (pageNumber) => setCurrentPage(pageNumber);

  
  const pageCount = Math.ceil(orders.length / ordersPerPage);

  
  const pageNumbers = [];
  for (let i = 1; i <= pageCount; i++) {
    pageNumbers.push(i);
  }

  useEffect(() => {
    getOrders();
  }, []); 

  const getOrders = async () => {
    try {
        const orders = await PerfumeService.getOrders();
        setOrders(Array.isArray(orders) ? orders : []);
      } catch (error) {
        console.error("Failed to fetch orders:", error);
        setOrders([]);
      }
   
    
  }

  return (
    <div className="order-page">
      <h1>Your Orders</h1>
      <div className="table-container">
      <table className="order-table">
        <thead>
          <tr>
            <th>#</th>
            <th>Perfume Name</th>
            <th>Brand</th>
            <th>Total Price</th>
          </tr>
        </thead>
        <tbody>
          {currentOrders.map((order, index) => (
            <>
            <tr key={index}  onClick={() => handleRowClick(order.id)}>
                <td>▼</td>
              <td>{order.items[0].perfume.name}</td>
              <td>{order.items[0].perfume.brand.name}</td>

              <td>{order.totalPrice} MKD</td>
              
            </tr>
             {expandedRows[order.id] && (
                <tr className="order-details">
                  <td colSpan="6">
                    <div>Items:</div>
                    {order.items.map(item => (
                      <div key={item.id}>
                        <img src={item.perfume.imageURL} alt={item.perfume.name}  style={{ width: '50px', height: '50px' }}/> <span>{item.perfume.name}- {item.quantity}  Price: {item.price}MKD</span>
                      </div>
                    ))}
                  </td>
                </tr>)}
                </>
          ))}
        </tbody>
      </table>
      <div className="pagination">
        {pageNumbers.map(number => (
          <button key={number} onClick={() => paginate(number)}>
            {number}
          </button>
        ))}
      </div>
      </div>
    </div>
  );
};

export default OrderPage;