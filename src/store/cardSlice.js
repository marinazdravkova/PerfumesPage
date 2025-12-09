import { createSlice } from '@reduxjs/toolkit';

const cardSlice = createSlice({
    name: 'card',
    initialState: [],
    reducers: {
        add: (state, action) => {
            const previousProduct = state.find(product => product.id === action.payload.id);
            if (!previousProduct) {
                return [...state, {...action.payload, quantity: 1}];
            }
            previousProduct.quantity++;
            return state;
        },
        reset: (state, action) => {
            return [];
        }
    }
});

export const { add, reset } = cardSlice.actions;

export default cardSlice.reducer;