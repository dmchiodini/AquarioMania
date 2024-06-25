import {
  Container,
  NavContainer,
  NavButton,
  SearchContainer,
  Search,
  ItemSubMenu,
  ItemMenu,
  ButtonSubMenu,
} from './styles';

const NavBar = () => {
  return (
    <Container>
      <NavContainer>
        <NavButton>HOME</NavButton>
        <ItemMenu>
          <NavButton className="menu">PEIXES</NavButton>
          <ItemSubMenu>
            <ButtonSubMenu>ÁGUA DOCE</ButtonSubMenu>
            <ButtonSubMenu>ÁGUA SALGADA</ButtonSubMenu>
          </ItemSubMenu>
        </ItemMenu>
        <NavButton>PLANTAS</NavButton>
        <NavButton>CORAIS</NavButton>
        <NavButton>ARTIGOS</NavButton>
        <NavButton>FÓRUM</NavButton>
      </NavContainer>
      <SearchContainer>
        <Search placeholder="Pesquisar..." />
      </SearchContainer>
    </Container>
  );
};

export default NavBar;
