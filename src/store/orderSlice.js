import { createSlice } from '@reduxjs/toolkit';

const ordersSlice = createSlice({
    name: 'orders',
    initialState: [],
    reducers: {
        getAll: (state, action) => {
            return action.payload;
        }
    }
});

export const { getAll } = ordersSlice.actions;

export default ordersSlice.reducer;