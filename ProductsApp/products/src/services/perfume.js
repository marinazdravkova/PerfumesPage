const baseUrl = 'https://localhost:7009';

const getPerfumeById = async (id) => {
    const res = await fetch(`${baseUrl}/perfume/${id}`);
    const data = await res.json();
    return data;
}

const getAllPerfumes = async () => {
    const res = await fetch(`${baseUrl}/perfume/getAll`);
    const data = await res.json();
    return data;
    };
    
const registerUser = async (username,password,country,email,confirmPassword) => {
    await fetch(`${baseUrl}/account/register`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          username,
          password,
          country,
          email,
          confirmPassword
        })
      })
      .then(res => {
        if (!res.ok) {
          throw new Error(`HTTP error! status: ${res.status}`);
        }
        return res; 
      })
      .then(data => {
        console.log(data);
      })
      .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
      });
      
    };

    const loginUser = async (username, password) => {
      try {
        const response = await fetch(`${baseUrl}/account/login`, {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json'
          },
          body: JSON.stringify({
            username,
            password
          })
          
        });
        
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        const data = await response.json();
        const token = data.token;
    
        localStorage.setItem('token', token);
        //const token = await response.text();

    console.log('Received token:', token);

      } catch (error) {
        console.error('Error logging in:', error);
       
      }
    };

    const getAllBrands = async () => {
      const res = await fetch(`${baseUrl}/brand/getAll`);
      const data = await res.json();
      return data;
      
    };
    const getOrders = async () => {
      const res = await fetch(`${baseUrl}/card/getAll`);
      const data = await res.json();
      return data;
      
      };
      
const PerfumeService = {
    getPerfumeById,
    getAllPerfumes,
    registerUser,
    loginUser,
    getAllBrands,
    getOrders
}

export default PerfumeService;