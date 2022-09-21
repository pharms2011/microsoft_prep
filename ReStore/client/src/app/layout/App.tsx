import { createTheme, CssBaseline, ThemeProvider } from '@mui/material';
import { Container } from '@mui/system';
import { useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import AboutPage from '../../features/about/AboutPage';
import Catalog from '../../features/catalog/Catalog';
import ProductDetails from '../../features/catalog/ProductsDetail';
import ContactPage from '../../features/contact/ContactPage';
import HomePage from '../../features/home/HomePage';
import Header from './Header';

function App() {
  const [darkMode, setDarkMode] = useState(false);
  const palletType = darkMode ? 'dark' : 'light';
  const theme = createTheme({
    palette: {
      mode: palletType,
      background: {
        default: palletType === 'light' ? '#eaeaea' : '#121212'
      }
    }
  })

  function toggleDarkMode() {
    setDarkMode(!darkMode);
  }

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Header toggleDarkMode={toggleDarkMode} isDark={darkMode} />
      <Container>
        <Routes>
          <Route path='/' element={<HomePage />} />
          <Route path='/catalog/:id' element={<ProductDetails />} />
          <Route path='/catalog' element={<Catalog />} />
          <Route path='/about' element={<AboutPage />} />
          <Route path='/contact' element={<ContactPage />} />
        </Routes>
      </Container>

    </ThemeProvider>
  );
}

export default App;
