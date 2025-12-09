# Perfume Store Project

This repository contains a React application for browsing and buying perfumes. It includes user registration, login, a responsive layout, Redux state management, and a footer with a map for the store location.

**Quick highlights**

- React functional components + Hooks
- Redux Toolkit for global state (`src/store/userSlice.js`)
- API communication via `src/services/perfume.js` (adjust `baseUrl` there)
- Modern success modals for registration and login (auto-close + manual action)
- Responsive header (hamburger menu) and footer with Google Maps iframe

**Project structure (important paths)**

- `src/` — application source code
	- `pages/` — pages (Home, SignIn, Register, Perfumes, Orders, etc.)
	- `components/` — reusable components (modals, perfume cards, etc.)
	- `layout/` — `Header` and `Footer`
	- `services/` — `perfume.js` (API functions)
	- `store/` — Redux store and slices
	- `assets/images/` — project images and logo

## Prerequisites

- Node.js (recommended v14+) and npm (or Yarn)
- Backend API available and reachable (see `src/services/perfume.js`)

## Setup & run (Windows PowerShell)

1. Install dependencies

```powershell
npm install
```

2. Start development server

```powershell
npm start
```

3. Build for production

```powershell
npm run build
```

If this workspace contains multiple `package.json` files, run the commands from the folder that contains the `package.json` you intend to use.

## Configuration

- Backend base URL: update `const baseUrl` inside `src/services/perfume.js` to point to your backend (the project currently uses `https://localhost:7009`).
- Environment variables: consider using `.env` files and `process.env.REACT_APP_API_URL` to avoid editing source directly.

## Authentication notes

- On successful login the backend should return a token. The client expects the token in one of the common fields: `token`, `accessToken`, `access_token`, or nested under `data`/`result`.
- If the backend responds using a different schema, update token extraction in `src/services/perfume.js`.

## UI details

- Registration: `src/components/SuccessModal` — shows a success modal and a button to navigate to Login
- Login: `src/components/LoginSuccessModal` — shows login success modal and has a close button; errors display inline under the login button
- Header: `src/layout/Header` — shows username when logged in, contains responsive navigation
- Footer: `src/layout/Footer` — includes a responsive Google Maps iframe (change `mapSrc` in the component to update location)

## Debugging tips

- Login troubleshooting: Open DevTools → Network and inspect `POST /account/login`. The app also logs request payload and server response to the console to help identify token location and server errors.

## Suggested next improvements

- Use `.env` variables for the API base URL
- Use httpOnly cookies for authentication tokens (safer than `localStorage`)
- Centralized notification component for consistent error/success messages

---

If you want I can:

- Add `.env` support and update `perfume.js` to use `process.env.REACT_APP_API_URL`, or
- Add a small debug panel on the SignIn page to display full server responses while debugging.

Let me know which you prefer and I will implement it.
