import GlobalStyles from './styles/GlobalStyles';
import { ThemeProvider } from 'styled-components';
import Layout from './components/Layout';

import light from './styles/themes/light';

function App() {
  return (
    <ThemeProvider theme={light}>
      <GlobalStyles />
      <Layout />
    </ThemeProvider>
  );
}

export default App;
