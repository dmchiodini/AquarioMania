import styled from 'styled-components';

export const Container = styled.div`
  height: 50px;
  width: 100%;
  padding: 10px 20px;
  background-color: ${(props) => props.theme.colors.dark};
  display: flex;
  align-items: center;
  justify-content: space-between;
  font-size: 14px;
`;

export const NavContainer = styled.div`
  display: flex;
  gap: 20px;
  color: #fff;

  .menu {
    display: flex;
    position: relative;
  }
`;

export const NavButton = styled.button`
  background: transparent;
  border: none;

  &:focus {
    outline: 0px auto -webkit-focus-ring-color;
    outline: none;
    background-color: ${(props) => props.theme.colors.main};
  }
`;

export const ButtonSubMenu = styled.button`
  background: transparent;
  border: none;
  width: 100%;
  text-align: left;
  color: ${(props) => props.theme.colors.darker};

  &:focus {
    outline: 0px auto -webkit-focus-ring-color;
    outline: none;
    background-color: ${(props) => props.theme.colors.main};
    color: #fff;
  }

  &:hover {
    background-color: ${(props) => props.theme.colors.main};
    color: #fff;
  }
`;

export const ItemMenu = styled.div`
  position: relative;
  display: block;

  &:hover {
    div {
      display: block;
    }
  }
`;

export const ItemSubMenu = styled.div`
  position: absolute;
  display: flex;
  flex-direction: column;
  background-color: ${(props) => props.theme.colors.lighter};
  width: 200px;
  left: 0px;
  top: 30px;
  border-radius: 6px;
  display: none;

  button {
    border-radius: 6px;
  }
`;

export const SearchContainer = styled.div`
  display: flex;
  justify-content: flex-end;
  align-items: center;
  width: 100%;
  height: 100%;
`;

export const Search = styled.input`
  width: 100%;
  max-width: 300px;
  height: 35px;
  border-radius: 6px;
  background-color: #fff;
  padding: 10px;
`;
