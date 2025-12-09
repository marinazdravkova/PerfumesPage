import { createSlice } from '@reduxjs/toolkit';

const perfumesSlice = createSlice({
    name: 'perfumes',
    initialState: [],
    reducers: {
        getAll: (state, action) => {
            return action.payload;
        }
    }
});

export const { getAll } = perfumesSlice.actions;

export default perfumesSlice.reducer;
