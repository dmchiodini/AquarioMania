import NavBar from './components/Navbar';
import Header from './components/Header';
import MainImage from './components/MainImage';
import { Container } from './styles';

const MainHeader = () => {
  return (
    <Container>
      <Header />
      <MainImage />
      <NavBar />
    </Container>
  );
};

export default MainHeader;
