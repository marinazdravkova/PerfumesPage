import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import PerfumeService from "../services/perfume";
 import Perfume from "../components/Perfume/Perfume.js";

function PerfumePage() {
    const { id } = useParams();
    const [perfumeApi, setPerfumeApi] = useState({});

    useEffect(() => {
        getPerfumeById();
    },[]);

    const getPerfumeById= async () => {
        const perfumeApi = await PerfumeService.getPerfumeById(id);
        setPerfumeApi(perfumeApi);
        console.log(perfumeApi);
        //setPerfume(data.products);
    }
    return (
        <>
         <h1>Selected Perfume</h1>
         <Perfume perfume={perfumeApi} />
         
         </>
         );
}

export default PerfumePage;