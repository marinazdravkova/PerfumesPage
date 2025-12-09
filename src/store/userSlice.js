import { createSlice } from '@reduxjs/toolkit';

const initialState = {
  isLoggedIn: false,
  username: null,
  token: null
};

const userSlice = createSlice({
  name: 'user',
  initialState,
  reducers: {
    loginSuccess: (state, action) => {
      state.isLoggedIn = true;
      state.username = action.payload.username;
      state.token = action.payload.token;
    },
    logout: (state) => {
      state.isLoggedIn = false;
      state.username = null;
      state.token = null;
      localStorage.removeItem('token');
      localStorage.removeItem('username');
    }
  }
});

export const { loginSuccess, logout } = userSlice.actions;
export default userSlice.reducer;
