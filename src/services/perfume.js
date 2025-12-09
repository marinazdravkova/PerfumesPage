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
        // Debug: log the outgoing payload
        console.debug('PerfumeService.loginUser request payload:', { username, password });

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
        
        // parse response body (may be error or success)
        const data = await response.json().catch(() => null);

        // Debug logging to help identify backend response shape
        // Remove or reduce logging in production
        console.debug('PerfumeService.loginUser response status:', response.status);
        console.debug('PerfumeService.loginUser response body:', data);

        // Try several common token locations used by different backends
        const token = (data && (data.token || data.accessToken || data.access_token || data.data?.token || data.result?.token)) || null;

        // If server returned non-ok status or we couldn't find a token, prefer server message if present
        if (!response.ok || !token) {
          const serverMessage = data && (data.message || data.error || data.errors || (typeof data === 'string' && data));
          throw new Error(serverMessage || 'Invalid username or password');
        }

        localStorage.setItem('token', token);
        console.debug('PerfumeService.loginUser detected token:', token);

        return token;

      } catch (error) {
        console.error('Error logging in:', error);
        throw error;
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