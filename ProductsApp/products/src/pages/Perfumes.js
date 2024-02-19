import { useEffect,useState} from "react";
import { useDispatch, useSelector } from 'react-redux';
import Perfume from '../components/Perfume/Perfume.js';
//import PerfumePage from "./PerfumePage.js";
import PerfumeService from "../services/perfume.js";
import { getAll } from '../store/perfumesSlice.js';
import '../components/Perfume/Perfume.scss';

function Perfumes() {
    const perfumes = useSelector(state => state.perfumes);
    const dispatch = useDispatch();
   
    useEffect (() => {
        if(!perfumes.length)
           getAllPerfumes();
        
    },[]);
    
    const getAllPerfumes = async () => {
       const perfumes = await PerfumeService.getAllPerfumes();
       dispatch(getAll(perfumes));
     }

    return ( 
    <>
    <h1>All Perfumes: </h1>
    
    {perfumes.map((perfume) => 
        <Perfume key={perfume.id} perfume={perfume} viewPerfume/>)}
    </>);
}

export default Perfumes;