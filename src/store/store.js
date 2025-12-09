import { configureStore } from '@reduxjs/toolkit';
import cardReducer from './cardSlice';
import perfumesReducer from './perfumesSlice';
import brandsReducer from './brandSlice';
import orderReducer from './orderSlice';
import userReducer from './userSlice';

const store = configureStore({
  reducer: {
    card: cardReducer,
    perfumes: perfumesReducer,
    brand: brandsReducer,
    order: orderReducer,
    user: userReducer
  }
});

export default store;