import { Routes, Route } from 'react-router-dom';
import './App.scss';
import {Home, Perfumes, PerfumePage, Card, NotFound,Orders,Brand} from './pages';
import Perfume from '../src/components/Perfume/Perfume.js';
import Register from '../src/pages/Register/Register.js';
import SignIn from '../src/pages/SignIn/SignIn.js';
import Main from './layout/Main';
import { Provider } from 'react-redux';
import store from './store/store';

function App() {
  return (
    <div className="App">
      <Provider store={store}>
        <Routes>
          <Route element={<Main/>}>
          <Route path='/' element={<Home/>}></Route>
          <Route path='/perfumes' element={<Perfumes/>}></Route>
          <Route path='/perfume/:id' element={<PerfumePage/>}></Route>
          <Route path='/card' element={<Card/>}></Route>
          <Route path='/register' element={<Register/>}></Route>
          <Route path='/signin' element={<SignIn/>}></Route>
          <Route path='/brands' element={<Brand/>}></Route>
          <Route path='/orders' element={<Orders/>}></Route>
          <Route path='*' element={<NotFound/>}></Route>
          </Route>
        </Routes>
        </Provider>
    </div>
  );
}

export default App;
