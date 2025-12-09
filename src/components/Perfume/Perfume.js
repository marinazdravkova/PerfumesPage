import {Link} from 'react-router-dom';
import { useState} from "react";
import { useDispatch } from 'react-redux';
import { add } from '../../store/cardSlice';
import './Perfume.scss'

function Perfume({perfume, viewPerfume}) {
    const [showDescription, setShowDescription] = useState(false);
    const dispatch = useDispatch();

    function addToCard() {
        dispatch(add(perfume));
    }

    return (  
        <div className="perfume">
        <img src={perfume.imageURL} alt={perfume.name} />
        <h3>{perfume.name}</h3>
        {viewPerfume ? (
           <>
                {showDescription && <div className="text-box"><p>{perfume.description}</p></div>}</>
        ) :  <label><b>Опис:</b>&nbsp;<div className="text-box"><p>{perfume.description}</p></div></label>}
        <div>
                    <label><b>Бренд:</b>&nbsp;{perfume.brand?.name}&nbsp; | <b>Потекло:</b>&nbsp;{perfume.brand?.country ? perfume.brand.country : "/"}</label><br />
                    <label><b>Вид:</b>&nbsp;{perfume.perfumeType} | <b>Сезона:</b>&nbsp;{perfume.season ? perfume.season : "/"}&nbsp; | </label>&nbsp;
                    <label><b>Цена:</b>&nbsp;{perfume.price} МКД</label>
        </div>
        <br/>
        {/* {viewPerfume  && <label><b>Опис:</b>&nbsp;<p>{perfume.description}</p></label>} */}
        
        {viewPerfume && <Link to={`/perfume/${perfume.id}`} className='btn btn-secondary'>View Details</Link>}
        <button onClick={addToCard} className='btn btn-primary'>Add to card</button>
    </div>
        
    );
}

export default Perfume;