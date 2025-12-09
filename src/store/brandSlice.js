import { createSlice } from '@reduxjs/toolkit';

const brandsSlice = createSlice({
    name: 'brands',
    initialState: [],
    reducers: {
        getAll: (state, action) => {
            return action.payload;
        }
    }
});

export const { getAll } = brandsSlice.actions;

export default brandsSlice.reducer;