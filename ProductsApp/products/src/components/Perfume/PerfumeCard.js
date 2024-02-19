import './Perfume.scss'

function CardPerfume({perfume}) {
    return ( 
        <div className="perfume">
            <img src={perfume.imageURL} alt={perfume.name}/>
            <h3>{perfume.name}</h3>
            <p>Quantity: {perfume.quantity}</p>
        </div>
    );
}

export default CardPerfume;