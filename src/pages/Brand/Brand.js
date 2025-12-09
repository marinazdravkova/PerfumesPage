import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import PerfumeService from "../../services/perfume.js";
import { getAll } from '../../store/brandSlice.js';
import '../Brand/Brand.scss';

function BrandList() {
  const brands = useSelector(state => state.brand);
  const dispatch = useDispatch();

  useEffect(() => {
    if(!brands.length)
    getAllBrands();
  }, []);

  const getAllBrands = async () => {
    const brands = await PerfumeService.getAllBrands();
    dispatch(getAll(brands));
  }


  return (
    <div className="brand-list-container"> 
      <h2 className="brand-list-header">Perfume Brands</h2> 
      <ul className="brand-list"> 
        {brands.map((brand) => (
          <li key={brand.id}>{brand.name}</li>
        ))}
      </ul>
    </div>
  );
}

export default BrandList;